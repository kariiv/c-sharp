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

namespace HW12
{
    public partial class Form1 : Form
    {
        private string filename, filepathMale, filepathFemale;
        public Form1()
        {
            InitializeComponent();
            filename = fileName.Text; //Using for rollback if textbox is empty
        }

        private void folder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path.Show();
                path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Wanna leave?", "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void fileName_Leave(object sender, EventArgs e) //user cannot enter invalid input
        {
            if (fileName.Text == null || fileName.Text == "")
            {
                MessageBox.Show("File name cannot be empty", "Alert!");
                fileName.Text = filename;
            }
            else
                filename = fileName.Text;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (path.Visible == true)
            {
                filepathMale = path.Text + "\\" + fileName.Text + "_male" + extension.Text;
                filepathFemale = path.Text + "\\" + fileName.Text + "_female" + extension.Text;
            }
            else
            {
                filepathMale = fileName.Text + "_male" + extension.Text;
                filepathFemale = fileName.Text + "_female" + extension.Text;
            }
            if (File.Exists(filepathFemale) && MessageBox.Show("File " + fileName.Text + "_female" + extension.Text + " already exists. \nDo You want to owerwrite?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                SaveColumnsFemale(filepathFemale);
            else if (!File.Exists(filepathFemale))
                SaveColumnsFemale(filepathFemale);
            if (File.Exists(filepathMale) && MessageBox.Show("File " + fileName.Text + "_male" + extension.Text + " already exists. \nDo You want to owerwrite?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                SaveColumnsMale(filepathMale);
            else if(!File.Exists(filepathMale))
                SaveColumnsMale(filepathMale);
        }
        private void SaveColumnsFemale(string path) // to write every row by female
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                for (var i = 0; i < dataGridView1.ColumnCount; i+=2)
                {
                    writer.Write(dataGridView1.Columns[i].HeaderText + "  ");
                }
                writer.WriteLine();

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Female")
                        {
                            string lines = "";
                            for (int j = 0; j < dataGridView1.ColumnCount; j += 2)
                            {
                                if (dataGridView1.Rows[i].Cells[j].Value != null)
                                    lines += dataGridView1.Rows[i].Cells[j].Value + "  ";
                            }
                            writer.WriteLine(lines);
                        }
                    }
                    catch { }
                }
            }
        }

        private void SaveColumnsMale(string path) //to write every row by male
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                for (var i = 0; i < dataGridView1.ColumnCount; i+=2)
                {
                    writer.Write(dataGridView1.Columns[i].HeaderText + "  ");
                }
                writer.WriteLine();

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    try
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Male")
                        {
                            string lines = "";
                            for (int j = 0; j < dataGridView1.ColumnCount; j += 2)
                            {
                                if (dataGridView1.Rows[i].Cells[j].Value != null)
                                    lines += dataGridView1.Rows[i].Cells[j].Value + "  ";
                            }
                            writer.WriteLine(lines);
                        }
                    }
                    catch { }
                }
            }
        }


    }
}
