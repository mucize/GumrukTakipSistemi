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
    public partial class FormGiris : Form
    {

        public static Form pForm;

        public FormGiris()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(FormGiris_FormClosing);
            // 1 tane FormGiris kapanmadan ikincisinin açılmaması için 
        }

        public static FormGiris girisFormTutucu; //Açık FormGiris olup olmadığını anlamak için

        void FormGiris_FormClosing(object sender, FormClosingEventArgs e) //FormGiris kapanma event'i
        {
            girisFormTutucu = null;
        }

        public static FormGiris GetInstance(Form parentForm)
        {
            pForm = parentForm;
            if (girisFormTutucu == null)
            {
                girisFormTutucu = new FormGiris();
            }
            return girisFormTutucu;
        }

        public static String tc;
        private GumrukDataClassesDataContext database = new GumrukDataClassesDataContext();

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            kULLANICIBindingSource.DataSource = from KULLANICI in database.KULLANICIs
                                                where ((KULLANICI.Kullanıcı_Adi.Equals(kullaniciAdiTextBox.Text))
                                                && (KULLANICI.Kullanıcı_Sifresi == sifreTextBox.Text))
                                                select KULLANICI.TC;

            if (kULLANICIBindingSource.Current!=null)
            tc = kULLANICIBindingSource.Current.ToString();

            kULLANICIBindingSource.DataSource = from KULLANICI in database.KULLANICIs
                                                where ((KULLANICI.Kullanıcı_Adi.Equals(kullaniciAdiTextBox.Text))
                                                && (KULLANICI.Kullanıcı_Sifresi == sifreTextBox.Text))
                                                select KULLANICI.Personel_Turu;


            

            if (kULLANICIBindingSource.Current != null)
            {
                if (kULLANICIBindingSource.Current.ToString() == "Yetkili")
                {
                    FormYetkili formYetkili = new FormYetkili(pForm);
                    formYetkili.Show();
                    this.Close();
                    pForm.Hide();
                }
                else if (kULLANICIBindingSource.Current.ToString() == "Memur")
                {
                    FormMemur formMemur = new FormMemur(pForm);
                    formMemur.Show();
                    this.Close();
                    pForm.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }

}