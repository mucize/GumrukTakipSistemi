namespace WindowsProjeDeneme
{
    partial class FormYetkili
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYetkili));
            this.tumMemurlarButton = new System.Windows.Forms.Button();
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
            this.oturumKapatButton.Location = new System.Drawing.Point(461, 392);
            this.oturumKapatButton.TabIndex = 5;
            this.oturumKapatButton.Click += new System.EventHandler(this.oturumKapatButton_Click);
            // 
            // kullanicipictureBox
            // 
            this.kullanicipictureBox.Image = ((System.Drawing.Image)(resources.GetObject("kullanicipictureBox.Image")));
            // 
            // saatUserControl1
            // 
            this.saatUserControl1.Location = new System.Drawing.Point(732, 493);
            this.saatUserControl1.Size = new System.Drawing.Size(110, 60);
            // 
            // tumMemurlarButton
            // 
            this.tumMemurlarButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tumMemurlarButton.Location = new System.Drawing.Point(71, 392);
            this.tumMemurlarButton.Name = "tumMemurlarButton";
            this.tumMemurlarButton.Size = new System.Drawing.Size(336, 85);
            this.tumMemurlarButton.TabIndex = 4;
            this.tumMemurlarButton.Text = "Tüm &Memur";
            this.tumMemurlarButton.UseVisualStyleBackColor = true;
            this.tumMemurlarButton.Click += new System.EventHandler(this.tumMemurlarButton_Click);
            // 
            // FormYetkili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(856, 559);
            this.Controls.Add(this.tumMemurlarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormYetkili";
            this.Text = "FormYetkili";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormYetkili_FormClosing);
            this.Controls.SetChildIndex(this.aracGirisButton, 0);
            this.Controls.SetChildIndex(this.profilButton, 0);
            this.Controls.SetChildIndex(this.tumAraclarButton, 0);
            this.Controls.SetChildIndex(this.aracCikisButton, 0);
            this.Controls.SetChildIndex(this.oturumKapatButton, 0);
            this.Controls.SetChildIndex(this.kullanicipictureBox, 0);
            this.Controls.SetChildIndex(this.saatUserControl1, 0);
            this.Controls.SetChildIndex(this.tumMemurlarButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicipictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tumMemurlarButton;
    }
}