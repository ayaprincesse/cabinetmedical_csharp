namespace APPMEDECIN
{
    partial class medecin
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
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_salaire = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_picker = new System.Windows.Forms.DateTimePicker();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.bnt_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.btnpremier = new System.Windows.Forms.Button();
            this.btnprecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NUMRPPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_initialiser = new System.Windows.Forms.Button();
            this.cb_specialite = new System.Windows.Forms.ComboBox();
            this.maskedtb_tel = new System.Windows.Forms.MaskedTextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(120, 32);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 20);
            this.tb_nom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(120, 58);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(100, 20);
            this.tb_prenom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRENOM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SPECIALITE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DATE NAISSANCE";
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(120, 135);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(100, 20);
            this.tb_ville.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "VILLE";
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(120, 161);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(100, 20);
            this.tb_adresse.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ADRESSE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "TEL";
            // 
            // tb_salaire
            // 
            this.tb_salaire.Location = new System.Drawing.Point(120, 219);
            this.tb_salaire.Name = "tb_salaire";
            this.tb_salaire.Size = new System.Drawing.Size(100, 20);
            this.tb_salaire.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "SALAIRE";
            // 
            // dt_picker
            // 
            this.dt_picker.Location = new System.Drawing.Point(120, 109);
            this.dt_picker.Name = "dt_picker";
            this.dt_picker.Size = new System.Drawing.Size(200, 20);
            this.dt_picker.TabIndex = 18;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(341, 34);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 19;
            this.btn_ajouter.Text = "AJOUTER";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // bnt_modifier
            // 
            this.bnt_modifier.Location = new System.Drawing.Point(341, 82);
            this.bnt_modifier.Name = "bnt_modifier";
            this.bnt_modifier.Size = new System.Drawing.Size(75, 23);
            this.bnt_modifier.TabIndex = 20;
            this.bnt_modifier.Text = "MODIFIER";
            this.bnt_modifier.UseVisualStyleBackColor = true;
            this.bnt_modifier.Click += new System.EventHandler(this.bnt_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(341, 134);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(82, 23);
            this.btn_supprimer.TabIndex = 21;
            this.btn_supprimer.Text = "SUPPRIMER";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_afficher
            // 
            this.btn_afficher.Location = new System.Drawing.Point(474, 17);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(91, 23);
            this.btn_afficher.TabIndex = 22;
            this.btn_afficher.Text = "Afficher";
            this.btn_afficher.UseVisualStyleBackColor = true;
            this.btn_afficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // btnpremier
            // 
            this.btnpremier.Location = new System.Drawing.Point(6, 269);
            this.btnpremier.Name = "btnpremier";
            this.btnpremier.Size = new System.Drawing.Size(75, 23);
            this.btnpremier.TabIndex = 23;
            this.btnpremier.Text = "<<";
            this.btnpremier.UseVisualStyleBackColor = true;
            this.btnpremier.Click += new System.EventHandler(this.btnpremier_Click);
            // 
            // btnprecedent
            // 
            this.btnprecedent.Location = new System.Drawing.Point(120, 269);
            this.btnprecedent.Name = "btnprecedent";
            this.btnprecedent.Size = new System.Drawing.Size(75, 23);
            this.btnprecedent.TabIndex = 24;
            this.btnprecedent.Text = "<";
            this.btnprecedent.UseVisualStyleBackColor = true;
            this.btnprecedent.Click += new System.EventHandler(this.btnprecedent_Click_1);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(243, 268);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 23);
            this.btnSuivant.TabIndex = 25;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click_1);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(360, 268);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(75, 23);
            this.btnDernier.TabIndex = 26;
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMRPPS,
            this.nom,
            this.prenom,
            this.specialite,
            this.salaire});
            this.dataGridView2.Location = new System.Drawing.Point(474, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(332, 191);
            this.dataGridView2.TabIndex = 27;
            // 
            // NUMRPPS
            // 
            this.NUMRPPS.HeaderText = "NUM RPPS";
            this.NUMRPPS.Name = "NUMRPPS";
            // 
            // nom
            // 
            this.nom.HeaderText = "NOM";
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "PRENOM";
            this.prenom.Name = "prenom";
            // 
            // specialite
            // 
            this.specialite.HeaderText = "SPECIALITE";
            this.specialite.Name = "specialite";
            // 
            // salaire
            // 
            this.salaire.HeaderText = "SALAIRE";
            this.salaire.Name = "salaire";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 324);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 237);
            this.dataGridView1.TabIndex = 28;
            // 
            // btn_initialiser
            // 
            this.btn_initialiser.Location = new System.Drawing.Point(341, 186);
            this.btn_initialiser.Name = "btn_initialiser";
            this.btn_initialiser.Size = new System.Drawing.Size(82, 23);
            this.btn_initialiser.TabIndex = 29;
            this.btn_initialiser.Text = "INITIALISER";
            this.btn_initialiser.UseVisualStyleBackColor = true;
            this.btn_initialiser.Click += new System.EventHandler(this.btn_initialiser_Click);
            // 
            // cb_specialite
            // 
            this.cb_specialite.FormattingEnabled = true;
            this.cb_specialite.Items.AddRange(new object[] {
            "pédiatre",
            "dentiste",
            "cardiologue"});
            this.cb_specialite.Location = new System.Drawing.Point(120, 85);
            this.cb_specialite.Name = "cb_specialite";
            this.cb_specialite.Size = new System.Drawing.Size(121, 21);
            this.cb_specialite.TabIndex = 31;
            // 
            // maskedtb_tel
            // 
            this.maskedtb_tel.Location = new System.Drawing.Point(120, 188);
            this.maskedtb_tel.Mask = "0000-000-000";
            this.maskedtb_tel.Name = "maskedtb_tel";
            this.maskedtb_tel.Size = new System.Drawing.Size(100, 20);
            this.maskedtb_tel.TabIndex = 32;
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(120, 6);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(100, 20);
            this.tb_num.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "NumRpps";
            // 
            // medecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(818, 598);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.maskedtb_tel);
            this.Controls.Add(this.cb_specialite);
            this.Controls.Add(this.btn_initialiser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnprecedent);
            this.Controls.Add(this.btnpremier);
            this.Controls.Add(this.btn_afficher);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.bnt_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.dt_picker);
            this.Controls.Add(this.tb_salaire);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.label2);
            this.Name = "medecin";
            this.Text = "medecin";
            this.Load += new System.EventHandler(this.medecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_salaire;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dt_picker;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button bnt_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.Button btnpremier;
        private System.Windows.Forms.Button btnprecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMRPPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialite;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaire;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_initialiser;
        private System.Windows.Forms.ComboBox cb_specialite;
        private System.Windows.Forms.MaskedTextBox maskedtb_tel;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Label label1;
    }
}