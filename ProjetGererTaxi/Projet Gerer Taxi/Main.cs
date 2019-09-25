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

namespace Projet_Gerer_Taxi
{

    public partial class Taxi : Form
    {
        public Taxi()
        {
            InitializeComponent();
        }

        private void closebutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minibutt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void acceuil_Click(object sender, EventArgs e)
        {
            if (!MainPan.Controls.Contains(Home.instance))
            {
                MainPan.Controls.Add(Home.instance);
                Home.instance.Dock = DockStyle.Fill;
                Home.instance.BringToFront();
            }
            else
                Home.instance.BringToFront();
        }

        private void btnchauffeur_Click(object sender, EventArgs e)
        {
            if (!MainPan.Controls.Contains(Chauffeur.instance))
            {
                MainPan.Controls.Add(Chauffeur.instance);
                Chauffeur.instance.Dock = DockStyle.Fill;
                Chauffeur.instance.BringToFront();
            }
            else
                Chauffeur.instance.BringToFront();
        }

        private void btnreserv_Click(object sender, EventArgs e)
        {
            if (!MainPan.Controls.Contains(Client.instance))
            {
                MainPan.Controls.Add(Client.instance);
                Client.instance.Dock = DockStyle.Fill;
                Client.instance.BringToFront();
            }
            else
                Client.instance.BringToFront();
        }

        private void btninfores_Click(object sender, EventArgs e)
        {
            if (!MainPan.Controls.Contains(Res.instance))
            {
                MainPan.Controls.Add(Res.instance);
                Res.instance.Dock = DockStyle.Fill;
                Res.instance.BringToFront();
            }
            else
                Res.instance.BringToFront();
        }
        private void btninfo_Click(object sender, EventArgs e)
        {
            if (!MainPan.Controls.Contains(Info.instance))
            {
                MainPan.Controls.Add(Info.instance);
                Info.instance.Dock = DockStyle.Fill;
                Info.instance.BringToFront();
            }
            else
                Info.instance.BringToFront();
        }
        private void btngetout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
        private void picture2_Click(object sender, EventArgs e)
        {

        }
        private void MainPan_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Taxi_Load(object sender, EventArgs e)
        {
        }
        private void panelgauche_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
