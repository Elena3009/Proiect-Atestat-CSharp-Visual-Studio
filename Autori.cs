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
    public partial class Autori: Form
    {
        public Autori()
        {
            InitializeComponent();
        }

        private void inapoi_autori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rebecca_Yarros r = new Rebecca_Yarros();
            r.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Freida_McFadden f = new Freida_McFadden();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sarah_J_Maas s = new Sarah_J_Maas();
            s.ShowDialog();
        }
    }
}
