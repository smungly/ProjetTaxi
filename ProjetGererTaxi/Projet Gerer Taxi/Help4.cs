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
    public partial class Help4 : Form
    {
        public Help4()
        {
            InitializeComponent();
        }

        private void Help4_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(995, 400);
        }

        private void closebutt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
