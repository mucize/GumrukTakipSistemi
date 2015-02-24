using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProjeDeneme
{
    public partial class FormTumMemurlar : Form
    {
        public FormTumMemurlar()
        {
            InitializeComponent();
        }

        GumrukDataClassesDataContext database = new GumrukDataClassesDataContext();

        private void FormTumMemurlar_Load(object sender, EventArgs e)
        {
            RefreshMemur();
        }

        private void RefreshMemur()
        {
            memurlarListBox.Items.Clear();
            var memurData = from memur in database.KULLANICIs
                            where memur.Personel_Turu == "Memur"
                            orderby memur.Ad
                            select new { memur.Ad, memur.Soyad };

            foreach (var item in memurData)
            {
                memurlarListBox.Items.Add(item.Ad + " " + item.Soyad);
            }
        
        }

        String[] adSoyad;
        private void memurlarListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            adSoyad=memurlarListBox.SelectedItem.ToString().Split(' ');

            kULLANICIBindingSource.DataSource = from memur in database.KULLANICIs
                                                where memur.Ad == adSoyad[0] && memur.Soyad == adSoyad[1]
                                                select memur;
        }

        private void güncelleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(String.IsNullOrEmpty(adresTextBox.Text) || String.IsNullOrEmpty(adTextBox.Text) ||
                    String.IsNullOrEmpty(soyadTextBox.Text) || String.IsNullOrEmpty(kullanıcı_SifresiTextBox.Text) ||
                    String.IsNullOrEmpty(emailTextBox.Text) || String.IsNullOrEmpty(telefonTextBox.Text) ||
                    String.IsNullOrEmpty(tCTextBox.Text) || String.IsNullOrEmpty(cinsiyetTextBox.Text) ||
                    String.IsNullOrEmpty(kullanıcı_AdiTextBox.Text)) || personelTuruComboBox.SelectedIndex == -1)
                {

                    KULLANICI kullanici = database.KULLANICIs.First(k => k.Ad == adSoyad[0] && k.Soyad == adSoyad[1]);
                                          
                    kullanici.Ad = adTextBox.Text;
                    kullanici.Soyad = soyadTextBox.Text;
                    kullanici.Adres = adresTextBox.Text;
                    kullanici.D_Tarihi = d_TarihiDateTimePicker.Value;
                    kullanici.Kullanıcı_Sifresi = kullanıcı_SifresiTextBox.Text;
                    kullanici.Email = emailTextBox.Text;
                    kullanici.Telefon = telefonTextBox.Text;
                    kullanici.TC = tCTextBox.Text;
                    kullanici.Cinsiyet = cinsiyetTextBox.Text;
                    kullanici.Kullanıcı_Adi = kullanıcı_AdiTextBox.Text;
                    kullanici.Personel_Turu = personelTuruComboBox.SelectedItem.ToString();

                    if (telefonTextBox.TextLength != 10)
                    {
                        MessageBox.Show("Telefon numaranızın başına 0 koymadan 10 haneli olarak girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        throw new Exception();
                    }
                    if (tCTextBox.TextLength != 11)
                    {
                        MessageBox.Show("T.C. numarası 11 hane olmak zorunda!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        throw new Exception();
                    }
                    if(kullanıcı_SifresiTextBox.TextLength<6)
                    {
                        MessageBox.Show("Güvenlik için şifre minimum 6 karakter olmak zorunda!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        throw new Exception();
                    }
                    database.SubmitChanges();

                    MessageBox.Show("Güncelleme Tamamlandı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else throw new Exception();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Tamamlanamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?","Mesaj",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    KULLANICI kullanici = database.KULLANICIs.First(k => k.Ad == adSoyad[0] && k.Soyad == adSoyad[1]);

                    database.KULLANICIs.DeleteOnSubmit(kullanici);
                    database.SubmitChanges();

                    MessageBox.Show("Silme Tamamlandı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshMemur();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme Gerçekleştirilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
