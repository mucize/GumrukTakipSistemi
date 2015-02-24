namespace WindowsProjeDeneme
{
    partial class FormKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label adLabel1;
            System.Windows.Forms.Label adresLabel1;
            System.Windows.Forms.Label cinsiyetLabel1;
            System.Windows.Forms.Label d_TarihiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label kullanıcı_AdiLabel;
            System.Windows.Forms.Label kullanıcı_SifresiLabel;
            System.Windows.Forms.Label personel_TuruLabel;
            System.Windows.Forms.Label soyadLabel1;
            System.Windows.Forms.Label tCLabel1;
            System.Windows.Forms.Label telefonLabel1;
            this.bayRadioButton = new System.Windows.Forms.RadioButton();
            this.bayanRadioButton = new System.Windows.Forms.RadioButton();
            this.cinsiyetPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.personelTuruComboBox = new System.Windows.Forms.ComboBox();
            this.kULLANICIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yetkiliSifresiLabel = new System.Windows.Forms.Label();
            this.yetkiliSifresiTextBox = new System.Windows.Forms.TextBox();
            this.kaydolButton = new System.Windows.Forms.Button();
            this.adTextBox1 = new System.Windows.Forms.TextBox();
            this.adresTextBox1 = new System.Windows.Forms.TextBox();
            this.d_TarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.kullanıcı_AdiTextBox = new System.Windows.Forms.TextBox();
            this.kullanıcı_SifresiTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox1 = new System.Windows.Forms.TextBox();
            this.tCTextBox1 = new System.Windows.Forms.TextBox();
            this.telefonTextBox1 = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            adLabel1 = new System.Windows.Forms.Label();
            adresLabel1 = new System.Windows.Forms.Label();
            cinsiyetLabel1 = new System.Windows.Forms.Label();
            d_TarihiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            kullanıcı_AdiLabel = new System.Windows.Forms.Label();
            kullanıcı_SifresiLabel = new System.Windows.Forms.Label();
            personel_TuruLabel = new System.Windows.Forms.Label();
            soyadLabel1 = new System.Windows.Forms.Label();
            tCLabel1 = new System.Windows.Forms.Label();
            telefonLabel1 = new System.Windows.Forms.Label();
            this.cinsiyetPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kULLANICIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adLabel1
            // 
            adLabel1.AutoSize = true;
            adLabel1.Location = new System.Drawing.Point(74, 59);
            adLabel1.Name = "adLabel1";
            adLabel1.Size = new System.Drawing.Size(38, 17);
            adLabel1.TabIndex = 28;
            adLabel1.Text = "* Ad:";
            // 
            // adresLabel1
            // 
            adresLabel1.AutoSize = true;
            adresLabel1.Location = new System.Drawing.Point(74, 171);
            adresLabel1.Name = "adresLabel1";
            adresLabel1.Size = new System.Drawing.Size(58, 17);
            adresLabel1.TabIndex = 30;
            adresLabel1.Text = "* Adres:";
            // 
            // cinsiyetLabel1
            // 
            cinsiyetLabel1.AutoSize = true;
            cinsiyetLabel1.Location = new System.Drawing.Point(74, 199);
            cinsiyetLabel1.Name = "cinsiyetLabel1";
            cinsiyetLabel1.Size = new System.Drawing.Size(70, 17);
            cinsiyetLabel1.TabIndex = 32;
            cinsiyetLabel1.Text = "* Cinsiyet:";
            // 
            // d_TarihiLabel
            // 
            d_TarihiLabel.AutoSize = true;
            d_TarihiLabel.Location = new System.Drawing.Point(74, 228);
            d_TarihiLabel.Name = "d_TarihiLabel";
            d_TarihiLabel.Size = new System.Drawing.Size(106, 17);
            d_TarihiLabel.TabIndex = 34;
            d_TarihiLabel.Text = "* Doğum Tarihi:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(74, 255);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(55, 17);
            emailLabel.TabIndex = 36;
            emailLabel.Text = "* Email:";
            // 
            // kullanıcı_AdiLabel
            // 
            kullanıcı_AdiLabel.AutoSize = true;
            kullanıcı_AdiLabel.Location = new System.Drawing.Point(74, 283);
            kullanıcı_AdiLabel.Name = "kullanıcı_AdiLabel";
            kullanıcı_AdiLabel.Size = new System.Drawing.Size(97, 17);
            kullanıcı_AdiLabel.TabIndex = 38;
            kullanıcı_AdiLabel.Text = "* Kullanıcı Adi:";
            this.toolTip.SetToolTip(kullanıcı_AdiLabel, "Sisteme giriş adınız");
            // 
            // kullanıcı_SifresiLabel
            // 
            kullanıcı_SifresiLabel.AutoSize = true;
            kullanıcı_SifresiLabel.Location = new System.Drawing.Point(74, 311);
            kullanıcı_SifresiLabel.Name = "kullanıcı_SifresiLabel";
            kullanıcı_SifresiLabel.Size = new System.Drawing.Size(116, 17);
            kullanıcı_SifresiLabel.TabIndex = 40;
            kullanıcı_SifresiLabel.Text = "* Kullanıcı Sifresi:";
            this.toolTip.SetToolTip(kullanıcı_SifresiLabel, "Sisteme giriş şifreniz");
            // 
            // personel_TuruLabel
            // 
            personel_TuruLabel.AutoSize = true;
            personel_TuruLabel.Location = new System.Drawing.Point(74, 339);
            personel_TuruLabel.Name = "personel_TuruLabel";
            personel_TuruLabel.Size = new System.Drawing.Size(102, 17);
            personel_TuruLabel.TabIndex = 42;
            personel_TuruLabel.Text = "Personel Turu:";
            // 
            // soyadLabel1
            // 
            soyadLabel1.AutoSize = true;
            soyadLabel1.Location = new System.Drawing.Point(74, 87);
            soyadLabel1.Name = "soyadLabel1";
            soyadLabel1.Size = new System.Drawing.Size(61, 17);
            soyadLabel1.TabIndex = 44;
            soyadLabel1.Text = "* Soyad:";
            // 
            // tCLabel1
            // 
            tCLabel1.AutoSize = true;
            tCLabel1.Location = new System.Drawing.Point(74, 115);
            tCLabel1.Name = "tCLabel1";
            tCLabel1.Size = new System.Drawing.Size(39, 17);
            tCLabel1.TabIndex = 46;
            tCLabel1.Text = "* TC:";
            // 
            // telefonLabel1
            // 
            telefonLabel1.AutoSize = true;
            telefonLabel1.Location = new System.Drawing.Point(74, 143);
            telefonLabel1.Name = "telefonLabel1";
            telefonLabel1.Size = new System.Drawing.Size(69, 17);
            telefonLabel1.TabIndex = 48;
            telefonLabel1.Text = "* Telefon:";
            // 
            // bayRadioButton
            // 
            this.bayRadioButton.AutoSize = true;
            this.bayRadioButton.Location = new System.Drawing.Point(17, 1);
            this.bayRadioButton.Name = "bayRadioButton";
            this.bayRadioButton.Size = new System.Drawing.Size(53, 21);
            this.bayRadioButton.TabIndex = 12;
            this.bayRadioButton.TabStop = true;
            this.bayRadioButton.Text = "Bay";
            this.bayRadioButton.UseVisualStyleBackColor = true;
            // 
            // bayanRadioButton
            // 
            this.bayanRadioButton.AutoSize = true;
            this.bayanRadioButton.Location = new System.Drawing.Point(109, -1);
            this.bayanRadioButton.Name = "bayanRadioButton";
            this.bayanRadioButton.Size = new System.Drawing.Size(69, 21);
            this.bayanRadioButton.TabIndex = 13;
            this.bayanRadioButton.TabStop = true;
            this.bayanRadioButton.Text = "Bayan";
            this.bayanRadioButton.UseVisualStyleBackColor = true;
            // 
            // cinsiyetPanel
            // 
            this.cinsiyetPanel.Controls.Add(this.bayanRadioButton);
            this.cinsiyetPanel.Controls.Add(this.bayRadioButton);
            this.cinsiyetPanel.Location = new System.Drawing.Point(187, 196);
            this.cinsiyetPanel.Name = "cinsiyetPanel";
            this.cinsiyetPanel.Size = new System.Drawing.Size(200, 22);
            this.cinsiyetPanel.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 550);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(458, 25);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(216, 20);
            this.toolStripStatusLabel1.Text = "* Alanlar Doldurulmak Zorunda";
            // 
            // personelTuruComboBox
            // 
            this.personelTuruComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Personel_Turu", true));
            this.personelTuruComboBox.FormattingEnabled = true;
            this.personelTuruComboBox.Items.AddRange(new object[] {
            "Memur",
            "Yetkili"});
            this.personelTuruComboBox.Location = new System.Drawing.Point(187, 334);
            this.personelTuruComboBox.Name = "personelTuruComboBox";
            this.personelTuruComboBox.Size = new System.Drawing.Size(200, 24);
            this.personelTuruComboBox.TabIndex = 10;
            this.personelTuruComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBoxPersonelTuru_SelectedIndexChanged);
            // 
            // kULLANICIBindingSource
            // 
            this.kULLANICIBindingSource.DataSource = typeof(WindowsProjeDeneme.KULLANICI);
            // 
            // yetkiliSifresiLabel
            // 
            this.yetkiliSifresiLabel.AutoSize = true;
            this.yetkiliSifresiLabel.Enabled = false;
            this.yetkiliSifresiLabel.Location = new System.Drawing.Point(72, 369);
            this.yetkiliSifresiLabel.Name = "yetkiliSifresiLabel";
            this.yetkiliSifresiLabel.Size = new System.Drawing.Size(105, 17);
            this.yetkiliSifresiLabel.TabIndex = 19;
            this.yetkiliSifresiLabel.Text = "* Yetkili Sifresi :";
            // 
            // yetkiliSifresiTextBox
            // 
            this.yetkiliSifresiTextBox.Enabled = false;
            this.yetkiliSifresiTextBox.Location = new System.Drawing.Point(187, 364);
            this.yetkiliSifresiTextBox.Name = "yetkiliSifresiTextBox";
            this.yetkiliSifresiTextBox.Size = new System.Drawing.Size(200, 22);
            this.yetkiliSifresiTextBox.TabIndex = 11;
            this.yetkiliSifresiTextBox.UseSystemPasswordChar = true;
            // 
            // kaydolButton
            // 
            this.kaydolButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydolButton.Location = new System.Drawing.Point(187, 456);
            this.kaydolButton.Name = "kaydolButton";
            this.kaydolButton.Size = new System.Drawing.Size(112, 51);
            this.kaydolButton.TabIndex = 12;
            this.kaydolButton.Text = "KAYDOL";
            this.kaydolButton.UseVisualStyleBackColor = true;
            this.kaydolButton.Click += new System.EventHandler(this.kaydolButton_Click);
            // 
            // adTextBox1
            // 
            this.adTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Ad", true));
            this.adTextBox1.Location = new System.Drawing.Point(187, 54);
            this.adTextBox1.Name = "adTextBox1";
            this.adTextBox1.Size = new System.Drawing.Size(200, 22);
            this.adTextBox1.TabIndex = 0;
            // 
            // adresTextBox1
            // 
            this.adresTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Adres", true));
            this.adresTextBox1.Location = new System.Drawing.Point(187, 168);
            this.adresTextBox1.Name = "adresTextBox1";
            this.adresTextBox1.Size = new System.Drawing.Size(200, 22);
            this.adresTextBox1.TabIndex = 4;
            // 
            // d_TarihiDateTimePicker
            // 
            this.d_TarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kULLANICIBindingSource, "D_Tarihi", true));
            this.d_TarihiDateTimePicker.Location = new System.Drawing.Point(187, 224);
            this.d_TarihiDateTimePicker.Name = "d_TarihiDateTimePicker";
            this.d_TarihiDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.d_TarihiDateTimePicker.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(187, 252);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 7;
            // 
            // kullanıcı_AdiTextBox
            // 
            this.kullanıcı_AdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Kullanıcı_Adi", true));
            this.kullanıcı_AdiTextBox.Location = new System.Drawing.Point(187, 280);
            this.kullanıcı_AdiTextBox.Name = "kullanıcı_AdiTextBox";
            this.kullanıcı_AdiTextBox.Size = new System.Drawing.Size(200, 22);
            this.kullanıcı_AdiTextBox.TabIndex = 8;
            // 
            // kullanıcı_SifresiTextBox
            // 
            this.kullanıcı_SifresiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Kullanıcı_Sifresi", true));
            this.kullanıcı_SifresiTextBox.Location = new System.Drawing.Point(187, 308);
            this.kullanıcı_SifresiTextBox.Name = "kullanıcı_SifresiTextBox";
            this.kullanıcı_SifresiTextBox.Size = new System.Drawing.Size(200, 22);
            this.kullanıcı_SifresiTextBox.TabIndex = 9;
            this.kullanıcı_SifresiTextBox.UseSystemPasswordChar = true;
            // 
            // soyadTextBox1
            // 
            this.soyadTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Soyad", true));
            this.soyadTextBox1.Location = new System.Drawing.Point(187, 84);
            this.soyadTextBox1.Name = "soyadTextBox1";
            this.soyadTextBox1.Size = new System.Drawing.Size(200, 22);
            this.soyadTextBox1.TabIndex = 1;
            // 
            // tCTextBox1
            // 
            this.tCTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "TC", true));
            this.tCTextBox1.Location = new System.Drawing.Point(187, 112);
            this.tCTextBox1.MaxLength = 11;
            this.tCTextBox1.Name = "tCTextBox1";
            this.tCTextBox1.Size = new System.Drawing.Size(200, 22);
            this.tCTextBox1.TabIndex = 2;
            this.tCTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // telefonTextBox1
            // 
            this.telefonTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Telefon", true));
            this.telefonTextBox1.Location = new System.Drawing.Point(187, 140);
            this.telefonTextBox1.MaxLength = 10;
            this.telefonTextBox1.Name = "telefonTextBox1";
            this.telefonTextBox1.Size = new System.Drawing.Size(200, 22);
            this.telefonTextBox1.TabIndex = 3;
            this.telefonTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // FormKayit
            // 
            this.AcceptButton = this.kaydolButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(458, 575);
            this.Controls.Add(adLabel1);
            this.Controls.Add(this.adTextBox1);
            this.Controls.Add(adresLabel1);
            this.Controls.Add(this.adresTextBox1);
            this.Controls.Add(cinsiyetLabel1);
            this.Controls.Add(d_TarihiLabel);
            this.Controls.Add(this.d_TarihiDateTimePicker);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(kullanıcı_AdiLabel);
            this.Controls.Add(this.kullanıcı_AdiTextBox);
            this.Controls.Add(kullanıcı_SifresiLabel);
            this.Controls.Add(this.kullanıcı_SifresiTextBox);
            this.Controls.Add(personel_TuruLabel);
            this.Controls.Add(soyadLabel1);
            this.Controls.Add(this.soyadTextBox1);
            this.Controls.Add(tCLabel1);
            this.Controls.Add(this.tCTextBox1);
            this.Controls.Add(telefonLabel1);
            this.Controls.Add(this.telefonTextBox1);
            this.Controls.Add(this.kaydolButton);
            this.Controls.Add(this.yetkiliSifresiTextBox);
            this.Controls.Add(this.yetkiliSifresiLabel);
            this.Controls.Add(this.personelTuruComboBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cinsiyetPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKayit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKayit_FormClosing);
            this.cinsiyetPanel.ResumeLayout(false);
            this.cinsiyetPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kULLANICIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton bayRadioButton;
        private System.Windows.Forms.RadioButton bayanRadioButton;
        private System.Windows.Forms.Panel cinsiyetPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox personelTuruComboBox;
        private System.Windows.Forms.Label yetkiliSifresiLabel;
        private System.Windows.Forms.TextBox yetkiliSifresiTextBox;
        private System.Windows.Forms.Button kaydolButton;
        private System.Windows.Forms.BindingSource kULLANICIBindingSource;
        private System.Windows.Forms.TextBox adTextBox1;
        private System.Windows.Forms.TextBox adresTextBox1;
        private System.Windows.Forms.DateTimePicker d_TarihiDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox kullanıcı_AdiTextBox;
        private System.Windows.Forms.TextBox kullanıcı_SifresiTextBox;
        private System.Windows.Forms.TextBox soyadTextBox1;
        private System.Windows.Forms.TextBox tCTextBox1;
        private System.Windows.Forms.TextBox telefonTextBox1;
        private System.Windows.Forms.ToolTip toolTip;


    }
}