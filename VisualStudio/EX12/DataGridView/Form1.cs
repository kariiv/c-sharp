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

namespace DataGridView
{
    public partial class Form1 : Form
    {
        string fileName = "";
        string filePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if textbox text is empty
            if(textBoxFileName.Text== null || textBoxFileName.Text == "")
            {
                //then display alert
                string message = "Filling out file name is mandatory!";
                string caption = "Please fill out file name!";
                //we only add Ok button
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                fileName = textBoxFileName.Text;
                //check if file exists
                string fileFullPath = filePath + @"\" + fileName +".txt";
                if (File.Exists(fileFullPath))
                {
                    //display an error
                    DialogResult result2 = MessageBox.Show("Do you want to overwrite?",
                    "File already exists",
                    MessageBoxButtons.YesNo); //we add yes and no buttons
                    //if user presses yes (if our dialog result equals DialogResult.Yes)
                    if(result2 == DialogResult.Yes)
                    {
                        SaveFile(fileFullPath);
                    }
                    //we do not need "no" event cause we dont do anything with button no click
                }
                else
                {
                    //try saving the file
                    SaveFile(fileFullPath);
                }

            }
        }


        public void SaveFile(string filePath)
        {
            using (StreamWriter sW = new StreamWriter(filePath))
            {
                //writing column headers
                for (var i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    sW.Write(dataGridView1.Columns[i].HeaderText + "  ");
                }
                sW.WriteLine(); //line break

                //writing content
                for (int row = 0; row < dataGridView1.RowCount; row++)
                {
                    string lines = ""; //helper string for writing a line
                    for (int col = 0; col < dataGridView1.ColumnCount; col++)
                    {
                        if (dataGridView1.Rows[row].Cells[col].Value != null)
                        {
                            lines += dataGridView1.Rows[row].Cells[col].Value.ToString() + ", ";
                        }
                    }
                    sW.WriteLine(lines);
                }
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                labelPath.Show();
                labelPath.Text = folderBrowserDialog1.SelectedPath;
                filePath = folderBrowserDialog1.SelectedPath;
            }
            Console.WriteLine(result);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //emptying the data view
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
