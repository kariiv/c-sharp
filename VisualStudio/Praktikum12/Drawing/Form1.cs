using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        private Graphics graph;
        private Point A,B;
        private Pen pen;
        private bool down = false;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            down = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (down)
                Drawing(sender, e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!A.IsEmpty)
            {
                graph = CreateGraphics();
                B = new Point(e.X, e.Y);
                graph.DrawLine(pen, A, B);
                A = B;
            }
            else
                A = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            down = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = rnd.Next(0, 4);
            if (i == 0)
                pen = new Pen(Color.Red, 3);
            else if(i ==1)
                pen = new Pen(Color.Green, 3);
            else if (i == 2)
                pen = new Pen(Color.Yellow, 3);
            else if (i == 3)
                pen = new Pen(Color.Blue, 3);
        }
        private void Drawing(object sender, MouseEventArgs e)
        {
            if (!A.IsEmpty)
            {
                graph = CreateGraphics();
                B = new Point(e.X, e.Y);
                graph.DrawLine(pen, A, B);
                A = B;
            }
            else
                A = new Point(e.X, e.Y);
        }

    }
}
