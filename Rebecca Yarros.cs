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
    public partial class Rebecca_Yarros: Form
    {
        public Rebecca_Yarros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Seria_The_Empyrean s = new Seria_The_Empyrean();
            s.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rebecca_Yarros_Stand_alones r = new Rebecca_Yarros_Stand_alones();
            r.ShowDialog();
        }

       

        

        private void button5_Click(object sender, EventArgs e)
        {
            Seria_The_Renegades s = new Seria_The_Renegades();
            s.ShowDialog();
        }
    }
}
