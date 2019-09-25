using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Gerer_Taxi
{
    public partial class Home : UserControl
    {
        public static Home _instance;
        public static Home instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Home();
                }
                    return _instance;
            }
        }

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            tmrblink.Start();
            tmrblink.Enabled = true;     
        }

        private void tmrblink_Tick(object sender, EventArgs e)
        {
            {
                if (picture2.Visible == true)
                    picture2.Visible = false;
                else
                    picture2.Visible = true;
            }
        }
    }
}
