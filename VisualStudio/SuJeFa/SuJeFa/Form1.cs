using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuJeFa
{
    public partial class Form1 : Form
    {
        internal bool player1; // true = button pressed / false = button not pressed
        internal bool player2; // true = button pressed / false = button not pressed
        internal int timer;  
        internal int playerSet1; // 1=Rock / 2=Paper / 3=Scissors / 0=NoBet;
        internal int playerSet2; // 1=Rock / 2=Paper / 3=Scissors / 0=NoBet;
        internal int i;
        internal bool computer;

        public Form1() 
{
            InitializeComponent();
            score1.Text = "0";
            score2.Text = "0";
            computer = false;
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((char)e.KeyCode == 'A' && !player1)
            {
                playerSet1 = 1;
                player1 = true;
            }
            else if ((char)e.KeyCode == 'S' && !player1)
            {
                playerSet1 = 2;
                player1 = true;
            }
            else if ((char)e.KeyCode == 'D' && !player1)
            {
                playerSet1 = 3;
                player1 = true;
            }
            else if ((char)e.KeyCode == 'J' && !player2)
            {
                playerSet2 = 1;
                player2 = true;
            }
            else if ((char)e.KeyCode == 'K' && !player2)
            {
                playerSet2 = 2;
                player2 = true;
            }
            else if ((char)e.KeyCode == 'L' && !player2)
            {
                playerSet2 = 3;
                player2 = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            timer = 0;
            timer1.Start();
            playerSet1 = 0;
            playerSet2 = 0;
            HideAllPic();
            label1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer == 0)
            {
                timer2.Start();
                label1.Visible = true;
                label1.Text = "SU";
            }
            else if(timer == 1)
            {
                label1.Text = "JE";
            }
            else if(timer == 2)
            {
                label1.Text = "FA";
                player1 = false;
                if(!computer)
                    player2 = false;
                press.Visible = true;
                if (computer)
                    ComputerTurn();
            }
            else if(timer == 3)
            {
                timer2.Stop();
                HideAllPic();


                player1 = true; //No more bet
                player2 = true;
                press.Visible = false;

            }
            else if(timer == 4) //Winner 
            {
                if(playerSet1 == 0 || playerSet2 == 0)
                {
                    if(playerSet1 == 0)
                    {
                        Winner1.Text = "Late!";
                        Winner1.Visible = true;
                    }
                    if(playerSet2 == 0)
                    {
                        Winner2.Text = "Late!";
                        Winner2.Visible = true;
                    }
                }
                else if((playerSet1 == 1 && playerSet2 == 3) || (playerSet1 == 2 && playerSet2 == 1) || (playerSet1 == 3 && playerSet2 == 2))
                {
                    Winner1.Text = "Winner!";
                    Winner1.Visible = true;
                    score1.Text = (Int16.Parse(score1.Text) + 1).ToString();
                }
                else if ((playerSet1 == 1 && playerSet2 == 1) || (playerSet1 == 2 && playerSet2 == 2) || (playerSet1 == 3 && playerSet2 == 3))
                {
                    Winner1.Text = "Draw!";
                    Winner1.Visible = true;
                    Winner2.Text = "Draw!";
                    Winner2.Visible = true;
                }
                else
                {
                    Winner2.Text = "Winner!";
                    Winner2.Visible = true;
                    score2.Text = (Int16.Parse(score2.Text) + 1).ToString();
                }
                timer1.Stop();
                ShowSelected();
            }
            timer++;
        }
        public void ComputerTurn()
        {
            Random rnd = new Random();
            playerSet2 = rnd.Next(1, 4);
        }

        public void ShowSelected()
        {
            if (playerSet1 == 1)
                rock1.Visible = true;
            else if (playerSet1 == 2)
                paper1.Visible = true;
            else if (playerSet1 == 3)
                scissors1.Visible = true;
            if (playerSet2 == 1)
                rock2.Visible = true;
            else if (playerSet2 == 2)
                paper2.Visible = true;
            else if (playerSet2 == 3)
                scissors2.Visible = true;
        }
        public void HideAllPic()
        {
            Winner1.Visible = false;
            Winner2.Visible = false;
            rock1.Visible = false;
            paper1.Visible = false;
            scissors1.Visible = false;
            rock2.Visible = false;
            paper2.Visible = false;
            scissors2.Visible = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game by Kauri Riivik\nVersion: 0.8 Beta","About");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            if(i == 1)
            {
                scissors1.Visible = false;
                scissors2.Visible = false;
                rock1.Visible = true;
                rock2.Visible = true;
            }
            else if(i==2)
            {
                rock1.Visible = false;
                rock2.Visible = false;
                paper1.Visible = true;
                paper2.Visible = true;
            }
            else if(i >= 3)
            {
                paper1.Visible = false;
                paper2.Visible = false;
                scissors1.Visible = true;
                scissors2.Visible = true;
                i = 0;
            }
        }

        private void resetScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score1.Text = "0";
            score2.Text = "0";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure?", "Closing?",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
                else if (MessageBox.Show("Like seriously?", "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            if (MessageBox.Show("Like seriously?", "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void computerToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            computer = !computer;
            comp.Visible = computer;
        }
    }
}
