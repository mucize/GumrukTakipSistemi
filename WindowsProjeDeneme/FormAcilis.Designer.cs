namespace WindowsProjeDeneme
{
    partial class FormAcilis
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.girisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiLinkLabel = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girisToolStripMenuItem,
            this.kayitToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // girisToolStripMenuItem
            // 
            this.girisToolStripMenuItem.Name = "girisToolStripMenuItem";
            this.girisToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.girisToolStripMenuItem.Text = "&GİRİŞ";
            this.girisToolStripMenuItem.Click += new System.EventHandler(this.girisToolStripMenuItem_Click);
            // 
            // kayitToolStripMenuItem
            // 
            this.kayitToolStripMenuItem.Name = "kayitToolStripMenuItem";
            this.kayitToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.kayitToolStripMenuItem.Text = "&KAYIT";
            this.kayitToolStripMenuItem.Click += new System.EventHandler(this.kayitToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.cikisToolStripMenuItem.Text = "&ÇIKIŞ";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // bilgiLinkLabel
            // 
            this.bilgiLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bilgiLinkLabel.AutoSize = true;
            this.bilgiLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiLinkLabel.Location = new System.Drawing.Point(504, 327);
            this.bilgiLinkLabel.Name = "bilgiLinkLabel";
            this.bilgiLinkLabel.Size = new System.Drawing.Size(185, 20);
            this.bilgiLinkLabel.TabIndex = 3;
            this.bilgiLinkLabel.TabStop = true;
            this.bilgiLinkLabel.Text = "Daha Fazla Bilgi İçin";
            this.bilgiLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bilgiLinkLabel_LinkClicked);
            // 
            // FormAcilis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 356);
            this.Controls.Add(this.bilgiLinkLabel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAcilis";
            this.Text = "FormAcilis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAcilis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.LinkLabel bilgiLinkLabel;
    }
}