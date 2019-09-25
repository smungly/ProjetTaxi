/* 
   Nom : Sydney Mungly
   Version: 4.0
   Date: 17 AVRIL 2018
   Description: Logiciel qui gere des taxis en utilisant une base de donnee
   PAGE: RESERVATION
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
using System.Text.RegularExpressions;

namespace Projet_Gerer_Taxi
{
    public partial class Res : UserControl
    {
        //Creation de la connection
        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\MODULES\VB.NET\Projet\ProjetGererTaxi\Projet Gerer Taxi\TAXIG.accdb");
        DataTable dt = new DataTable();

        bool flag;

        public static Res _instance;
        public static Res instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Res();
                }
                return _instance;
            }
        }
        public Res()
        {
            InitializeComponent();
        }

        private void Res_Load(object sender, EventArgs e)
        {
            IDMat.Focus();

            //Connexion a la base de donnee
            try
            {
                vcon.Open();
                DBstate1.Visible = true;
            }
            catch
            {
                DBstate2.Visible = true;
                new Connection().Show();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            validations();
            
            if (flag != false)
            {
                new Erreur().Show();
            }
            else
            {
                new Success().Show();
               // inserer();
            }
        
        }
        private void inserer()
        {
            OleDbCommand cmd = new OleDbCommand();
            string sqlinserer = "INSERT INTO Reservation ( IDClient, IDVoiture, IDChauffeur, Heure, EndroitPick, Destination) VALUES ('" + Convert.ToInt32(IDClient.Text) + "','" + IDMat.Text + "','" + Convert.ToInt32(IDChaffeur.Text) + "','" + HeurePick.Value + "','" + ENDROITPICK.selectedValue + "','" + DESTI.selectedValue + "')";
            try
            {
                cmd.Connection = vcon;
                cmd.CommandText = sqlinserer;
                cmd.ExecuteNonQuery();
                new Success().Show();
            }
            catch
            {
                new ErrSauv().Show();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            new Parametres().Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            IDChaffeur.Focus();
            IDChaffeur.Text = "";
            IDClient.Text = "";
            IDMat.Text = "";
            DESTI.selectedIndex = 0;
            ENDROITPICK.selectedIndex = 0;
            error1.Visible = false;
            error2.Visible = false;
            error3.Visible = false;
            error4.Visible = false;
            error5.Visible = false;
            error6.Visible = false;
        }
        private void btnhelp_Click(object sender, EventArgs e)
        {
            new Help().Show();
            new Help2().Show();
            new Help3().Show();
            new Help4().Show();
        }
        private void validations()
        {
            //Fais les validations
            flag = false;

            if (String.IsNullOrEmpty(IDMat.Text) || String.IsNullOrWhiteSpace(IDMat.Text))
            {
                error1.Visible = true;
                flag = true;
            }
            else
            {
                error1.Visible = false;
            }

            if (String.IsNullOrEmpty(IDChaffeur.Text) || String.IsNullOrWhiteSpace(IDChaffeur.Text) || (Regex.IsMatch(IDChaffeur.Text, "^[a-zA-Z ]")))
            {
                error2.Visible = true;
                flag = true;
            }
            else
            {
                error2.Visible = false;
            }

            if (String.IsNullOrEmpty(IDClient.Text) || String.IsNullOrWhiteSpace(IDClient.Text) || (Regex.IsMatch(IDClient.Text, "^[a-zA-Z ]")))
            {
                error3.Visible = true;
                flag = true;
            }
            else
            {
                error3.Visible = false;
            }

            if (ENDROITPICK.selectedIndex == 0)
            {
                error4.Visible = true;
                flag = true;
            }
            else
            {
                error4.Visible = false;
            }

            if (DESTI.selectedIndex == 0)
            {
                error5.Visible = true;
                flag = true;
            }
            else
            {
                error5.Visible = false;
            }
        }
        private void lblTO_Click(object sender, EventArgs e)
        {

        }
        private void HeurePick_ValueChanged(object sender, EventArgs e)
        {
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
        }
        private void btnnew2_Click(object sender, EventArgs e)
        {

        }
        private void IDChaffeur_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
