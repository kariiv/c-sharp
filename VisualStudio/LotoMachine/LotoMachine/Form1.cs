using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotoMachine
{
    public partial class Form1 : Form
    {
        List<int> available;
        List<int> rolled;
        Random rnd = new Random();
        int rollsCount;
        int roll;
        public Form1()
        {
            InitializeComponent();
            CreateAvailableList(30);
            rollsCount = 30;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure?", "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
                else if (MessageBox.Show("Like seriously?", "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (MessageBox.Show("Like seriously?", "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loto by Kauri Riivik\nVersion: 0.8 Beta", "About");
        }

        private void roller_Tick_1(object sender, EventArgs e)
        {
            NextNumber();
            RefreshRolled();
            RefreshAvailable();

            if (rollsCount <= roll)
            {
                button1.Text = "Start";
                roller.Stop();
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                label8.Visible = false;
            }
            else
                roll++;
        }
        //starts Roller 
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Start")
            {
                button1.Text = "Stop";
                if (rollsCount > Int16.Parse(textBox1.Text))
                    MessageBox.Show("NB! Rolls count cannot be greater than total balls!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    rolled = new List<int>();
                    CreateAvailableList(Int16.Parse(textBox1.Text));
                    roll = 1;
                    label8.Visible = true;
                    label2.Visible = true;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    roller.Start();
                }
            }
            else if(button1.Text == "Stop")
            {
                button1.Text = "Start";
                roller.Stop();
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                label8.Visible = false;
            }
        }

        private void NextNumber()
        {
            int nextNumber = available[rnd.Next(available.Count)];
            label8.Text = nextNumber.ToString();
            available.Remove(nextNumber);
            rolled.Add(nextNumber);
        }

        private void CreateAvailableList(int length)
        {
            available = new List<int>();

            for (int i = 1; i <= length; i++)
                available.Add(i);
            RefreshAvailable();
        }

        private void RefreshAvailable()
        {
            label1.Text = null;
            int number = 0;
            foreach (int e in available)
            {
                if (number % 5 == 0)
                    label1.Text += "\n";

                label1.Text += e + ", ";
                number++;
            }
        }
        private void RefreshRolled()
        {
            label2.Text = null;
            int number = 0;
            foreach (int e in rolled)
            {
                if (number % 5 == 0 && number != 0)
                    label2.Text += "\n";

                label2.Text += e + ", ";
                number++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "" || textBox1.Text.Length > 3) { }
            else if (!textBox1.Text.All(char.IsDigit) || Int16.Parse(textBox1.Text) < 1 || Int16.Parse(textBox1.Text) > 30)
                warning1.Visible = true;
            else
            {
                warning1.Visible = false;
                CreateAvailableList(Int16.Parse(textBox1.Text));
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == null || textBox2.Text == "" || textBox2.Text.Length > 3) { }
            else if (!textBox2.Text.All(char.IsDigit) || Int16.Parse(textBox2.Text) < 1 || Int16.Parse(textBox2.Text) > 30)
                warning2.Visible = true;
            else
            {
                warning2.Visible = false;
                rollsCount = Int16.Parse(textBox2.Text);
            }
        }
    }
}
