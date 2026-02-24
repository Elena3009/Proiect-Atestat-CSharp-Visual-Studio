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
    public partial class Genuri: Form
    {
        public Genuri()
        {
            InitializeComponent();
        }

        private void inapoi_genuri_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Genuri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thriller t = new Thriller();
            t.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fantasy f = new Fantasy();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Romance r = new Romance();
            r.ShowDialog();
        }
    }
}
