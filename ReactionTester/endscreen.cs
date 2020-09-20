using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactionTester
{
    public partial class endscreen : Form
    {
        public endscreen(int intTextbox)
        {
            InitializeComponent();
            decimal fscore = Convert.ToDecimal(intTextbox) / 60;
            endscore.Text = "Score: " + Convert.ToString(intTextbox);
            persecond.Text = String.Format("{0:0.00}", fscore) + " targets per second";
        }

        private void bmainmenu_Click(object sender, EventArgs e)
        {
            titlemenu newForm = new titlemenu();
            newForm.Show();
            this.Hide();
        }
        private void endscreen_Load(object sender, EventArgs e)
        {
        }

        private void highscore_Click(object sender, EventArgs e)
        {

        }

        private void bplayagain_Click(object sender, EventArgs e)
        {
            game newForm = new game();
            newForm.Show();
            this.Hide();
        }
    }
}
