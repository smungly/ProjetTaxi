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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void closebutt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(995, 200);
        }
    }
}
