namespace WindowsProjeDeneme
{
    partial class FormGiris
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
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.kULLANICIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kULLANICIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Location = new System.Drawing.Point(160, 100);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(92, 17);
            this.labelKullaniciAdi.TabIndex = 0;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Location = new System.Drawing.Point(160, 144);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(45, 17);
            this.labelSifre.TabIndex = 1;
            this.labelSifre.Text = "Şifre :";
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(287, 100);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(210, 22);
            this.kullaniciAdiTextBox.TabIndex = 2;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(287, 139);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(210, 22);
            this.sifreTextBox.TabIndex = 3;
            this.sifreTextBox.UseSystemPasswordChar = true;
            // 
            // buttonGiris
            // 
            this.buttonGiris.Location = new System.Drawing.Point(287, 197);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(89, 47);
            this.buttonGiris.TabIndex = 5;
            this.buttonGiris.Text = "GİRİŞ";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click);
            // 
            // kULLANICIBindingSource
            // 
            this.kULLANICIBindingSource.DataSource = typeof(WindowsProjeDeneme.KULLANICI);
            // 
            // FormGiris
            // 
            this.AcceptButton = this.buttonGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(682, 355);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGiris_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kULLANICIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.BindingSource kULLANICIBindingSource;
    }
}