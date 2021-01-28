using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graph = CreateGraphics();
            Pen redPen = new Pen(Color.Red);

            Rectangle rect = new Rectangle(0, 0, 60, 100);
            graph.DrawRectangle(redPen, rect);
        }
    }
}
