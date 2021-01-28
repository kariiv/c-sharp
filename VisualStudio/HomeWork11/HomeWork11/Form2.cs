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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            fly.Location = new Point(40, 60);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) //Easter Egg
        {
            MessageBox.Show("Hell Yeah! Nothing!","About");
        }

        private void StartStop_Click(object sender, EventArgs e) //Visually one button, but have 2 different function
        {
            if (StartStop.Text == "Start")
            {
                timer1.Start();
                timer1_Tick(null, null); //Label start moving after start button is pressed.
                StartStop.Text = "Stop";
            }
            else if (StartStop.Text == "Stop")
            {
                timer1.Stop();
                StartStop.Text = "Start";
            }
        }

        //moves label with every tick.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fly.Left < 250 && fly.Top == 60)
                fly.Left += 10;
            else if (fly.Left == 250 && fly.Top < 270)
                fly.Top += 10;
            else if (fly.Left > 40 && fly.Top == 270)
                fly.Left -= 10;
            else if (fly.Left == 40 && fly.Top > 60)
                fly.Top -= 10;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Leave() == true)
                Application.Exit();
        }

        private bool Leave()
        {
            if (MessageBox.Show("Wanna leave?", "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            return false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (Leave() == false)
                    e.Cancel = true;
                else
                    Application.Exit();
            }
        }

        //opening Ex1
        private void exercise1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Exercise1 = new Form1();
            this.Visible = false;
            Exercise1.ShowDialog();
            this.Close();
        }
        //opening Ex3
        private void exercise3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Exercise3 = new Form3();
            this.Visible = false;
            Exercise3.ShowDialog();
            this.Close();
        }
    }
}
