using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleDrawer
{
    public partial class CircleForm : Form
    {
        public CircleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            Pen redPen = new Pen(Color.Red);
            int height = ClientSize.Height / 2;
            int halfOfRectangle = ClientSize.Height / 4;

            int startPointX = ClientSize.Width/2 - halfOfRectangle;
            int startPointY = ClientSize.Height/2 - halfOfRectangle;

            //position this rectangle in the middle of form!
            //width and height are 1/2 of form height
            //new Rectangle(X, Y, width, height)
            Rectangle rect = new Rectangle(startPointX,startPointY,
                height, height);
            graphics.DrawRectangle(redPen, rect);
            graphics.DrawEllipse(redPen, rect);



           // ClientSize.Width //form width without borders
           // ClientSize.Height //form height without borders

            //graphics.DrawEllipse() - //method for drawing ellipse
        }
    }
}
