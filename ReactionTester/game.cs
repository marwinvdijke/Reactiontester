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
    public partial class game : Form {
        public game()
        {
            InitializeComponent();
        }

        private void game_Load(object sender, EventArgs e) {
            target.Hide();
            scorelabel.Hide();
            bstop.Hide();
            countdownlabel.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            countdown.Start();
            countdownlabel.Show();
            bstart.Hide();
            bstop.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        int timeLeft = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeleftlabel.Text = timeLeft + " Seconds";
            }
            else
            {
                target.Hide();
                gametimer.Enabled = false;
                countdown.Enabled = false;
                endscreen newForm = new endscreen(score);
                newForm.Show();
                this.Hide();

            }
        }
        int score = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score++;
            scorelabel.Text = "Score: " + Convert.ToString(score);
            target.Hide();
        }

        private void scorelabel_Click(object sender, EventArgs e)
        {

        }

        private void bstop_Click(object sender, EventArgs e)
        {
            target.Hide();
            gametimer.Enabled = false;
            endscreen newForm = new endscreen(score);
            newForm.Show();
            this.Hide();
        }
        int timeleft2 = 3;
        private void countdown_Tick_1(object sender, EventArgs e)
        {
            if (timeleft2 > 0)
            {
                timeleft2 = timeleft2 - 1;
                countdownlabel.Text = Convert.ToString(timeleft2);
            }
            else
            {
                target.Show();
                countdownlabel.Hide();
                scorelabel.Show();
                gametimer.Start();
                Random x = new Random();
                Point pt = new Point(
                    int.Parse(x.Next(816).ToString()),
                    int.Parse(x.Next(489).ToString())
                    );
                target.Location = pt;
            }
        }

        private void countdownlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
