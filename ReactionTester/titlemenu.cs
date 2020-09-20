using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactionTester
{
    public partial class titlemenu : Form
    {
        game game = new game();
        settings settings = new settings();
        public titlemenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void breaction_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Hide();
        }

        private void bquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settings.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void titlemenu_Load(object sender, EventArgs e)
        {

        }
    }
}
