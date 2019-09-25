using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projet_Gerer_Taxi
{

    public partial class Parametres_Voiture : Form
    {
        //Creation de la connection
        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\MODULES\VB.NET\Projet\ProjetGererTaxi\Projet Gerer Taxi\TAXIG.accdb");
        DataTable dt = new DataTable();
        public Parametres_Voiture()
        {
            InitializeComponent();
        }

        private void Parametres_Voiture_Load(object sender, EventArgs e)
        {
            vcon.Open();
            loadrecord();
        }
        private void loadrecord()
        {
            string sql4 = "Select MatriculeID, expAssurance, modele, nombresieges, specifications from Voiture"; ;
            OleDbDataAdapter da4 = new OleDbDataAdapter(sql4, vcon);
            da4.Fill(dt);
            dataGridView4.DataSource = dt;
        }

        private void closebutt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minibutt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
