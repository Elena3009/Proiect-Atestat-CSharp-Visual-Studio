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
    public partial class Latest_releases: Form
    {
        public Latest_releases()
        {
            InitializeComponent();
        }

        private void inapoi_latest_releases_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fearless_Click(object sender, EventArgs e)
        {
            Fearless___Lauren_Roberts f = new Fearless___Lauren_Roberts();
            f.ShowDialog();
        }

        private void WatchMe_Click(object sender, EventArgs e)
        {
            Watch_Me___Tahereh_Mafi w = new Watch_Me___Tahereh_Mafi();
            w.ShowDialog();
        }

        private void KingOfEnvy_Click(object sender, EventArgs e)
        {
            King_of_Envy___Ana_Huang k = new King_of_Envy___Ana_Huang();
            k.ShowDialog();
        }

        private void ThePerfectDivorce_Click(object sender, EventArgs e)
        {
            The_Perfect_Divorce___Jeneva_Rose t = new The_Perfect_Divorce___Jeneva_Rose();
            t.ShowDialog();
        }

        private void GreatBigBeautifulLife_Click(object sender, EventArgs e)
        {
            Great_Big_Beautiful_Life___Emily_Henry g = new Great_Big_Beautiful_Life___Emily_Henry();
            g.ShowDialog();
        }

        private void BridesmaidByChance_Click(object sender, EventArgs e)
        {
            Bridesmaid_By_Chance___Meghan_Quinn b = new Bridesmaid_By_Chance___Meghan_Quinn();
            b.ShowDialog();
        }
    }
}
