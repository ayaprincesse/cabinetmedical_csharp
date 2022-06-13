namespace APPMEDECIN
{
    partial class Form1
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
            this.mAJMEDCINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJPATIENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rECHERCHEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAJMEDCINToolStripMenuItem,
            this.mAJPATIENTToolStripMenuItem,
            this.mAJToolStripMenuItem,
            this.rECHERCHEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(475, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mAJMEDCINToolStripMenuItem
            // 
            this.mAJMEDCINToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine;
            this.mAJMEDCINToolStripMenuItem.Name = "mAJMEDCINToolStripMenuItem";
            this.mAJMEDCINToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.mAJMEDCINToolStripMenuItem.Text = "MAJ MEDCIN";
            this.mAJMEDCINToolStripMenuItem.Click += new System.EventHandler(this.mAJMEDCINToolStripMenuItem_Click);
            // 
            // mAJPATIENTToolStripMenuItem
            // 
            this.mAJPATIENTToolStripMenuItem.BackColor = System.Drawing.Color.Pink;
            this.mAJPATIENTToolStripMenuItem.Name = "mAJPATIENTToolStripMenuItem";
            this.mAJPATIENTToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.mAJPATIENTToolStripMenuItem.Text = "MAJ PATIENT";
            this.mAJPATIENTToolStripMenuItem.Click += new System.EventHandler(this.mAJPATIENTToolStripMenuItem_Click);
            // 
            // mAJToolStripMenuItem
            // 
            this.mAJToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mAJToolStripMenuItem.Name = "mAJToolStripMenuItem";
            this.mAJToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.mAJToolStripMenuItem.Text = "MAJ CONSULTE";
            this.mAJToolStripMenuItem.Click += new System.EventHandler(this.mAJToolStripMenuItem_Click);
            // 
            // rECHERCHEToolStripMenuItem
            // 
            this.rECHERCHEToolStripMenuItem.BackColor = System.Drawing.Color.Violet;
            this.rECHERCHEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.medecinToolStripMenuItem});
            this.rECHERCHEToolStripMenuItem.Name = "rECHERCHEToolStripMenuItem";
            this.rECHERCHEToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.rECHERCHEToolStripMenuItem.Text = "RECHERCHE";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.BackColor = System.Drawing.Color.GreenYellow;
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // medecinToolStripMenuItem
            // 
            this.medecinToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.medecinToolStripMenuItem.Name = "medecinToolStripMenuItem";
            this.medecinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medecinToolStripMenuItem.Text = "Medecin";
            this.medecinToolStripMenuItem.Click += new System.EventHandler(this.medecinToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 189);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GESTION HOPITAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mAJMEDCINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJPATIENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rECHERCHEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medecinToolStripMenuItem;
    }
}

