/* 
   Nom : Sydney Mungly
   Version: 2.0
   Date: 17 AVRIL 2018
   Description: Logiciel qui gere des taxis en utilisant une base de donnee
   PAGE: CHAUFFEUR
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace Projet_Gerer_Taxi
{
    public partial class Chauffeur : UserControl
    {
        //Creation de la connection
        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\MODULES\VB.NET\Projet\ProjetGererTaxi\Projet Gerer Taxi\TAXIG.accdb");
        DataTable dt = new DataTable();

        bool flag;

        public static Chauffeur _instance;
        public static Chauffeur instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Chauffeur();
                }
                return _instance;
            }
        }
        public Chauffeur()
        {
            InitializeComponent();
        }

        private void Chauffeur_Load(object sender, EventArgs e)
        {
            //Connexion a la base de donnee
            try
            {
                vcon.Open();
                DDNChau.Visible = false;
                panel1.Enabled = false;
                DBstate1.Visible = true;
                DDSexe.Visible = false;
            }
            catch
            { 
                DBstate2.Visible = true;
                new Connection().Show();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            // BONTON NEW
            panel1.Enabled = true;
            TBPrenom.Focus();
            DDNChau.Visible = true;
            DDSexe.Visible = true;
            error1.Visible = false;
            error2.Visible = false;
            error3.Visible = false;
            error4.Visible = false;
            error5.Visible = false;
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
            // Validation des text-box
            int parsedValue; // Va convertir l'entree textbox en int
            flag = false;
            if (String.IsNullOrEmpty(TBPrenom.Text) || String.IsNullOrWhiteSpace(TBPrenom.Text) || (!Regex.IsMatch(TBPrenom.Text, "^[a-zA-Z ]")))
            {
                error1.Visible = true;
                flag = true;
            }
            else
            {
                error1.Visible = false;
            }

            if (String.IsNullOrEmpty(TBNom.Text) || String.IsNullOrWhiteSpace(TBNom.Text) || (!Regex.IsMatch(TBNom.Text, "^[a-zA-Z ]")))
            {
                error2.Visible = true;
                flag = true;
            }
            else
            {
                error2.Visible = false;
            }

            if (String.IsNullOrEmpty(TBMail.Text) || String.IsNullOrWhiteSpace(TBMail.Text) || (TBNumPermis.Text.Length > 8))
            {
                error4.Visible = true;
                flag = true;
            }
            else
            {
                error4.Visible = true;
            }

            if (String.IsNullOrEmpty(TBNumPermis.Text) || String.IsNullOrWhiteSpace(TBNumPermis.Text))
            {                     
               error5.Visible = true;
               flag = true;
            }
            else
            {
                error5.Visible = false;
            }

            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (!reg.IsMatch(TBMail.Text))
            {
                error4.Visible = true;
                flag = true;
            }
            else
            {
                error4.Visible = false;
            }

           
            if (!int.TryParse(TBTel.Text, out parsedValue) || (TBTel.Text.Length >= 9) || int.Parse(TBTel.Text) < 0) 
            {
                error3.Visible = true;
                flag = true;
            }
            else
            {
                error3.Visible = false;
            }

        }

        private void inserer()
        {
            OleDbCommand cmd = new OleDbCommand();
            string sqlinserer = "INSERT INTO Chauffeur ( nomChauffeur, prenomChauffeur, mailChauffeur, sexeChauffeur, numPermisChauffeur, numTelephone, dateNaissance ) VALUES ('" + TBNom.Text + "','" + TBPrenom.Text + "','" + TBMail.Text + "','" + DDSexe.selectedValue + "','" + TBNumPermis.Text + "','" + TBTel.Text + "', '" + DDNChau.Value + "' )";

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
            // Reset les TB
            TBPrenom.Text = "";
            TBNom.Text = "";
            TBMail.Text = "";
            TBTel.Text = "";
            TBNumPermis.Text = "";
            DDNChau.Visible = false;
            panel1.Enabled = false;
            DBstate1.Visible = true;
            DDSexe.Visible = false;
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            new Parametres_Chauffeur().Show();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            new Help().Show();
            new Help2().Show();
            new Help3().Show();
            new Help4().Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            TBPrenom.Focus();
            TBPrenom.Text = "";
            TBNom.Text = "";
            TBMail.Text = "";
            TBTel.Text = "";
            TBNumPermis.Text = "";
            DDSexe.selectedIndex = 2;
            DBstate1.Visible = true;
            error1.Visible = false;
            error2.Visible = false;
            error3.Visible = false;
            error4.Visible = false;
            error5.Visible = false;
        }
        private void TBNumPermis_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void TBTel_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
