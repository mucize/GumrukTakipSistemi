namespace WindowsProjeDeneme
{
    partial class FormTumMemurlar
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
            System.Windows.Forms.Label adLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label cinsiyetLabel;
            System.Windows.Forms.Label d_TarihiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label kullanıcı_AdiLabel;
            System.Windows.Forms.Label kullanıcı_SifresiLabel;
            System.Windows.Forms.Label personel_TuruLabel;
            System.Windows.Forms.Label soyadLabel;
            System.Windows.Forms.Label tCLabel;
            System.Windows.Forms.Label telefonLabel;
            this.memurlarListBox = new System.Windows.Forms.ListBox();
            this.kULLANICIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.cinsiyetTextBox = new System.Windows.Forms.TextBox();
            this.d_TarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.kullanıcı_AdiTextBox = new System.Windows.Forms.TextBox();
            this.kullanıcı_SifresiTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.tCTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.memurBilgisiGroupBox = new System.Windows.Forms.GroupBox();
            this.memurlarGroupBox = new System.Windows.Forms.GroupBox();
            this.güncelleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.personelTuruComboBox = new System.Windows.Forms.ComboBox();
            adLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            cinsiyetLabel = new System.Windows.Forms.Label();
            d_TarihiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            kullanıcı_AdiLabel = new System.Windows.Forms.Label();
            kullanıcı_SifresiLabel = new System.Windows.Forms.Label();
            personel_TuruLabel = new System.Windows.Forms.Label();
            soyadLabel = new System.Windows.Forms.Label();
            tCLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kULLANICIBindingSource)).BeginInit();
            this.memurBilgisiGroupBox.SuspendLayout();
            this.memurlarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.Location = new System.Drawing.Point(22, 72);
            adLabel.Name = "adLabel";
            adLabel.Size = new System.Drawing.Size(29, 17);
            adLabel.TabIndex = 2;
            adLabel.Text = "Ad:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new System.Drawing.Point(22, 156);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(49, 17);
            adresLabel.TabIndex = 4;
            adresLabel.Text = "Adres:";
            // 
            // cinsiyetLabel
            // 
            cinsiyetLabel.AutoSize = true;
            cinsiyetLabel.Location = new System.Drawing.Point(22, 128);
            cinsiyetLabel.Name = "cinsiyetLabel";
            cinsiyetLabel.Size = new System.Drawing.Size(61, 17);
            cinsiyetLabel.TabIndex = 6;
            cinsiyetLabel.Text = "Cinsiyet:";
            // 
            // d_TarihiLabel
            // 
            d_TarihiLabel.AutoSize = true;
            d_TarihiLabel.Location = new System.Drawing.Point(22, 269);
            d_TarihiLabel.Name = "d_TarihiLabel";
            d_TarihiLabel.Size = new System.Drawing.Size(62, 17);
            d_TarihiLabel.TabIndex = 8;
            d_TarihiLabel.Text = "D Tarihi:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(22, 296);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // kullanıcı_AdiLabel
            // 
            kullanıcı_AdiLabel.AutoSize = true;
            kullanıcı_AdiLabel.Location = new System.Drawing.Point(22, 324);
            kullanıcı_AdiLabel.Name = "kullanıcı_AdiLabel";
            kullanıcı_AdiLabel.Size = new System.Drawing.Size(88, 17);
            kullanıcı_AdiLabel.TabIndex = 12;
            kullanıcı_AdiLabel.Text = "Kullanıcı Adi:";
            // 
            // kullanıcı_SifresiLabel
            // 
            kullanıcı_SifresiLabel.AutoSize = true;
            kullanıcı_SifresiLabel.Location = new System.Drawing.Point(22, 352);
            kullanıcı_SifresiLabel.Name = "kullanıcı_SifresiLabel";
            kullanıcı_SifresiLabel.Size = new System.Drawing.Size(107, 17);
            kullanıcı_SifresiLabel.TabIndex = 14;
            kullanıcı_SifresiLabel.Text = "Kullanıcı Sifresi:";
            // 
            // personel_TuruLabel
            // 
            personel_TuruLabel.AutoSize = true;
            personel_TuruLabel.Location = new System.Drawing.Point(22, 380);
            personel_TuruLabel.Name = "personel_TuruLabel";
            personel_TuruLabel.Size = new System.Drawing.Size(102, 17);
            personel_TuruLabel.TabIndex = 16;
            personel_TuruLabel.Text = "Personel Turu:";
            // 
            // soyadLabel
            // 
            soyadLabel.AutoSize = true;
            soyadLabel.Location = new System.Drawing.Point(22, 100);
            soyadLabel.Name = "soyadLabel";
            soyadLabel.Size = new System.Drawing.Size(52, 17);
            soyadLabel.TabIndex = 18;
            soyadLabel.Text = "Soyad:";
            // 
            // tCLabel
            // 
            tCLabel.AutoSize = true;
            tCLabel.Location = new System.Drawing.Point(22, 44);
            tCLabel.Name = "tCLabel";
            tCLabel.Size = new System.Drawing.Size(30, 17);
            tCLabel.TabIndex = 20;
            tCLabel.Text = "TC:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(22, 408);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(60, 17);
            telefonLabel.TabIndex = 22;
            telefonLabel.Text = "Telefon:";
            // 
            // memurlarListBox
            // 
            this.memurlarListBox.FormattingEnabled = true;
            this.memurlarListBox.ItemHeight = 16;
            this.memurlarListBox.Location = new System.Drawing.Point(6, 21);
            this.memurlarListBox.Name = "memurlarListBox";
            this.memurlarListBox.Size = new System.Drawing.Size(236, 420);
            this.memurlarListBox.TabIndex = 0;
            this.memurlarListBox.SelectedIndexChanged += new System.EventHandler(this.memurlarListBox_SelectedIndexChanged);
            // 
            // kULLANICIBindingSource
            // 
            this.kULLANICIBindingSource.DataSource = typeof(WindowsProjeDeneme.KULLANICI);
            // 
            // adTextBox
            // 
            this.adTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Ad", true));
            this.adTextBox.Location = new System.Drawing.Point(135, 69);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(200, 22);
            this.adTextBox.TabIndex = 1;
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Adres", true));
            this.adresTextBox.Location = new System.Drawing.Point(135, 153);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(200, 103);
            this.adresTextBox.TabIndex = 4;
            // 
            // cinsiyetTextBox
            // 
            this.cinsiyetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Cinsiyet", true));
            this.cinsiyetTextBox.Location = new System.Drawing.Point(135, 125);
            this.cinsiyetTextBox.Name = "cinsiyetTextBox";
            this.cinsiyetTextBox.Size = new System.Drawing.Size(200, 22);
            this.cinsiyetTextBox.TabIndex = 3;
            // 
            // d_TarihiDateTimePicker
            // 
            this.d_TarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kULLANICIBindingSource, "D_Tarihi", true));
            this.d_TarihiDateTimePicker.Location = new System.Drawing.Point(135, 265);
            this.d_TarihiDateTimePicker.Name = "d_TarihiDateTimePicker";
            this.d_TarihiDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.d_TarihiDateTimePicker.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(135, 293);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 6;
            // 
            // kullanıcı_AdiTextBox
            // 
            this.kullanıcı_AdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Kullanıcı_Adi", true));
            this.kullanıcı_AdiTextBox.Location = new System.Drawing.Point(135, 321);
            this.kullanıcı_AdiTextBox.Name = "kullanıcı_AdiTextBox";
            this.kullanıcı_AdiTextBox.Size = new System.Drawing.Size(200, 22);
            this.kullanıcı_AdiTextBox.TabIndex = 7;
            // 
            // kullanıcı_SifresiTextBox
            // 
            this.kullanıcı_SifresiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Kullanıcı_Sifresi", true));
            this.kullanıcı_SifresiTextBox.Location = new System.Drawing.Point(135, 349);
            this.kullanıcı_SifresiTextBox.Name = "kullanıcı_SifresiTextBox";
            this.kullanıcı_SifresiTextBox.Size = new System.Drawing.Size(200, 22);
            this.kullanıcı_SifresiTextBox.TabIndex = 8;
            this.kullanıcı_SifresiTextBox.UseSystemPasswordChar = true;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Soyad", true));
            this.soyadTextBox.Location = new System.Drawing.Point(135, 97);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(200, 22);
            this.soyadTextBox.TabIndex = 2;
            // 
            // tCTextBox
            // 
            this.tCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "TC", true));
            this.tCTextBox.Location = new System.Drawing.Point(135, 41);
            this.tCTextBox.MaxLength = 11;
            this.tCTextBox.Name = "tCTextBox";
            this.tCTextBox.Size = new System.Drawing.Size(200, 22);
            this.tCTextBox.TabIndex = 0;
            this.tCTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(135, 405);
            this.telefonTextBox.MaxLength = 10;
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(200, 22);
            this.telefonTextBox.TabIndex = 10;
            this.telefonTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // memurBilgisiGroupBox
            // 
            this.memurBilgisiGroupBox.Controls.Add(this.personelTuruComboBox);
            this.memurBilgisiGroupBox.Controls.Add(this.telefonTextBox);
            this.memurBilgisiGroupBox.Controls.Add(adLabel);
            this.memurBilgisiGroupBox.Controls.Add(telefonLabel);
            this.memurBilgisiGroupBox.Controls.Add(this.tCTextBox);
            this.memurBilgisiGroupBox.Controls.Add(tCLabel);
            this.memurBilgisiGroupBox.Controls.Add(this.adresTextBox);
            this.memurBilgisiGroupBox.Controls.Add(adresLabel);
            this.memurBilgisiGroupBox.Controls.Add(this.adTextBox);
            this.memurBilgisiGroupBox.Controls.Add(this.soyadTextBox);
            this.memurBilgisiGroupBox.Controls.Add(cinsiyetLabel);
            this.memurBilgisiGroupBox.Controls.Add(soyadLabel);
            this.memurBilgisiGroupBox.Controls.Add(this.cinsiyetTextBox);
            this.memurBilgisiGroupBox.Controls.Add(d_TarihiLabel);
            this.memurBilgisiGroupBox.Controls.Add(personel_TuruLabel);
            this.memurBilgisiGroupBox.Controls.Add(this.d_TarihiDateTimePicker);
            this.memurBilgisiGroupBox.Controls.Add(this.kullanıcı_SifresiTextBox);
            this.memurBilgisiGroupBox.Controls.Add(emailLabel);
            this.memurBilgisiGroupBox.Controls.Add(kullanıcı_SifresiLabel);
            this.memurBilgisiGroupBox.Controls.Add(this.emailTextBox);
            this.memurBilgisiGroupBox.Controls.Add(this.kullanıcı_AdiTextBox);
            this.memurBilgisiGroupBox.Controls.Add(kullanıcı_AdiLabel);
            this.memurBilgisiGroupBox.Location = new System.Drawing.Point(463, 76);
            this.memurBilgisiGroupBox.Name = "memurBilgisiGroupBox";
            this.memurBilgisiGroupBox.Size = new System.Drawing.Size(366, 454);
            this.memurBilgisiGroupBox.TabIndex = 24;
            this.memurBilgisiGroupBox.TabStop = false;
            this.memurBilgisiGroupBox.Text = "Memur Bilgisi";
            // 
            // memurlarGroupBox
            // 
            this.memurlarGroupBox.Controls.Add(this.memurlarListBox);
            this.memurlarGroupBox.Location = new System.Drawing.Point(67, 76);
            this.memurlarGroupBox.Name = "memurlarGroupBox";
            this.memurlarGroupBox.Size = new System.Drawing.Size(248, 454);
            this.memurlarGroupBox.TabIndex = 25;
            this.memurlarGroupBox.TabStop = false;
            this.memurlarGroupBox.Text = "Memurlar";
            // 
            // güncelleButton
            // 
            this.güncelleButton.Location = new System.Drawing.Point(709, 555);
            this.güncelleButton.Name = "güncelleButton";
            this.güncelleButton.Size = new System.Drawing.Size(120, 47);
            this.güncelleButton.TabIndex = 1;
            this.güncelleButton.Text = "GÜNCELLE";
            this.güncelleButton.UseVisualStyleBackColor = true;
            this.güncelleButton.Click += new System.EventHandler(this.güncelleButton_Click);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(463, 555);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(120, 47);
            this.silButton.TabIndex = 0;
            this.silButton.Text = "SİL";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // personelTuruComboBox
            // 
            this.personelTuruComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kULLANICIBindingSource, "Personel_Turu", true));
            this.personelTuruComboBox.FormattingEnabled = true;
            this.personelTuruComboBox.Items.AddRange(new object[] {
            "Memur",
            "Yetkili"});
            this.personelTuruComboBox.Location = new System.Drawing.Point(135, 375);
            this.personelTuruComboBox.Name = "personelTuruComboBox";
            this.personelTuruComboBox.Size = new System.Drawing.Size(200, 24);
            this.personelTuruComboBox.TabIndex = 26;
            // 
            // FormTumMemurlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1011, 646);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.güncelleButton);
            this.Controls.Add(this.memurlarGroupBox);
            this.Controls.Add(this.memurBilgisiGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormTumMemurlar";
            this.Text = "FormTumMemurlar";
            this.Load += new System.EventHandler(this.FormTumMemurlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kULLANICIBindingSource)).EndInit();
            this.memurBilgisiGroupBox.ResumeLayout(false);
            this.memurBilgisiGroupBox.PerformLayout();
            this.memurlarGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox memurlarListBox;
        private System.Windows.Forms.BindingSource kULLANICIBindingSource;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.TextBox cinsiyetTextBox;
        private System.Windows.Forms.DateTimePicker d_TarihiDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox kullanıcı_AdiTextBox;
        private System.Windows.Forms.TextBox kullanıcı_SifresiTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox tCTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.GroupBox memurBilgisiGroupBox;
        private System.Windows.Forms.GroupBox memurlarGroupBox;
        private System.Windows.Forms.Button güncelleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.ComboBox personelTuruComboBox;
    }
}