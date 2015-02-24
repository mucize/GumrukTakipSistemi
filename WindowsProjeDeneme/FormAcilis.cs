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
    public partial class FormAcilis : Form
    {
        FormGiris formGiris;
        FormKayit formKayit;

        //FormAcilis Parent
        public FormAcilis()
        {
            InitializeComponent();
        }
        //FormGiris Child
        private void girisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGiris = FormGiris.GetInstance(this);
            formGiris.MdiParent = this;
            formGiris.Show();
            if (formKayit != null)
                formKayit.Close();
        }
        //FormKayit Child
        private void kayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            formKayit = FormKayit.GetInstance();
            formKayit.MdiParent = this;
            formKayit.Show();
            if (formGiris != null)
                formGiris.Close();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //Mdi form'un arka planını değiştirme:
        private void FormAcilis_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.Teal;
                    break;
                }
            }
        }

        private void bilgiLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bilgiLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.ege.edu.tr");
        }
    }
}
