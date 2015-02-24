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
    public partial class FormAracCikis : Form
    {
        public FormAracCikis()
        {
            InitializeComponent();
        }

        private GumrukDataClassesDataContext database = new GumrukDataClassesDataContext();

        private void aracKaydetButton_Click(object sender, EventArgs e)
        {
            try
            {
                TASIMALAR tasimalar = new TASIMALAR
                {
                    Plaka = plakaTextBox.Text,
                    Arac_Cinsi = arac_CinsiTextBox.Text,
                    Ulkesi = ulkesiTextBox.Text,
                    Firma = firmaTextBox.Text,
                    Surucu_Pasaport_No = Convert.ToInt32(surucu_Pasaport_NoTextBox.Text),
                    Surucu_Ad = surucu_AdTextBox.Text,
                    Surucu_Soyad = surucu_SoyadTextBox.Text,
                    Surucu_Uyruk = surucu_UyrukTextBox.Text,
                    Yuk_Cinsi = yuk_CinsiTextBox.Text,
                    Miktar = Convert.ToDouble(miktarTextBox.Text),
                    Olcu_Birimi = olcuBirimiComboBox.SelectedItem.ToString(),
                    Giris_Zamanı = giris_ZamanıDateTimePicker.Value,
                    Cıkıs_Zamanı = null,
                    Geldigi_Yer = geldigi_YerTextBox.Text,
                    Gidecegi_Yer = gidecegi_YerTextBox.Text,
                    Memur_TC = FormGiris.tc,
                    Giris_Cıkıs = true
                };

                database.TASIMALARs.InsertOnSubmit(tasimalar);

                database.SubmitChanges();
                MessageBox.Show("Kayıt tamamlandı!", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı Veri Girişi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void giris_ZamanıDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            cıkıs_ZamanıDateTimePicker.MinDate = giris_ZamanıDateTimePicker.Value;
        }


    }
}
