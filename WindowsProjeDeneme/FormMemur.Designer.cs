namespace WindowsProjeDeneme
{
    partial class FormMemur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemur));
            ((System.ComponentModel.ISupportInitialize)(this.kullanicipictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aracGirisButton
            // 
            this.aracGirisButton.Text = "Araç &Girişi";
            this.aracGirisButton.Click += new System.EventHandler(this.aracGirisButton_Click);
            // 
            // profilButton
            // 
            this.profilButton.TabIndex = 3;
            this.profilButton.Text = "&Profil";
            this.profilButton.Click += new System.EventHandler(this.profilButton_Click);
            // 
            // tumAraclarButton
            // 
            this.tumAraclarButton.Text = "&Tüm Araçlar";
            this.tumAraclarButton.Click += new System.EventHandler(this.tumAraclarButton_Click);
            // 
            // aracCikisButton
            // 
            this.aracCikisButton.TabIndex = 1;
            this.aracCikisButton.Text = "Araç &Çıkışı";
            this.aracCikisButton.Click += new System.EventHandler(this.aracCikisButton_Click);
            // 
            // oturumKapatButton
            // 
            this.oturumKapatButton.Click += new System.EventHandler(this.oturumKapatButton_Click);
            // 
            // kullanicipictureBox
            // 
            this.kullanicipictureBox.Image = ((System.Drawing.Image)(resources.GetObject("kullanicipictureBox.Image")));
            // 
            // saatUserControl1
            // 
            this.saatUserControl1.Location = new System.Drawing.Point(734, 489);
            this.saatUserControl1.Size = new System.Drawing.Size(110, 60);
            // 
            // FormMemur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(856, 559);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMemur";
            this.Text = "FormMemur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMemur_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicipictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}