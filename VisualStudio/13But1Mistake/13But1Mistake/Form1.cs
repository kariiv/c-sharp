using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13But1Mistake
{
    public partial class Form1 : Form
    {
        internal string boom;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            NewGameSelector();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (CheckButton(B))
            {
                HideAllButtons();
                MessageBox.Show("Sry, man!\nNot today!", "BOOM!");
                NewGameSelector();
            }
            else
            B.Enabled = false;
        }

        private bool CheckButton(Button button)
        {
            bool good = false;
            if (button.Text == boom)
                good = true;

            return good;
        }

        private void NewGameSelector()
        {
            boom = rnd.Next(1, 16).ToString();
            label2.Text = boom;
            EnableAll();
        }

        private void HideAllButtons()
        {
            foreach (Control a in Controls)
            {
                a.Enabled = false;
            }
        }

        private void EnableAll()
        {
            foreach(Control c in Controls)
            {
                c.Enabled = true;
            }
        }
    }
}
