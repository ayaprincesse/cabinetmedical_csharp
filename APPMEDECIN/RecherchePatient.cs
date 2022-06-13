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
    public partial class RecherchePatient : Form
    {
        public RecherchePatient()
        {
            InitializeComponent();
        }

       

        private void RecherchePatient_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from patient", conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            t.Load(dr);
            dataGridView1.DataSource = t;
            conn.Close();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K9REE8E\BARBIEEXPRESS;Initial Catalog=TpMedcin;Integrated Security=True");
        SqlCommand cmd= new SqlCommand();
        DataTable t = new DataTable();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if ((txt_nom.Text != string.Empty) && (txt_rpps.Text != string.Empty) && (txt_sexe.Text != string.Empty))
            { Executer(); }
           // else { RecherchePatient_Load(); }
        }
        public void Executer()
        {
            cmd.Parameters.Clear();
            t.Clear();
            try
            {

                cmd.Parameters.AddWithValue("@sexe", txt_sexe.Text);
                cmd.Parameters.AddWithValue("@rpps", txt_rpps.Text);
                cmd.Parameters.AddWithValue("@nom", txt_nom.Text);
                cmd.CommandText = "Select * from Patient where sexe=@sexe and numrpps#=@rpps and nomp=@nom";

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                t.Load(dr);
            }
            catch (SqlException ex)
            { MessageBox.Show(ex.Message);  }
            conn.Close();

        }
    }
}
