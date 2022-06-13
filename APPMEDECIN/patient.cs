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
    public partial class patient : Form
    {
        public patient()
        {
            InitializeComponent();
        }
        SqlConnection conn= new SqlConnection(@"Data Source=DESKTOP-K9REE8E\BARBIEEXPRESS;Initial Catalog=TpMedcin;Integrated Security=True  ");

        SqlCommand cmd;
        DataTable dt = new DataTable();

        private void patient_Load(object sender, EventArgs e)
        {
          
            cmd = new SqlCommand("select * from patient", conn);

            conn.Open();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            dr.Close();

            //-------

            SqlCommand cmd2 = new SqlCommand("select numRpps from MEDECIN", conn);
            

            SqlDataReader dr2;
            dr2 = cmd2.ExecuteReader();
            cb_numrpps.Items.Clear();
            cb_numrpps2.Items.Clear();
            while (dr2.Read())
            {
                cb_numrpps.Items.Add(dr2["numRpps"]);
                cb_numrpps2.Items.Add(dr2["numRpps"]);
            }

            dr2.Close();

           //
            

            


            conn.Close();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "insert into patient (nomP,prenomP,sexe,dateNaiss,numRPPS#) values('" + tb_nom.Text + "','" + tb_prenom.Text + "','" + cb_sexe.SelectedItem.ToString() + "','" + dtpicker.Value.ToShortDateString() + "'," + cb_numrpps.SelectedItem +  ")";

                MessageBox.Show(cmd2.CommandText);
                conn.Open();
                int i = cmd2.ExecuteNonQuery();
                MessageBox.Show(i + "element bien ajouté");
                conn.Close();
                patient_Load(sender, e);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);

            }
            finally { conn.Close(); }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand c = new SqlCommand();
                c.Connection = conn;
                c.CommandText = "UPDATE patient set nomp = '" + tb_nom.Text + "', prenomp= '" + tb_prenom.Text + "', sexe= '" + cb_sexe.SelectedItem.ToString() + "', datenaiss= '" + dtpicker.Value.ToShortDateString() + "', numrpps#= '" + cb_numrpps.SelectedItem.ToString() +  "' where numss= " + tb_numss.Text ;
                MessageBox.Show(c.CommandText);
                conn.Open();
                int i = c.ExecuteNonQuery();
                MessageBox.Show(i + "  element modifié");
                conn.Close();
                patient_Load(sender, e);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select * from patient where numRPPS# = " + txt_nummedcin.Text, conn);

                conn.Open();

                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                DataTable dt2 = new DataTable();
                dt2.Load(dr);

                dataGridView2.DataSource = dt2;


            }
            catch (SqlException exp1)
            { MessageBox.Show(exp1.Message,"SQL ERROR"); }
            catch (Exception exp2)
            { MessageBox.Show(exp2.Message); }
            
            
            conn.Close();
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {   if (txt_nummedcin2.Text != string.Empty)
            {
                try
                {
                    cmd = new SqlCommand("select * from patient where numRPPS# = " + txt_nummedcin2.Text, conn);

                    conn.Open();

                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();

                    DataTable dt3 = new DataTable();
                    dt3.Load(dr);

                    if (dt3.Rows.Count == 0)
                    { MessageBox.Show("patient n'existe pas"); }
                    else
                    { dataGridView2.DataSource = dt3; }



                }
                catch (SqlException exp1)
                { MessageBox.Show(exp1.Message, "SQL ERROR"); }
                catch (Exception exp2)
                { MessageBox.Show(exp2.Message); }


                conn.Close();

            }
        else
            {
                MessageBox.Show("espace de text vide");
            }

        }

        private void cb_numrpps2_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                cmd = new SqlCommand("select * from patient where numRPPS# = " + cb_numrpps2.SelectedItem , conn);

                conn.Open();

                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                DataTable dt4 = new DataTable();
                dt4.Load(dr);

                if (dt4.Rows.Count == 0)
                { MessageBox.Show("patient n'existe pas"); }
                else
                { dataGridView2.DataSource = dt; }



            }
            catch (SqlException exp1)
            { MessageBox.Show(exp1.Message, "SQL ERROR"); }
            catch (Exception exp2)
            { MessageBox.Show(exp2.Message); }


            conn.Close();

        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {

            try
            {
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@numss", tb_numss.Text);
                

                cmd.CommandText = "Delete patient where numss=@numss ";
                MessageBox.Show(cmd.CommandText);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + "  element supprimé");
                conn.Close();
                patient_Load(sender, e);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void tb_numss_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
