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
    public partial class Freida_McFadden: Form
    {
        public Freida_McFadden()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seria_The_Housemaid s = new Seria_The_Housemaid();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Freida_McFadden___Stand_alones f = new Freida_McFadden___Stand_alones();
            f.ShowDialog();
        }
    }
}
