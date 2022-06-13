namespace APPMEDECIN
{
    partial class RechercheMedecin
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
            this.chk_nom = new System.Windows.Forms.CheckBox();
            this.chk_prenom = new System.Windows.Forms.CheckBox();
            this.chk_ville = new System.Windows.Forms.CheckBox();
            this.chk_sp = new System.Windows.Forms.CheckBox();
            this.chk_salaire = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.cb_ville = new System.Windows.Forms.ComboBox();
            this.cb_sp = new System.Windows.Forms.ComboBox();
            this.txt_salaire = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_nom
            // 
            this.chk_nom.AutoSize = true;
            this.chk_nom.Location = new System.Drawing.Point(35, 26);
            this.chk_nom.Name = "chk_nom";
            this.chk_nom.Size = new System.Drawing.Size(67, 17);
            this.chk_nom.TabIndex = 0;
            this.chk_nom.Text = "Par Nom";
            this.chk_nom.UseVisualStyleBackColor = true;
            this.chk_nom.CheckedChanged += new System.EventHandler(this.chk_nom_CheckedChanged);
            // 
            // chk_prenom
            // 
            this.chk_prenom.AutoSize = true;
            this.chk_prenom.Location = new System.Drawing.Point(35, 65);
            this.chk_prenom.Name = "chk_prenom";
            this.chk_prenom.Size = new System.Drawing.Size(80, 17);
            this.chk_prenom.TabIndex = 1;
            this.chk_prenom.Text = "Par prenom";
            this.chk_prenom.UseVisualStyleBackColor = true;
            this.chk_prenom.CheckedChanged += new System.EventHandler(this.chk_prenom_CheckedChanged);
            // 
            // chk_ville
            // 
            this.chk_ville.AutoSize = true;
            this.chk_ville.Location = new System.Drawing.Point(35, 103);
            this.chk_ville.Name = "chk_ville";
            this.chk_ville.Size = new System.Drawing.Size(64, 17);
            this.chk_ville.TabIndex = 2;
            this.chk_ville.Text = "Par Ville";
            this.chk_ville.UseVisualStyleBackColor = true;
            this.chk_ville.CheckedChanged += new System.EventHandler(this.chk_ville_CheckedChanged);
            // 
            // chk_sp
            // 
            this.chk_sp.AutoSize = true;
            this.chk_sp.Location = new System.Drawing.Point(35, 137);
            this.chk_sp.Name = "chk_sp";
            this.chk_sp.Size = new System.Drawing.Size(89, 17);
            this.chk_sp.TabIndex = 3;
            this.chk_sp.Text = "Par specialité";
            this.chk_sp.UseVisualStyleBackColor = true;
            this.chk_sp.CheckedChanged += new System.EventHandler(this.chk_sp_CheckedChanged);
            // 
            // chk_salaire
            // 
            this.chk_salaire.AutoSize = true;
            this.chk_salaire.Location = new System.Drawing.Point(35, 179);
            this.chk_salaire.Name = "chk_salaire";
            this.chk_salaire.Size = new System.Drawing.Size(77, 17);
            this.chk_salaire.TabIndex = 4;
            this.chk_salaire.Text = "Par Salaire";
            this.chk_salaire.UseVisualStyleBackColor = true;
            this.chk_salaire.CheckedChanged += new System.EventHandler(this.chk_salaire_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 177);
            this.dataGridView1.TabIndex = 5;
            // 
            // txt_nom
            // 
            this.txt_nom.Enabled = false;
            this.txt_nom.Location = new System.Drawing.Point(199, 26);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(121, 20);
            this.txt_nom.TabIndex = 6;
            this.txt_nom.TextChanged += new System.EventHandler(this.txt_nom_TextChanged);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Enabled = false;
            this.txt_prenom.Location = new System.Drawing.Point(199, 65);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(121, 20);
            this.txt_prenom.TabIndex = 7;
            this.txt_prenom.TextChanged += new System.EventHandler(this.txt_prenom_TextChanged);
            // 
            // cb_ville
            // 
            this.cb_ville.Enabled = false;
            this.cb_ville.FormattingEnabled = true;
            this.cb_ville.Items.AddRange(new object[] {
            "casablanca",
            "tanger",
            "marrakesh",
            "rabat",
            "casa"});
            this.cb_ville.Location = new System.Drawing.Point(199, 103);
            this.cb_ville.Name = "cb_ville";
            this.cb_ville.Size = new System.Drawing.Size(121, 21);
            this.cb_ville.TabIndex = 8;
            this.cb_ville.SelectedIndexChanged += new System.EventHandler(this.cb_ville_SelectedIndexChanged);
            // 
            // cb_sp
            // 
            this.cb_sp.Enabled = false;
            this.cb_sp.FormattingEnabled = true;
            this.cb_sp.Items.AddRange(new object[] {
            "dentiste",
            "pédiatre",
            "gynécologue",
            "cardiologue"});
            this.cb_sp.Location = new System.Drawing.Point(199, 137);
            this.cb_sp.Name = "cb_sp";
            this.cb_sp.Size = new System.Drawing.Size(121, 21);
            this.cb_sp.TabIndex = 9;
            this.cb_sp.SelectedIndexChanged += new System.EventHandler(this.cb_sp_SelectedIndexChanged);
            // 
            // txt_salaire
            // 
            this.txt_salaire.Enabled = false;
            this.txt_salaire.Location = new System.Drawing.Point(199, 179);
            this.txt_salaire.Name = "txt_salaire";
            this.txt_salaire.Size = new System.Drawing.Size(121, 20);
            this.txt_salaire.TabIndex = 10;
            this.txt_salaire.TextChanged += new System.EventHandler(this.txt_salaire_TextChanged);
            // 
            // RechercheMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_salaire);
            this.Controls.Add(this.cb_sp);
            this.Controls.Add(this.cb_ville);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chk_salaire);
            this.Controls.Add(this.chk_sp);
            this.Controls.Add(this.chk_ville);
            this.Controls.Add(this.chk_prenom);
            this.Controls.Add(this.chk_nom);
            this.Name = "RechercheMedecin";
            this.Text = "RechercheMedecin";
            this.Load += new System.EventHandler(this.RechercheMedecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_nom;
        private System.Windows.Forms.CheckBox chk_prenom;
        private System.Windows.Forms.CheckBox chk_ville;
        private System.Windows.Forms.CheckBox chk_sp;
        private System.Windows.Forms.CheckBox chk_salaire;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.ComboBox cb_ville;
        private System.Windows.Forms.ComboBox cb_sp;
        private System.Windows.Forms.TextBox txt_salaire;
    }
}