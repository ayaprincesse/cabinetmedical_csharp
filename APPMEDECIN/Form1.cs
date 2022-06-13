using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPMEDECIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mAJMEDCINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medecin f = new medecin();
            f.ShowDialog();
        }

        private void mAJPATIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patient f = new patient();
            f.ShowDialog();
        }

        private void mAJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consulte f = new consulte();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecherchePatient f = new RecherchePatient();
            f.ShowDialog();
        }

        private void medecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercheMedecin f = new RechercheMedecin();
            f.ShowDialog();
        }

        
    }
}
