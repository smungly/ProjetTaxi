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
    public partial class Help3 : Form
    {
        public Help3()
        {
            InitializeComponent();
        }

        private void Help3_Load(object sender, EventArgs e)
        {
            //Initialise la position de commencement du programme
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(995, 300);
        }

        private void closebutt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
