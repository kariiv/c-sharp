using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Praktikum13
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        private int ballWidth = 10;
        private int ballHeight = 10;
        int ballX, ballY, score;
        

        public Form1()
        {
            InitializeComponent();

        }

        Rectangle control;
        int controlHeight;
        int controlY = 0;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics box = e.Graphics;
            Pen ball = new Pen(Color.Gray);
            Brush blackBrush = new SolidBrush(Color.DarkGray);
            Rectangle rectangle = new Rectangle(ballX, ballY, ballWidth, ballHeight);

            box.DrawEllipse(ball, rectangle);
            box.FillEllipse(blackBrush, rectangle);

            control = new Rectangle(0, controlY, 10, controlHeight);
            box.DrawRectangle(ball, control);
            box.FillRectangle(blackBrush, control);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controlHeight = 100;
            controlY = pictureBox1.Height / 2 - controlHeight / 2;
            LoadHIScore();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Wanna leave?", "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        int speedX;
        int speedY;

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (lives.Text == null || lives.Text == "" || !lives.Text.All(Char.IsDigit) || int.Parse(lives.Text) < 0 || int.Parse(lives.Text) > 10)
            {
                MessageBox.Show("Lives can be 1-10", "Alert!");
                lives.Text = rnd.Next(1, 10).ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ballX < 0)
            {
                RemoveLives();
            }
            if (ballX <= 0 || ballX >= pictureBox1.Width - ballWidth)
            {
                speedX = -speedX;
            }
            if (ballY <= 0 || ballY >= pictureBox1.Height - ballHeight)
                speedY = -speedY;

            ballX += speedX;
            ballY += speedY;

            if (control.IntersectsWith(new Rectangle(ballX, ballY, ballWidth, ballHeight)))
            {
                speedX = -speedX;
            }
            if (!label10.Visible)
                AddScore();
            Refresh();// refreshes everything, calls out pictureBox Paint  event
        }

        private void AddScore()
        {
            score += (pictureBox1.Height / controlHeight - 1) * int.Parse(speed.Text)/5 ;
            label7.Text = score.ToString();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Start.Text == "Start!")
            {
                ballX = rnd.Next(0, pictureBox1.Width - ballWidth);
                ballY = rnd.Next(0, pictureBox1.Height - ballHeight);
                timer1.Start();
                Start.Text = "Stop!";
                EDControls();
                LoadSettings();
            }
            else
            {
                timer1.Stop();
                score = 0;
                Start.Text = "Start!";
                EDControls();
                label10.Visible = true;
                NewHighScore();
            }
        }

        private void RemoveLives()
        {
            label4.Text = (int.Parse(label4.Text) - 1).ToString();
            if (label4.Text == "0")
            {
                label10.Visible = true;
                Start_Click(null, null);
            }
        }

        private void Start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if (controlY > 0)
                    controlY -= 5;
            }
            else if (e.KeyCode == Keys.S)
            {
                if (controlY < pictureBox1.Height - controlHeight)
                    controlY += 5;
            }
        }

        private void LoadSettings()
        {
            label4.Text = lives.Text;

            speedX = int.Parse(speed.Text);
            speedY = int.Parse(speed.Text);

            controlHeight = int.Parse(size.Text);
        }

        private void EDControls()
        {
            label10.Visible = false;
            speed.Enabled = !speed.Enabled;
            size.Enabled = !size.Enabled;
            lives.Enabled = !lives.Enabled;
        }

        private void speed_Leave(object sender, EventArgs e)
        {
            if (int.Parse(speed.Text) > 5 || int.Parse(speed.Text) < 1)
            {
                MessageBox.Show("Speed have to be between 1 and 5", "Warning!");
                speed.Text = rnd.Next(1, 5).ToString();
            }
        }

        private void LoadHIScore()
        {
            using (StreamReader reader = new StreamReader("score.txt"))
            {
                string line = reader.ReadLine();
                if(line != null || line != "")
                    label9.Text = line;
            }
        }

        private void NewHighScore()
        {
            if (int.Parse(label7.Text) > int.Parse(label9.Text))
            {
                label9.Text = label7.Text;
                using (StreamWriter writer = new StreamWriter("score.txt", false))
                {
                    writer.WriteLine(label7.Text);
                }
                MessageBox.Show("New Hi-Score!", "Congrats!");
            }
        }
    }
}
