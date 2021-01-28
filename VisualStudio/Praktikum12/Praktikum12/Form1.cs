using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Praktikum12
{
    public partial class Form1 : Form
    {
        string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Show();
                label1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void SaveColumns(string path)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                for(var i = 0;i < dataGridView1.ColumnCount;i++)
                {
                    writer.Write(dataGridView1.Columns[i].HeaderText + "  ");
                }
                writer.WriteLine();

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    string lines = "";
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            lines += dataGridView1.Rows[i].Cells[j].Value + " ";
                    }
                    writer.WriteLine(lines);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
                MessageBox.Show("File name cannot be empty", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (label1.Text != null && label1.Text != "")
                    filePath = label1.Text + "\\" + textBox1.Text + ".txt";
                else
                    filePath = textBox1.Text + ".txt"; 
                if (File.Exists(filePath) && MessageBox.Show("File Already exists. \nDo You want to owerwrite?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    SaveColumns(filePath);
                else if (!File.Exists(filePath))
                    SaveColumns(filePath);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                MessageBox.Show("File name cannot be empty", "Alert!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
    }
}
