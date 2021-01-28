using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Focus
{
    public partial class Form1 : Form
    {
        int counter;
        int minutes;
        int seconds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Find boxed 00 to 99 in correct order!\nTimer starts after pressing OK","Ready?", MessageBoxButtons.OK);
            CreateGame();
        }

        private void CreateGame()
        {
            List<string> labels = new List<string>();
            counter = 0;
            GameTime.Start();

            for(int i = 0; i < 100; i++)
            {
                if (i.ToString().Length == 2)
                    labels.Add(i.ToString());
                else
                    labels.Add("0" + i.ToString());
            }
            Random rnd = new Random();
            foreach (Control a in Controls)
            {
                int random = rnd.Next(0, labels.Count);
                a.Font = new Font("A Love of Thunder", 12, FontStyle.Bold);
                a.Text = labels[random];
                labels.RemoveAt(random);
            }
        }   
        private void Buttons_Click(object sender, EventArgs e)
        {
            Button K = (Button)sender;
            if (Convert.ToInt16(K.Text) == counter)
            {
                K.Enabled = false;
                counter+=1;
            }
            if (counter >= 100)
                End();
        }
        private void End()
        {
            this.Text = "Congrats!";
            GameTime.Stop();
            if (MessageBox.Show("Time: " + minutes + ":" + seconds + "\nU wanna play again?", "Again?", MessageBoxButtons.YesNo) == DialogResult.No)
                Application.Exit();
            ResetButtons();
            ResetTimer();
            CreateGame();
        }
        private void ResetTimer()
        {
            seconds = 0;
            minutes = 0;
        }
        private void ResetButtons()
        {
            foreach (Control e in Controls)
                e.Enabled = true;
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds == 60)
            {
                seconds = 0;
                minutes++;
            }
            if (counter > 9)
                this.Text = minutes.ToString() + ":" + seconds.ToString() + " | "+ counter.ToString();
            else
                this.Text = minutes.ToString() + ":" + seconds.ToString() + " | " + "0" + counter.ToString();
        }
    }
}
