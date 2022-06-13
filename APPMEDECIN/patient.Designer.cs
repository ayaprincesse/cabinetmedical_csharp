namespace APPMEDECIN
{
    partial class patient
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
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_numss = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_sexe = new System.Windows.Forms.ComboBox();
            this.cb_numrpps = new System.Windows.Forms.ComboBox();
            this.txt_nummedcin = new System.Windows.Forms.TextBox();
            this.btn_recherche = new System.Windows.Forms.Button();
            this.cb_numrpps2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nummedcin2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpicker
            // 
            this.dtpicker.Location = new System.Drawing.Point(129, 120);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(200, 20);
            this.dtpicker.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "#NUMRPPS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "DATE NAISSANCE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "SEXE";
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(129, 69);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(100, 20);
            this.tb_prenom.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "PRENOM";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(129, 42);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 20);
            this.tb_nom.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "NOM";
            // 
            // tb_numss
            // 
            this.tb_numss.Location = new System.Drawing.Point(129, 16);
            this.tb_numss.Name = "tb_numss";
            this.tb_numss.Size = new System.Drawing.Size(100, 20);
            this.tb_numss.TabIndex = 20;
            this.tb_numss.TextChanged += new System.EventHandler(this.tb_numss_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "NUMSS";
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(291, 210);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(82, 23);
            this.btn_supprimer.TabIndex = 35;
            this.btn_supprimer.Text = "SUPPRIMER";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(154, 210);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 34;
            this.btn_modifier.Text = "MODIFIER";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(28, 210);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 33;
            this.btn_ajouter.Text = "AJOUTER";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(416, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(407, 236);
            this.dataGridView1.TabIndex = 41;
            // 
            // cb_sexe
            // 
            this.cb_sexe.FormattingEnabled = true;
            this.cb_sexe.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cb_sexe.Location = new System.Drawing.Point(129, 95);
            this.cb_sexe.Name = "cb_sexe";
            this.cb_sexe.Size = new System.Drawing.Size(121, 21);
            this.cb_sexe.TabIndex = 42;
            // 
            // cb_numrpps
            // 
            this.cb_numrpps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_numrpps.FormattingEnabled = true;
            this.cb_numrpps.Location = new System.Drawing.Point(129, 146);
            this.cb_numrpps.Name = "cb_numrpps";
            this.cb_numrpps.Size = new System.Drawing.Size(121, 21);
            this.cb_numrpps.TabIndex = 43;
            // 
            // txt_nummedcin
            // 
            this.txt_nummedcin.Location = new System.Drawing.Point(28, 376);
            this.txt_nummedcin.Name = "txt_nummedcin";
            this.txt_nummedcin.Size = new System.Drawing.Size(100, 20);
            this.txt_nummedcin.TabIndex = 44;
            this.txt_nummedcin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_recherche
            // 
            this.btn_recherche.Location = new System.Drawing.Point(144, 427);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(85, 23);
            this.btn_recherche.TabIndex = 45;
            this.btn_recherche.Text = "RECHERCHE";
            this.btn_recherche.UseVisualStyleBackColor = true;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // cb_numrpps2
            // 
            this.cb_numrpps2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_numrpps2.FormattingEnabled = true;
            this.cb_numrpps2.Location = new System.Drawing.Point(28, 489);
            this.cb_numrpps2.Name = "cb_numrpps2";
            this.cb_numrpps2.Size = new System.Drawing.Size(121, 21);
            this.cb_numrpps2.TabIndex = 46;
            this.cb_numrpps2.SelectedIndexChanged += new System.EventHandler(this.cb_numrpps2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Recherche de patient par num de medcin (numrpps)";
            // 
            // txt_nummedcin2
            // 
            this.txt_nummedcin2.Location = new System.Drawing.Point(28, 430);
            this.txt_nummedcin2.Name = "txt_nummedcin2";
            this.txt_nummedcin2.Size = new System.Drawing.Size(100, 20);
            this.txt_nummedcin2.TabIndex = 48;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(416, 337);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(407, 210);
            this.dataGridView2.TabIndex = 49;
            // 
            // patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(843, 582);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txt_nummedcin2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_numrpps2);
            this.Controls.Add(this.btn_recherche);
            this.Controls.Add(this.txt_nummedcin);
            this.Controls.Add(this.cb_numrpps);
            this.Controls.Add(this.cb_sexe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_numss);
            this.Controls.Add(this.label1);
            this.Name = "patient";
            this.Text = "patient";
            this.Load += new System.EventHandler(this.patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_numss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_sexe;
        private System.Windows.Forms.ComboBox cb_numrpps;
        private System.Windows.Forms.TextBox txt_nummedcin;
        private System.Windows.Forms.Button btn_recherche;
        private System.Windows.Forms.ComboBox cb_numrpps2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nummedcin2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}