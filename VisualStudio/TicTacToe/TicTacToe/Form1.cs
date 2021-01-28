using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; // x-turn
        int turn_count = 0;
        bool winner = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By the student Kauri Riivik", "About");
        }
        private void Lable_Click(object sender, EventArgs e)
        {
            Label K = (Label)sender;
            if (turn)
                K.Text = "X";
            else
                K.Text = "O";

            turn = !turn;
            K.Enabled = false;
            
            Winner_Check();
            turn_count += 1;

            if (winner)
            {
                DisableAllBoxes();
                if (!turn)
                    MessageBox.Show("Congrats!\nWinner is X", "Winner!");

                else if (turn)
                    MessageBox.Show("Congrats!\nWinner is O", "Winner!");
            }
            else if(turn_count == 9)
                MessageBox.Show("Tie!", "Nope!");
        }

        private void Winner_Check()
        {
            if (A1.Text == A2.Text && A2.Text == A3.Text && !A1.Enabled) //Verticals
                winner = true;
            else if (B1.Text == B2.Text && B2.Text == B3.Text && !B1.Enabled)
                winner = true;
            else if (C1.Text == C2.Text && C2.Text == C3.Text && !C1.Enabled)
                winner = true;

            else if (A1.Text == B1.Text && A1.Text == C1.Text && !B1.Enabled) //horizontal
                winner = true;
            else if (B2.Text == A2.Text && A2.Text == C2.Text && !B2.Enabled)
                winner = true;
            else if (B3.Text == C3.Text && C3.Text == A3.Text && !B3.Enabled)
                winner = true;

            else if (A1.Text == B2.Text && A1.Text == C3.Text && !A1.Enabled) //Diagonals
                winner = true;
            else if (A3.Text == B2.Text && B2.Text == C1.Text && !B2.Enabled)
                winner = true;
        }

        private void DisableAllBoxes()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Label b = (Label)c;
                    b.Enabled = false;
                }
                catch { }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn_count = 0;
            winner = false;

            foreach (Control c in Controls)
            {
                c.Enabled = true;
                c.Text = " ";
            }

        }
    }
}
