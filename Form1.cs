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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Latest_releases_Click(object sender, EventArgs e)
        {
            Latest_releases l = new Latest_releases();
            l.ShowDialog();
        }

        private void dupa_gen_Click(object sender, EventArgs e)
        {
            Genuri g = new Genuri();
            g.ShowDialog();
        }

        private void dupa_autor_Click(object sender, EventArgs e)
        {
            Autori a = new Autori();
            a.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
