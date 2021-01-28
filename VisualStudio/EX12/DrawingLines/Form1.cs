using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingLines
{
    public partial class LineDrawerForm : Form
    {
        

        public LineDrawerForm()
        {
            InitializeComponent();
        }

        Point currentPoint, previousPoint;
        Graphics graphics;
        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            graphics = CreateGraphics();
            //if it is the first click
            if (previousPoint.IsEmpty && currentPoint.IsEmpty)
            {
                previousPoint = new Point(e.X, e.Y);
            }
            //if it is the second click
            else if (!previousPoint.IsEmpty && currentPoint.IsEmpty)
            {
                currentPoint = new Point(e.X, e.Y);
                DrawLine();
            }//if we have at least 2 points or more
            else
            {
                previousPoint = currentPoint;
                currentPoint = new Point(e.X, e.Y);
                DrawLine();
            }
        }

        public void DrawLine()
        {
            graphics.DrawLine(new Pen(Color.Black), previousPoint,currentPoint);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            graphics = CreateGraphics();
        }
    }
}
