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
    public partial class consulte : Form
    {
        public consulte()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K9REE8E\BARBIEEXPRESS;Initial Catalog=TpMedcin;Integrated Security=True  ");

        SqlCommand cmd;
        DataTable dt = new DataTable();
        private void consulte_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from consulte", conn);

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
            while (dr2.Read())
            {
                
                cb_numrpps.Items.Add(dr2["numRpps"]);
                
            }
            dr2.Close();
            //

            SqlCommand cmd3 = new SqlCommand("select numss from patient", conn);

            SqlDataReader dr3;
            dr3 = cmd3.ExecuteReader();

            cb_numss.Items.Clear();
            while (dr3.Read())
            {
                cb_numss.Items.Add(dr3["numss"]);

            }
            dr3.Close();
            //

            SqlCommand cmd4 = new SqlCommand("select numOrd from Ordonance", conn);

            SqlDataReader dr4;
            dr4 = cmd4.ExecuteReader();

            cb_numord.Items.Clear();
            while (dr4.Read())
            {
                cb_numord.Items.Add(dr4["numOrd"]);

            }
            dr4.Close();

            conn.Close();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@numrpps",cb_numrpps.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@numss", cb_numss.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@date", dtpicker.Value.ToShortDateString()); 
                cmd.Parameters.AddWithValue("@diagnostic", diagnostic.Text);
                cmd.Parameters.AddWithValue("@numord", cb_numord.SelectedItem.ToString());


                cmd.CommandText = "insert into consulte (numrpps#,numss#,dateConsulte,diagnostic,numOrd#) values(@numrpps,@numss,@date,@diagnostic,@numord)";

                MessageBox.Show(cmd.CommandText);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + "element bien ajouté");
                conn.Close();
                consulte_Load(sender, e);
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
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@numrpps", cb_numrpps.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@numss", cb_numss.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@date", dtpicker.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@diagnostic", diagnostic.Text);
                cmd.Parameters.AddWithValue("@numord", cb_numord.SelectedItem.ToString());


                cmd.CommandText = "UPDATE consulte set diagnostic=@diagnostic , numord#=@numord where numrpps#=@numrpps and numss#=@numss and dateconsulte=@date ";
                MessageBox.Show(cmd.CommandText);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + "  element modifié");
                conn.Close();
                consulte_Load(sender, e);

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
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@numrpps", cb_numrpps.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@numss", cb_numss.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@date", dtpicker.Value.ToShortDateString());
                

                cmd.CommandText = "Delete consulte where numrpps#=@numrpps and numss#=@numss and dateconsulte=@date ";
                MessageBox.Show(cmd.CommandText);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + "  element supprimé");
                conn.Close();
                consulte_Load(sender, e);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}
