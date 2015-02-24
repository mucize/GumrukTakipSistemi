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
    public partial class FormYetkili : KullaniciBaseForm.KullaniciBaseForm
    {
        Form pForm;
        public FormYetkili(Form form)
        {
            InitializeComponent();
            pForm = form;
        }

        Boolean flag = false;  //FormKullanici formu closeEvent ile mi yoksa Oturumkapat ile mi kapatıldı
        private void oturumKapatButton_Click(object sender, EventArgs e)
        {
            flag = true;
            pForm.Visible = true;
            this.Close();
        }

        private void FormYetkili_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false)
                Application.Exit();
        }

        private void aracGirisButton_Click(object sender, EventArgs e)
        {
            FormAracGiris formAracGiris = new FormAracGiris();
            formAracGiris.ShowDialog();
        }

        private void tumAraclarButton_Click(object sender, EventArgs e)
        {
            FormTumAraclar formTumAraclar = new FormTumAraclar();
            formTumAraclar.ShowDialog();
        }

        private void aracCikisButton_Click(object sender, EventArgs e)
        {
            FormAracCikis formAracCikis = new FormAracCikis();
            formAracCikis.ShowDialog();
        }

        private void profilButton_Click(object sender, EventArgs e)
        {
            FormProfil formProfil = new FormProfil();
            formProfil.ShowDialog();
        }

        private void tumMemurlarButton_Click(object sender, EventArgs e)
        {
            FormTumMemurlar formTumMemurlar = new FormTumMemurlar();
            formTumMemurlar.ShowDialog();
        }
    }
}
