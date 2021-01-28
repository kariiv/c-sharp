namespace HW12
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.like = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.extension = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.Label();
            this.folder = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.sex,
            this.like});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(465, 278);
            this.dataGridView1.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.HeaderText = "Movie Title";
            this.Title.Name = "Title";
            // 
            // sex
            // 
            this.sex.HeaderText = "Sex";
            this.sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sex.Name = "sex";
            // 
            // like
            // 
            this.like.HeaderText = "Liked it?";
            this.like.Name = "like";
            // 
            // extension
            // 
            this.extension.AutoSize = true;
            this.extension.Location = new System.Drawing.Point(230, 304);
            this.extension.Name = "extension";
            this.extension.Size = new System.Drawing.Size(26, 17);
            this.extension.TabIndex = 12;
            this.extension.Text = ".txt";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(118, 301);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(106, 22);
            this.fileName.TabIndex = 11;
            this.fileName.Text = "movies";
            this.fileName.Leave += new System.EventHandler(this.fileName_Leave);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(156, 341);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(0, 17);
            this.path.TabIndex = 10;
            this.path.Visible = false;
            // 
            // folder
            // 
            this.folder.BackColor = System.Drawing.Color.Silver;
            this.folder.Location = new System.Drawing.Point(12, 334);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(138, 31);
            this.folder.TabIndex = 9;
            this.folder.Text = "Choose folder";
            this.folder.UseVisualStyleBackColor = false;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Silver;
            this.save.Location = new System.Drawing.Point(12, 296);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 32);
            this.save.TabIndex = 8;
            this.save.Text = "Save values";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 377);
            this.Controls.Add(this.extension);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.path);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label extension;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Button folder;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewComboBoxColumn sex;
        private System.Windows.Forms.DataGridViewCheckBoxColumn like;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

