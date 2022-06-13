namespace APPMEDECIN
{
    partial class consulte
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
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diagnostic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_numss = new System.Windows.Forms.ComboBox();
            this.cb_numrpps = new System.Windows.Forms.ComboBox();
            this.cb_numord = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(469, 141);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(82, 23);
            this.btn_supprimer.TabIndex = 55;
            this.btn_supprimer.Text = "SUPPRIMER";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(469, 81);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 54;
            this.btn_modifier.Text = "MODIFIER";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(469, 26);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 53;
            this.btn_ajouter.Text = "AJOUTER";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // dtpicker
            // 
            this.dtpicker.Location = new System.Drawing.Point(131, 113);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(200, 20);
            this.dtpicker.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "#NumORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "DATE CONSULTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "NUMRPPS#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "NUMSS#";
            // 
            // diagnostic
            // 
            this.diagnostic.Location = new System.Drawing.Point(131, 85);
            this.diagnostic.Name = "diagnostic";
            this.diagnostic.Size = new System.Drawing.Size(121, 20);
            this.diagnostic.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Diagnostic";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 150);
            this.dataGridView1.TabIndex = 63;
            // 
            // cb_numss
            // 
            this.cb_numss.FormattingEnabled = true;
            this.cb_numss.Location = new System.Drawing.Point(131, 26);
            this.cb_numss.Name = "cb_numss";
            this.cb_numss.Size = new System.Drawing.Size(121, 21);
            this.cb_numss.TabIndex = 64;
            // 
            // cb_numrpps
            // 
            this.cb_numrpps.FormattingEnabled = true;
            this.cb_numrpps.Location = new System.Drawing.Point(131, 58);
            this.cb_numrpps.Name = "cb_numrpps";
            this.cb_numrpps.Size = new System.Drawing.Size(121, 21);
            this.cb_numrpps.TabIndex = 65;
            // 
            // cb_numord
            // 
            this.cb_numord.FormattingEnabled = true;
            this.cb_numord.Location = new System.Drawing.Point(131, 142);
            this.cb_numord.Name = "cb_numord";
            this.cb_numord.Size = new System.Drawing.Size(121, 21);
            this.cb_numord.TabIndex = 66;
            // 
            // consulte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.cb_numord);
            this.Controls.Add(this.cb_numrpps);
            this.Controls.Add(this.cb_numss);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.diagnostic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "consulte";
            this.Text = "consulte";
            this.Load += new System.EventHandler(this.consulte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox diagnostic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_numss;
        private System.Windows.Forms.ComboBox cb_numrpps;
        private System.Windows.Forms.ComboBox cb_numord;
    }
}