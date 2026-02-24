using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Sarah_J_Maas: Form
    {
        public Sarah_J_Maas()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seria_ACOTAR s = new Seria_ACOTAR();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seria_Throne_of_Glass s = new Seria_Throne_of_Glass();
            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seria_Crescent_City s = new Seria_Crescent_City();
            s.ShowDialog();
        }
    }
}
