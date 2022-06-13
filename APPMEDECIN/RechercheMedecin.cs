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
    public partial class RechercheMedecin : Form
    {
        public RechercheMedecin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-K9REE8E\BARBIEEXPRESS;Initial Catalog=TpMedcin;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        DataTable t = new DataTable();

        private void RechercheMedecin_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from medecin", conn);
            
            conn.Open();
            t.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = t;
            conn.Close();

            cmd.CommandText = "select * from medecin where numrpps is not null ";
        }
        SqlParameter nm= new SqlParameter("@nom","");
        SqlParameter pn= new SqlParameter("@prenom", "");
        SqlParameter sp= new SqlParameter("@sp", "");
        SqlParameter vl= new SqlParameter("@ville", "");
        SqlParameter sl= new SqlParameter("@sl", "");


        private void chk_nom_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_nom.Checked)
            { txt_nom.Enabled = true;
                cmd.Parameters.Add(nm);
               
            }
            else {
                txt_nom.Clear();
                txt_nom.Enabled = false; 
                if(cmd.Parameters.Contains(nm))
                    cmd.Parameters.Remove(nm);
                cmd.CommandText = cmd.CommandText.Replace("and nomM=@nom", " ");


            }
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {
            
         
            try
            {  if (chk_nom.Checked)
                {
                    nm.Value = txt_nom.Text ;
                    cmd.CommandText += "and nomM=@nom ";
                    conn.Open();
                    t.Clear();
                    t.Load(cmd.ExecuteReader());
                }
            }
            catch (SqlException ex)
            { MessageBox.Show(ex.Message , "ERREUR NOM"); }
            conn.Close();
        }

        private void chk_prenom_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_prenom.Checked)
            { txt_prenom.Enabled = true;
                cmd.Parameters.Add(pn);
            }
            else
            {
                txt_prenom.Clear();
                txt_prenom.Enabled = false;
                if (cmd.Parameters.Contains(pn))
                    cmd.Parameters.Remove(pn);
                cmd.CommandText = cmd.CommandText.Replace("and prenomM=@prenom", " ");
            }
        }

        private void txt_prenom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_prenom.Checked)
                {
                    pn.Value = txt_prenom.Text;

                    cmd.CommandText += "and prenomM=@prenom ";
                    conn.Open();
                    t.Clear();
                    t.Load(cmd.ExecuteReader());
                }
            }
            catch (SqlException ex)
            { MessageBox.Show(ex.Message, "ERREUR PRENOM"); }
            conn.Close();
        }

        private void chk_ville_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ville.Checked)
            { cb_ville.Enabled = true;
                cmd.Parameters.Add(vl);
            }
            else {
                cb_ville.SelectedItem = null;
                cb_ville.Enabled = false;
                if (cmd.Parameters.Contains(vl))
                    cmd.Parameters.Remove(vl);

                cmd.CommandText = cmd.CommandText.Replace("and ville=@ville", " ");
            }
        }

        private void cb_ville_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_ville.Checked)
                {
                    vl.Value = cb_ville.SelectedItem.ToString();

                    cmd.CommandText += "and ville=@ville ";
                    conn.Open();
                    t.Clear();
                    t.Load(cmd.ExecuteReader());
                }
            }
            catch (SqlException ex)
            { MessageBox.Show(ex.Message, "ERREUR Ville"); }
            conn.Close();
        }

        private void chk_sp_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_sp.Checked)
            {
                cb_sp.Enabled = true;
                cmd.Parameters.Add(sp);
            }
            else
            {
                cb_sp.SelectedItem = null;
                cb_sp.Enabled = false;
                if (cmd.Parameters.Contains(sp))
                    cmd.Parameters.Remove(sp);

                cmd.CommandText = cmd.CommandText.Replace("and specialite=@sp", " ");
            }
        }
        private void cb_sp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_sp.Checked)
                {
                    sp.Value = cb_sp.SelectedItem.ToString();

                    cmd.CommandText += "and specialite=@sp ";
                    conn.Open();
                    t.Clear();
                    t.Load(cmd.ExecuteReader());
                }
            }
            catch (SqlException ex)
            { MessageBox.Show(ex.Message, "ERREUR SPACIALITE"); }
            conn.Close();
        }

        private void chk_salaire_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_salaire.Checked)
            {
                txt_salaire.Enabled = true;
                cmd.Parameters.Add(sl);
            }
            else
            {
                txt_salaire.Clear();
                txt_salaire.Enabled = false;
                if (cmd.Parameters.Contains(sl))
                    cmd.Parameters.Remove(sl);
                cmd.CommandText = cmd.CommandText.Replace("and salaire=@sl", " ");
            }
        }

        private void txt_salaire_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_salaire.Checked)
                {
                    sl.Value = txt_salaire.Text;

                    cmd.CommandText += "and salaire=@sl ";
                    conn.Open();
                    t.Clear();
                    t.Load(cmd.ExecuteReader());
                }
            }
            catch (SqlException ex)
            { MessageBox.Show(ex.Message, "ERREUR SALAIRE"); }
            conn.Close();
        }
    }
}
