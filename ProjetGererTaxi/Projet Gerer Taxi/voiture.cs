/* 
   Nom : Sydney Mungly
   Version: 4.0
   Date: 17 AVRIL 2018
   Description: Logiciel qui gere des taxis en utilisant une base de donnee
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projet_Gerer_Taxi
{
    public partial class Info : UserControl
    {
        //Creation de la connection
        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\MODULES\VB.NET\Projet\ProjetGererTaxi\Projet Gerer Taxi\TAXIG.accdb");
        DataTable dt = new DataTable();
        bool flag;

        public static Info _instance;
        public static Info instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Info();
                }
                return _instance;
            }
        }
        public Info()
        {
            InitializeComponent();
        }

        private void INFORES_Load(object sender, EventArgs e)
        {
            //Connexion a la base de donnee
            try
            {
                vcon.Open();
                panel1.Enabled = false;
                DBstate1.Visible = true;
                DDStatut.Visible = false;
                DDExp.Visible = false;
            }
            catch
            {
                DBstate2.Visible = true;
                new Connection().Show();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            TBMatricule.Focus();
            DDExp.Visible = true;
            DDStatut.Visible = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            verification();

            if (flag != false)
            {
                new Erreur().Show();
            }
            else
            {
               inserer();
            }
        }
        private void verification()
        {
            flag = false;
            if (String.IsNullOrEmpty(TBMatricule.Text) || String.IsNullOrWhiteSpace(TBMatricule.Text))
            {
                error1.Visible = true;
                flag = true;
            }
            else
            {
                error1.Visible = false;
            }

            if (String.IsNullOrEmpty(TBModele.Text) || String.IsNullOrWhiteSpace(TBModele.Text))
            {
                error3.Visible = true;
                flag = true;
            }
            else
            {
                error3.Visible = false;
            }

            if (int.Parse(TBNC.Text) < 4)
            {
                error4.Visible = true;
                flag = true;
            }
            else
            {
                error4.Visible = false;
            }

        }
        private void inserer()
        {
            OleDbCommand cmd = new OleDbCommand();
            string sqlinserer = "INSERT INTO Voiture ( MatriculeID, expAssurance, modele, nombresieges, specifications, statut) VALUES ('" + TBMatricule.Text + "','" + DDExp.Value + "','" + TBModele.Text + "','" + int.Parse(TBNC.Text) + "','" + TBSpecs.Text + "','" + DDStatut.selectedValue + "')";

            try
            {
                cmd.Connection = vcon;
                cmd.CommandText = sqlinserer;
                cmd.ExecuteNonQuery();
                new Success().Show();
                resettb();
            }
            catch
            {
                new ErrSauv().Show();
            }
        }
        private void resettb()
        {
            //MET A ZERO LES TB
            TBMatricule.Text = "";
            TBModele.Text = "";
            TBNC.Text = "4";
            TBSpecs.Text = "";
            DDExp.Visible = false;
            DDStatut.Visible = false;
            panel1.Enabled = false;
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            new Help().Show();
            new Help2().Show();
            new Help3().Show();
            new Help4().Show();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            new Parametres_Voiture().Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            TBMatricule.Focus();
            TBMatricule.Text = "";
            TBModele.Text = "";
            TBNC.Text = "4";
            TBSpecs.Text = "";
            DDStatut.selectedIndex = 0;
            error1.Visible = false;
            error3.Visible = false;
            error4.Visible = false;
        }
    }
    }
