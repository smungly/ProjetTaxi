/* 
   Nom : Sydney Mungly
   Version: 2.0
   Date: 17 AVRIL 2018
   Description: Logiciel qui gere des taxis en utilisant une base de donnee
*/
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
    public partial class Parametres : Form
    {
        //Creation de la connection
        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\MODULES\VB.NET\Projet\ProjetGererTaxi\Projet Gerer Taxi\TAXIG.accdb");

        //Pour charger les donnees
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();

        public Parametres()
        {
            InitializeComponent();
        }

        private void closebutt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minibutt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            vcon.Open();
            loadrecord();
            loadrecord2();
            loadrecord3();
            loadrecord4();
        }
        // Les requetes
        private void loadrecord()
        {
             string sql1 = "Select IDReservation, IDClient, IDChauffeur, EndroitPick, Destination, Statut from Reservation";
            OleDbDataAdapter da = new OleDbDataAdapter(sql1, vcon);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void loadrecord2()
        {
            string sql2 = "Select IDChauffeur, nomChauffeur, prenomChauffeur, mailChauffeur, sexeChauffeur, numTelephone, statut  from Chauffeur";
            OleDbDataAdapter da2 = new OleDbDataAdapter(sql2, vcon);
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        private void loadrecord3()
        {
            string sql3 = "Select IDClient, prenomClient, nomClient, sexeClient, telClient, mailClient from Client";
            OleDbDataAdapter da3 = new OleDbDataAdapter(sql3, vcon);
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
        }
        private void loadrecord4()
        {
            string sql4 = "Select MatriculeID, expAssurance, modele, nombresieges, specifications from Voiture"; ;
            OleDbDataAdapter da4 = new OleDbDataAdapter(sql4, vcon);
            da4.Fill(dt4);
            dataGridView4.DataSource = dt4;
        }
    }
}
