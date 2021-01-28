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
    public partial class Form1 : Form
    {
        public bool changelog = true; //changelog first
        public string writepath = @"/history.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Margus Kruus 'käh' counter ", "KÄH");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Warning!\nAre You sure?", "Closing?", MessageBoxButtons.YesNo);
            if(Result == DialogResult.Yes)
                Result = MessageBox.Show("Warning!\nAre You really, really sure\nU wanna leave?", "Closing?", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addkah();
        }
        private void Addkah()
        {
            textBox1.Text = Convert.ToString(Int16.Parse(textBox1.Text) + 1);
            if (textBox1.Text == "100")
                MessageBox.Show("Congrats!\nU reached to 100 'käh'!\nCant believe it...", "OMG");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void multiplayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 MultiP = new Form2();
            this.Visible = false;
            MultiP.ShowDialog();
            this.Close();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            if(changelog)
            MessageBox.Show("Last update:\n- Multiplayer included!", "ChangeLog");
            changelog = false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
