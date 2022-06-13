using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace APPMEDECIN
{
    public partial class medecin : Form
    {
        public medecin()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;

        private void medecin_Load(object sender, EventArgs e)
        { 
            conn = new SqlConnection(@"Data Source=DESKTOP-K9REE8E\BARBIEEXPRESS;Initial Catalog=TpMedcin;Integrated Security=True  ");

            cmd = new SqlCommand("select * from medecin",conn);
            
            conn.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select numRpps , nomM, prenomM, specialite,salaire from MEDECIN";
            SqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            { dataGridView2.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
                //dataGridView2.Rows.Add(dr[numRpps], dr[nomM], dr[prenomM], dr[specialite], dr[salaire]);

            }

            conn.Close();

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            
            try {
                SqlCommand cmd2= new SqlCommand();
                cmd2.Connection=conn;
                cmd2.CommandText = "insert into medecin (nomm,prenomm,specialite,datenaiss,ville,adresse,tel,salaire) values('" + tb_nom.Text + "','" + tb_prenom.Text + "','" + cb_specialite.SelectedItem.ToString() + "','" + dt_picker.Value.ToShortDateString() + "','" + tb_ville.Text + "','" + tb_adresse.Text + "','" + maskedtb_tel.Text + "'," + tb_salaire.Text + ")";
            
                //cmd.CommandText = "INSERT INTO MEDECIN     (nomM, prenomM, specialite,dateNaiss,ville,adresse,tel,salaire) values ('" + tb_nom.Text + "','" + tb_prenom.Text + "','" + cb_specialite.SelectedItem.ToString() + "','" + dt_picker.Value.ToShortDateString() + "','" + tb_ville.Text + "','" + tb_adresse.Text + "','" + masktb_tel.Text + "'," + tb_salaire.Text + ") ";
                MessageBox.Show(cmd2.CommandText);
            conn.Open();
            int i = cmd2.ExecuteNonQuery();
            MessageBox.Show(i + "  bien ajouté");
            conn.Close();
            medecin_Load(sender, e);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                
            }
            finally { conn.Close(); }
            
        }

        private void btn_initialiser_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = string.Empty;
                if (c is MaskedTextBox)
                    c.Text = string.Empty;
            }

        }

        private void bnt_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand c = new SqlCommand();
                c.Connection = conn;
                c.CommandText = "UPDATE medecin set nomM = '" + tb_nom.Text + "', prenomM= '" + tb_prenom.Text + "',specialite= '" + cb_specialite.SelectedItem.ToString() + "',datenaiss= '" + dt_picker.Value.ToShortDateString() + "',ville= '" + tb_ville.Text + "', adresse='" + tb_adresse.Text + "' where numrpps= " + tb_num.Text;
                MessageBox.Show(c.CommandText);
                conn.Open();
                int i = c.ExecuteNonQuery();
                MessageBox.Show(i + "  element modifié");
                conn.Close();
                medecin_Load(sender, e);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand c = new SqlCommand();
                c.Connection = conn;
                c.CommandText = "Delete medecin where numrpps= " + tb_num.Text;
                MessageBox.Show(c.CommandText);
                conn.Open();
                int i = c.ExecuteNonQuery();
                MessageBox.Show(i + "  element supprimé");
                conn.Close();
                medecin_Load(sender, e);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        
        int p = 0;
        void naviguer(DataGridView dg, int i)
        {
            tb_num.Text = dg.Rows[i].Cells[0].Value.ToString();
            tb_nom.Text = dg.Rows[i].Cells[1].Value.ToString();
            tb_prenom.Text = dg.Rows[i].Cells[2].Value.ToString();
            cb_specialite.SelectedItem = dg.Rows[i].Cells[3].Value.ToString();
            dt_picker.Value = (DateTime)dg.Rows[i].Cells[4].Value;    
            tb_ville.Text = dg.Rows[i].Cells[5].Value.ToString();
            tb_adresse.Text = dg.Rows[i].Cells[6].Value.ToString();
            maskedtb_tel.Text = dg.Rows[i].Cells[7].Value.ToString();
            tb_salaire.Text = dg.Rows[i].Cells[8].Value.ToString();

            dataGridView1.Rows[p].Selected = true;
        }

        


        private void btnprecedent_Click_1(object sender, EventArgs e)
        {
            if (p > 0)
            {
                p--;
                naviguer(dataGridView1, p);
            }
        }

        private void btnSuivant_Click_1(object sender, EventArgs e)
        {
            if (p < dataGridView1.Rows.Count - 1)
            {
                p++;
                naviguer(dataGridView1, p);
            }
        }

        private void btnDernier_Click_1(object sender, EventArgs e)
        {
            p = dataGridView1.Rows.Count - 2;
            naviguer(dataGridView1, p);
        }

        private void btnpremier_Click(object sender, EventArgs e)
        {
            p = 0;
            naviguer(dataGridView1, p);
        }
    }
}
