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
    public partial class FormKayit : Form
    {
        public FormKayit()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(FormKayit_FormClosing);
            d_TarihiDateTimePicker.MaxDate = DateTime.Now;
        }

        public static FormKayit kayitFormTutucu;

        void FormKayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            kayitFormTutucu = null;
        }

        public static FormKayit GetInstance()
        {
            if (kayitFormTutucu == null)
            {
                kayitFormTutucu = new FormKayit();
            }
            return kayitFormTutucu;
        }

        private void comboBoxPersonelTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personelTuruComboBox.SelectedIndex == 0)
            {
                yetkiliSifresiTextBox.Enabled = false;
                yetkiliSifresiLabel.Enabled = false;
                yetkiliSifresiTextBox.Clear();
            }
            else
            {
                yetkiliSifresiTextBox.Enabled = true;
                yetkiliSifresiLabel.Enabled = true;
            }

        }

        private GumrukDataClassesDataContext database = new GumrukDataClassesDataContext();

        private void kaydolButton_Click(object sender, EventArgs e)
        {

            try
            {
                if ((String.IsNullOrEmpty(adresTextBox1.Text) || String.IsNullOrEmpty(adTextBox1.Text) ||
                   String.IsNullOrEmpty(soyadTextBox1.Text) || String.IsNullOrEmpty(kullanıcı_SifresiTextBox.Text) ||
                   String.IsNullOrEmpty(emailTextBox.Text) || String.IsNullOrEmpty(telefonTextBox1.Text) ||
                   String.IsNullOrEmpty(tCTextBox1.Text) || String.IsNullOrEmpty(kullanıcı_AdiTextBox.Text)) ||
                   personelTuruComboBox.SelectedIndex == -1 || (bayanRadioButton.Checked == false && bayRadioButton.Checked == false))
                {
                    MessageBox.Show("Bilgileriniz eksik. Lütfen tam giriniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    throw new Exception();
                }

                if ((personelTuruComboBox.SelectedItem.ToString() == "Yetkili" && yetkiliSifresiTextBox.Text == "yetkili123") ||
                    (personelTuruComboBox.SelectedItem.ToString() == "Memur"))
                {
                    KULLANICI a = new KULLANICI
                    {

                        TC = tCTextBox1.Text,
                        Ad = adTextBox1.Text,
                        Soyad = soyadTextBox1.Text,
                        Email = emailTextBox.Text,
                        Kullanıcı_Adi = kullanıcı_AdiTextBox.Text,
                        Kullanıcı_Sifresi = kullanıcı_SifresiTextBox.Text,
                        Adres = adresTextBox1.Text,
                        D_Tarihi = d_TarihiDateTimePicker.Value,
                        Cinsiyet = bayRadioButton.Checked ? "bay" : "bayan",
                        Personel_Turu = personelTuruComboBox.SelectedItem.ToString(),
                        Telefon = telefonTextBox1.Text

                    };
                    if (telefonTextBox1.TextLength != 10)
                    {
                        MessageBox.Show("Telefon numaranızın başına 0 koymadan 10 haneli olarak girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        throw new Exception();
                    }
                    if (tCTextBox1.TextLength != 11)
                    {
                        MessageBox.Show("T.C. numarası 11 hane olmak zorunda!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        throw new Exception();
                    }
                    if (kullanıcı_SifresiTextBox.TextLength < 6)
                    {
                        MessageBox.Show("Güvenlik için şifre minimum 6 karakter olmak zorunda!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        throw new Exception();
                    }

                    database.KULLANICIs.InsertOnSubmit(a);
                    database.SubmitChanges();
                    MessageBox.Show("Kayıt Tamamlandı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else throw new Exception();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Tamamlanamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.Close();

        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
