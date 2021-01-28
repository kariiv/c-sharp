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
    public partial class Form1 : Form
    {
        private string User = "admin";
        private string CorrectPass = "Asd321"; //can also use data (Sql)

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Leave() == true)
                Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (Leave() == false)
                    e.Cancel = true;
                else
                    Application.Exit();
            }
        }
        
        private bool Leave()
        {
            if (MessageBox.Show("Wanna leave?", "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            return false;
        }

        //just for testing, tester can look the password in the Help menu
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct username is \"" + User + "\"\nCorrect password is \"" + CorrectPass + "\"", "Help", MessageBoxButtons.OK);
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if(username.TextLength > 15) //Just dont like when username is too long
            {
                username.Text = username.Text.Substring(0, 15);
                MessageBox.Show("Maximum username name length is 15","Warning", MessageBoxButtons.OK);
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        //Button click checks if the username and password are correct
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckCorrectUser())
                HideLogin();
            else
                label3.Visible = true; 
        }

        //username and password have to be correct to return true
        private bool CheckCorrectUser()
        {
            if (username.Text == User && CorrectPass == password.Text)
                return true;

            return false;
        }

        //Successful login method
        private void HideLogin()
        {
            button1.Visible = false;
            username.Visible = false;
            password.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
        }
        //opening Ex2
        private void exercise2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Exercise2 = new Form2();
            this.Visible = false;
            Exercise2.ShowDialog();
            this.Close();
        }
        //Opening Ex3
        private void exercise3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Exercise3 = new Form3();
            this.Visible = false;
            Exercise3.ShowDialog();
            this.Close();
        }
    }
}
