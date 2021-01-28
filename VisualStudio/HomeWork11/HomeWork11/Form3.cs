using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork11
{
    public partial class Form3 : Form
    {
        private int min = 0;
        private int sec = 0;
        private int special = 0;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form3()
        {
            InitializeComponent();
        }

        private void StartStop_Click(object sender, EventArgs e) //Visually one button, but have 2 different function
        {
            if (!label1.Visible)
            {
                if (StartStop.Text == "Start!")
                {
                    timer1.Start();
                    StartStop.Text = "Stop!";
                    clear.Enabled = false;
                    special = 0;
                    textBox1.ReadOnly = true;
                }
                else if (StartStop.Text == "Stop!")
                {
                    timer1.Stop();
                    StartStop.Text = "Start!";
                    clear.Enabled = true;
                    textBox1.ReadOnly = false;
                }
            }
            else
                    MessageBox.Show("Sry, incorrect time value!", "Warning");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00:00";
        }

        //Checks if the entered time is valid
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (CorrectTimer())
                label1.Visible = false;
            else
                label1.Visible = true;
        }

        private bool CorrectTimer()
        {
            if (textBox1.TextLength == 5)
            {
                if (textBox1.Text.Substring(0, 2).All(char.IsDigit) && textBox1.Text.Substring(3, 2).All(char.IsDigit) && textBox1.Text[2] == ':')
                {
                    min = Int16.Parse(textBox1.Text.Substring(0, 2)); //string to int makes handling easier
                    sec = Int16.Parse(textBox1.Text.Substring(3, 2));
                    if(sec < 60)
                        return true;
                }
            }
            else if (textBox1.TextLength > 5)
            {
                textBox1.Text = textBox1.Text.Substring(0, 5);
            }
            return false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string seconds;
            string minutes;
            try
            {
                if (sec > 0 || min > 0)
                    PlaySound(@"Tick.wav");
            }
            catch { }
            if (sec > 0)
                sec -= 1;
            else
            {
                if(min > 0)
                {
                    min -= 1;
                    sec = 59;
                }
            }
            if (sec < 10)
                seconds = "0" + sec.ToString();
            else
                seconds = sec.ToString();
            if (min < 10)
                minutes = "0" + min.ToString();
            else
                minutes = min.ToString();

            textBox1.Text = minutes + ":" + seconds;
            if (sec == 0 && min == 0)
            {
                StartStop_Click(null, null);

                try
                {
                    PlaySound(@"Hit.wav"); //special sound
                }
                catch { }

                timer2.Start();
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (Leave() == false)
                    e.Cancel = true;
                else
                    Application.Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Leave() == true)
                Application.Exit();
        }
        private bool Leave() //when form is about to close
        {
            if (MessageBox.Show("Wanna leave?", "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            return false;
        }
        //Opening Ex1
        private void exercise1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Exercise1 = new Form1();
            this.Visible = false;
            Exercise1.ShowDialog();
            this.Close();
        }
        //Opening Ex2
        private void exercise2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Exercise2 = new Form2();
            this.Visible = false;
            Exercise2.ShowDialog();
            this.Close();
        }

        //Little plinking effect, when timer is 00:00
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (special % 2 == 0)
                textBox1.ForeColor = Color.Red;
            else
                textBox1.ForeColor = Color.Black;
            if (special == 3)
                timer2.Stop();
            special++;
        }
        //method for playing sunds
        private void PlaySound(string path)
        {
            player.SoundLocation = path;
            player.Load();
            player.Play();
        }
    }
}
