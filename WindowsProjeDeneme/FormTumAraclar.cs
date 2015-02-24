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
    public partial class FormTumAraclar : Form
    {
        public FormTumAraclar()
        {
            InitializeComponent();
        }
        
        private GumrukDataClassesDataContext database = new GumrukDataClassesDataContext();
        
        

        private void FormTumAraclar_Load(object sender, EventArgs e)
        {
            tASIMALARBindingSource.DataSource = from TASIMALAR in database.TASIMALARs
                                             select TASIMALAR;

            firmaAdiComboBox.DataSource = (from arac in database.TASIMALARs
                                           orderby arac.Firma
                                           select arac.Firma).Distinct();

            plakaComboBox.DataSource = (from arac in database.TASIMALARs
                                        orderby arac.Plaka
                                        select arac.Plaka).Distinct();

            pasaportNoComboBox.DataSource = (from surucu in database.TASIMALARs
                                             orderby surucu.Surucu_Pasaport_No
                                             select surucu.Surucu_Pasaport_No).Distinct();

            geldigiYerComboBox.DataSource = (from tasıma in database.TASIMALARs
                                             orderby tasıma.Geldigi_Yer
                                             select tasıma.Geldigi_Yer).Distinct();

            gidecegiYerComboBox.DataSource = (from tasıma in database.TASIMALARs
                                             orderby tasıma.Gidecegi_Yer
                                             select tasıma.Gidecegi_Yer).Distinct();


            firmaAdiComboBox.SelectedIndex = -1;
            plakaComboBox.SelectedIndex = -1;
            pasaportNoComboBox.SelectedIndex = -1;
            geldigiYerComboBox.SelectedIndex = -1;
            gidecegiYerComboBox.SelectedIndex = -1;


         
        }

        private void aramaButton_Click(object sender, EventArgs e)
        {
            var gumruk = from tasimalar in database.TASIMALARs
                         select tasimalar;
           

            if (firmaAdiComboBox.SelectedIndex!=-1)
            {
                gumruk= from tasima in gumruk
                        where tasima.Firma == firmaAdiComboBox.SelectedItem.ToString()
                        select tasima;
            }
            if (plakaComboBox.SelectedIndex != -1)
            {
                gumruk = from tasima in gumruk
                         where tasima.Plaka == plakaComboBox.SelectedItem.ToString()
                         select tasima;
            }
            if (pasaportNoComboBox.SelectedIndex != -1)
            {
                gumruk = from tasima in gumruk
                         where tasima.Surucu_Pasaport_No == Convert.ToInt32(pasaportNoComboBox.SelectedItem)
                         select tasima;
            }
            if (!(ulkeyeGirenlerCheckBox.Checked == true && ulkedenCikanlarCheckBox.Checked == true))
            {
                if (ulkeyeGirenlerCheckBox.Checked == true)
                {
                    gumruk = from tasima in gumruk
                             where tasima.Giris_Cıkıs == true
                             select tasima;
                }
                if (ulkedenCikanlarCheckBox.Checked == true)
                {
                    gumruk = from tasima in gumruk
                             where tasima.Giris_Cıkıs == false
                             select tasima;
                }
                if (ulkeyeGirenlerCheckBox.Checked == false && ulkedenCikanlarCheckBox.Checked == false)
                    gumruk = null;
            }
            if (geldigiYerComboBox.SelectedIndex != -1)
            {
                gumruk = from tasima in gumruk
                         where tasima.Geldigi_Yer == geldigiYerComboBox.SelectedItem.ToString()
                         select tasima;
            }
            if (gidecegiYerComboBox.SelectedIndex != -1)
            {
                gumruk = from tasima in gumruk
                         where tasima.Gidecegi_Yer == gidecegiYerComboBox.SelectedItem.ToString()
                         select tasima;
            }
            
            
            tASIMALARBindingSource.DataSource = gumruk;

          
        }

      
    }
}
