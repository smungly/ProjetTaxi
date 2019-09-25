/* 
   Nom : Sydney Mungly
   Version: 4.0
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

namespace Projet_Gerer_Taxi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //TBLog.Focus();
            tmrblink.Start();
            tmrblink.Enabled = true;
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            error1.Visible = false;
            error2.Visible = false;

            try
            {
                // Pour changer le mot de passe et nom utilisateur
                string username = "sydney";
                string password = "123456";

                if ((this.TBLog.Text == username) && (this.TBPassw.Text == password))
                {
                     this.Hide();
                     new Taxi().Show(); 
                }
                else if ((this.TBLog.Text != username) && (this.TBPassw.Text == password))
                {
                    error1.Visible = true;
                    new usrnico().Show();
                }
                else if ((this.TBLog.Text == username) && (this.TBPassw.Text != password))
                {
                    error2.Visible = true;
                    new mdpinco().Show();
                }
                else
                {
                    error1.Visible = true;
                    error2.Visible = true;
                    new bothico().Show();
                }
            }
            catch
            {
                error1.Visible = true;
                error2.Visible = true;
                new Erreur().Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tmrblink_Tick(object sender, EventArgs e)
        {
            {
                if (PBLog.Visible == true)
                    PBLog.Visible = false;
                else
                    PBLog.Visible = true;
            }
        }

        private void btnmotdepasse_Click(object sender, EventArgs e)
        {
            new AIDE().Show();
        }
    }
}
