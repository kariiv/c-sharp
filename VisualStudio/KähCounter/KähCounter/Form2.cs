using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace KähCounter
{
    public partial class Form2 : Form
    {
        public bool start = false;
        public int bar1 = 0;
        public int bar2 = 0;
        public int sec = 0;
        public int min = 0;
        public int starter = 0;
        public string clickSound = @"click.wav";
        public Form2()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Warning!\nAre You sure?", "Closing?", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
                Result = MessageBox.Show("Warning!\nAre You really, really sure\nU wanna leave?", "Closing?", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
                Application.Exit();
        }

        private void singlePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 SingP = new Form1();
            SingP.changelog = false;
            this.Visible = false;
            SingP.ShowDialog();
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if(!start)
            {
                starter = 0;
                timer2.Start();
            }
        }

        public void StartRound()
        {
            start = true;
            label3.Visible = true;
            timer1.Start();
        }
        public void Restart()
        {
            timer1.Stop();
            textBox1.Text = "0";
            textBox2.Text = "0";
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            start = false;
            label3.Visible = false;
            label3.Text = "0 sec";
            sec = 0;
            min = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec += 1;

            if (min == 0)
            {
                label3.Text = sec.ToString() + " sec";
            }

            if (sec == 60)
            {
                min += 1;
                sec = 0;
            }

            if (min > 0 && sec >9)
            {
                label3.Text = min.ToString() + ":" + sec.ToString() + " min";
            }
            if (min > 0 && sec < 10)
            {
                label3.Text = min.ToString() + ":0" + sec.ToString() + " min";
            }
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (start)
            {
                if ((char)e.KeyCode == 'A')
                {
                    textBox1.Text = Convert.ToString(Int16.Parse(textBox1.Text) + 1);
                    progressBar2.PerformStep();
                }
                else if ((char)e.KeyCode == 'L')
                {
                    textBox2.Text = Convert.ToString(Int16.Parse(textBox2.Text) + 1);
                    progressBar1.PerformStep();
                }
                else if ((char)e.KeyCode == 'S')
                {
                    textBox1.Text = Convert.ToString(Int16.Parse(textBox1.Text) + 1);
                    progressBar2.PerformStep();
                }
                else if ((char)e.KeyCode == 'K')
                {
                    textBox2.Text = Convert.ToString(Int16.Parse(textBox2.Text) + 1);
                    progressBar1.PerformStep();
                }

                if (textBox1.Text == "100")
                {
                    timer1.Stop();
                    MessageBox.Show("Player 1 is the Winner!\nTime: " + label3.Text, "Congrats");
                    Restart();
                }
                if (textBox2.Text == "100")
                {
                    timer1.Stop();
                    MessageBox.Show("Player 2 is the Winner!\nTime: " + label3.Text, "Congrats");
                    Restart();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            starter++;
            if (starter == 1)
            {
                label4.Visible = true;
                label4.Text = "3";
                clickSound = @"click.wav";
                playSound(clickSound);
            }
            else if (starter == 2)
            {
                label4.Text = "2";
                playSound(clickSound);
            }
            else if (starter == 3)
            {
                label4.Text = "1";
                playSound(clickSound);
            }
            else if (starter == 4)
            {
                clickSound = @"GunShot.wav";
                playSound(clickSound);
                label4.Text = "Go!";
                StartRound();
            }
            else
            {
                label4.Visible = false;
                timer2.Stop();
            }
            label5.Visible = label4.Visible;
            label5.Text = label4.Text;
        }
        private void playSound(string path)
        {
            System.Media.SoundPlayer player =
                new System.Media.SoundPlayer();
            player.SoundLocation = path;
            Thread.Sleep(900);
            player.Load();
            player.Play();
        }
    }
}
