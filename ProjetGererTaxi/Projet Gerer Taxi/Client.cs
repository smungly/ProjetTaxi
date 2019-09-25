/* 
   Nom : Sydney Mungly
   Version: 4.0
   Date: 17 AVRIL 2018
   Description: Logiciel qui gere des taxis en utilisant une base de donnee
   Page: CLIENT
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
    public partial class Client : UserControl
    {
        //Creation de la connection
        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\MODULES\VB.NET\Projet\ProjetGererTaxi\Projet Gerer Taxi\TAXIG.accdb");
        DataTable dt = new DataTable();

        bool flag;

        // Pour que le main herite du UserControl
        public static Client _instance;
        public static Client instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Client();
                }
                return _instance;
            }
        }
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            //Connexion a la base de donnee
            DDSexeC.Visible = false;

            try
            {
                vcon.Open();
                panel1.Enabled = false;
                DBstate1.Visible = true;
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
            TBPr.Focus();
            DDSexeC.Visible = true;
            error1.Visible = false;
            error2.Visible = false;
            error3.Visible = false;
            error4.Visible = false;
            error5.Visible = false;
            error6.Visible = false;
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
        // Fonction pour verifier
        private void verification()
        {
            // Validation des text-box..
            flag = false;
            if (String.IsNullOrEmpty(TBAd1.Text) || String.IsNullOrWhiteSpace(TBAd1.Text))
            {
                error5.Visible = true;
                flag = true;
            }
            else
            {
                error5.Visible = false;
            }

           if (String.IsNullOrEmpty(TBAd2.Text) || String.IsNullOrWhiteSpace(TBAd2.Text))
            {
                error6.Visible = true;
                flag = true;
            }
            else
            {
                error6.Visible = false;
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

            if (String.IsNullOrEmpty(TBPr.Text) || String.IsNullOrWhiteSpace(TBPr.Text) || (!Regex.IsMatch(TBPr.Text, "^[a-zA-Z ]")))
            {
                error1.Visible = true;
                flag = true;
            }
            else
            {
                error1.Visible = false;
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

            int parsedValue;
            if (!int.TryParse(TBNum.Text, out parsedValue) || (TBNum.Text.Length >= 9) || (int.Parse(TBNum.Text) < 0) || (int.Parse(TBNum.Text) > 59999999))
            {
                error3.Visible = true;
                flag = true;
            }
            else
            {
                error3.Visible = false;
            }
        }

        // Fonction pour inserer
        private void inserer()
        {
            OleDbCommand cmd = new OleDbCommand();
            string sqlinserer = "INSERT INTO Client ( prenomClient, nomClient, sexeClient, telClient, mailClient, addresseL1, adresseL2) VALUES ('" + TBPr.Text + "','" + TBNom.Text + "','" + DDSexeC.selectedValue + "','" + TBNum.Text + "','" + TBMail.Text + "','" + TBAd1.Text + "','" + TBAd2.Text + "' )";

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
            TBAd1.Text = "";
            TBAd2.Text = "";
            TBMail.Text = "";
            TBNom.Text = "";
            TBNum.Text = "";
            TBPr.Text = "";
            DDSexeC.Visible = false;
            panel1.Enabled = false;
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            new Parametres_Client().Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            TBPr.Focus();
            TBAd1.Text = "";
            TBAd2.Text = "";
            TBMail.Text = "";
            TBNom.Text = "";
            TBNum.Text = "";
            TBPr.Text = "";
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

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
