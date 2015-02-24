using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProjeDeneme
{
    public partial class FormProfil : Form
    {
        

        public FormProfil()
        {
            InitializeComponent();
        }

        private GumrukDataClassesDataContext database = new GumrukDataClassesDataContext();

        private void FormProfil_Load(object sender, EventArgs e)
        {
            kULLANICIBindingSource.DataSource = from kullanici in database.KULLANICIs
                                                where FormGiris.tc == kullanici.TC.ToString()
                                                select kullanici;

            KULLANICI yetkili= database.KULLANICIs.First(k => k.TC.ToString() == FormGiris.tc);
           
            
            if( yetkili.Personel_Turu.ToString()=="Yetkili")
            {
                tCTextBox.ReadOnly = false;
                cinsiyetTextBox.ReadOnly = false;
                kullanıcı_AdiTextBox.ReadOnly = false;
                personelTuruComboBox.Enabled = true;
            }
                                            
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!(String.IsNullOrEmpty(adresTextBox.Text) || String.IsNullOrEmpty(adTextBox.Text) ||
                    String.IsNullOrEmpty(soyadTextBox.Text) || String.IsNullOrEmpty(kullanıcı_SifresiTextBox.Text) ||
                    String.IsNullOrEmpty(emailTextBox.Text) || String.IsNullOrEmpty(telefonTextBox.Text)))
                {
                    KULLANICI kullanici = database.KULLANICIs.First(k => k.TC.ToString() == FormGiris.tc);
                    
                    kullanici.Ad = adTextBox.Text;
                    kullanici.Soyad = soyadTextBox.Text;
                    kullanici.Adres = adresTextBox.Text;
                    kullanici.D_Tarihi = d_TarihiDateTimePicker.Value;
                    kullanici.Kullanıcı_Sifresi = kullanıcı_SifresiTextBox.Text;
                    kullanici.Email = emailTextBox.Text;
                    kullanici.Telefon = telefonTextBox.Text;
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
                    if (kullanıcı_SifresiTextBox.TextLength < 6)
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

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
