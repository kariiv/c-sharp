using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        private Graphics graph;
        private Point A, B;
        private Pen PEN;
        private Random rnd = new Random();
        private int cordY, cordX = 0;
        private bool down = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Wanna leave?", "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) //Restart button 
        {
            cordX = 0;
            cordY = 0;
            A = new Point(0,0);
        }

        private void button1_Click(object sender, EventArgs e) //start and stop button
        {
            if (button1.Text == "Magic")
            {
                timer1.Start();
                button1.Text = "Stop";
            }
            else if (button1.Text == "Stop")
            {
                timer1.Stop();
                button1.Text = "Magic";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graph = CreateGraphics();
            if (down && B.Y < ClientSize.Height)
            {
                cordY += 10;
            }
            else if (!down && B.Y != 0 && B.X != 0)
            {
                cordY -= 10;
            }
            else
            {
                cordX += 4;
                down = !down;
            }
            B = new Point(cordX, cordY);
            PEN = new Pen(Color.FromArgb((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)), 4);
            graph.DrawLine(PEN, A, B);
            A = B;
        }
    }
}
