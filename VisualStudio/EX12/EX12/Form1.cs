using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX12
{
    public partial class LineResizingForm : Form
    {

        public LineResizingForm()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            DrawLine();
        }


        Graphics graphics;
        public void DrawLine()
        {
            Point A = new Point(10, 50);
            Point B = new Point(this.ClientSize.Width - 10, 50);
            Pen redPen = new Pen(Color.Red);
            graphics.DrawLine(redPen, A, B);
        }

        private void on_Resize(object sender, EventArgs e)
        {
            graphics = CreateGraphics(); //form size changes so we need to get new graphics object
            graphics.Clear(Color.White); //clear the previous line
            DrawLine(); //draw the line
        }
    }
}
