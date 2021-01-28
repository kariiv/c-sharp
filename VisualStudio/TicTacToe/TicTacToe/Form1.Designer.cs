namespace TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.C1 = new System.Windows.Forms.Label();
            this.A3 = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Label();
            this.B2 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Label();
            this.A2 = new System.Windows.Forms.Label();
            this.C2 = new System.Windows.Forms.Label();
            this.B3 = new System.Windows.Forms.Label();
            this.C3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(244, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.BackColor = System.Drawing.Color.Transparent;
            this.C1.Enabled = false;
            this.C1.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.ForeColor = System.Drawing.Color.Red;
            this.C1.Location = new System.Drawing.Point(157, 44);
            this.C1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(70, 75);
            this.C1.TabIndex = 10;
            this.C1.Text = "X";
            this.C1.Click += new System.EventHandler(this.Lable_Click);
            // 
            // A3
            // 
            this.A3.AutoSize = true;
            this.A3.BackColor = System.Drawing.Color.Transparent;
            this.A3.Enabled = false;
            this.A3.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.Color.Blue;
            this.A3.Location = new System.Drawing.Point(20, 197);
            this.A3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(70, 75);
            this.A3.TabIndex = 11;
            this.A3.Text = "X";
            this.A3.Click += new System.EventHandler(this.Lable_Click);
            // 
            // B1
            // 
            this.B1.AutoSize = true;
            this.B1.BackColor = System.Drawing.Color.Transparent;
            this.B1.Enabled = false;
            this.B1.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.Color.Black;
            this.B1.Location = new System.Drawing.Point(88, 44);
            this.B1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(68, 75);
            this.B1.TabIndex = 12;
            this.B1.Text = "O";
            this.B1.Click += new System.EventHandler(this.Lable_Click);
            // 
            // B2
            // 
            this.B2.AutoSize = true;
            this.B2.BackColor = System.Drawing.Color.Transparent;
            this.B2.Enabled = false;
            this.B2.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.Color.Black;
            this.B2.Location = new System.Drawing.Point(88, 120);
            this.B2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(70, 75);
            this.B2.TabIndex = 13;
            this.B2.Text = "X";
            this.B2.Click += new System.EventHandler(this.Lable_Click);
            // 
            // A1
            // 
            this.A1.AutoSize = true;
            this.A1.BackColor = System.Drawing.Color.Transparent;
            this.A1.Enabled = false;
            this.A1.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.Color.LawnGreen;
            this.A1.Location = new System.Drawing.Point(20, 44);
            this.A1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(70, 75);
            this.A1.TabIndex = 14;
            this.A1.Text = "X";
            this.A1.Click += new System.EventHandler(this.Lable_Click);
            // 
            // A2
            // 
            this.A2.AutoSize = true;
            this.A2.BackColor = System.Drawing.Color.Transparent;
            this.A2.Enabled = false;
            this.A2.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.Color.Black;
            this.A2.Location = new System.Drawing.Point(20, 120);
            this.A2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(68, 75);
            this.A2.TabIndex = 15;
            this.A2.Text = "O";
            this.A2.Click += new System.EventHandler(this.Lable_Click);
            // 
            // C2
            // 
            this.C2.AutoSize = true;
            this.C2.BackColor = System.Drawing.Color.Transparent;
            this.C2.Enabled = false;
            this.C2.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.ForeColor = System.Drawing.Color.Black;
            this.C2.Location = new System.Drawing.Point(157, 120);
            this.C2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(68, 75);
            this.C2.TabIndex = 16;
            this.C2.Text = "O";
            this.C2.Click += new System.EventHandler(this.Lable_Click);
            // 
            // B3
            // 
            this.B3.AutoSize = true;
            this.B3.BackColor = System.Drawing.Color.Transparent;
            this.B3.Enabled = false;
            this.B3.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ForeColor = System.Drawing.Color.Black;
            this.B3.Location = new System.Drawing.Point(88, 197);
            this.B3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(68, 75);
            this.B3.TabIndex = 17;
            this.B3.Text = "O";
            this.B3.Click += new System.EventHandler(this.Lable_Click);
            // 
            // C3
            // 
            this.C3.AutoSize = true;
            this.C3.BackColor = System.Drawing.Color.Transparent;
            this.C3.Enabled = false;
            this.C3.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.ForeColor = System.Drawing.Color.Yellow;
            this.C3.Location = new System.Drawing.Point(157, 197);
            this.C3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(70, 75);
            this.C3.TabIndex = 18;
            this.C3.Text = "X";
            this.C3.Click += new System.EventHandler(this.Lable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(244, 291);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label C1;
        private System.Windows.Forms.Label A3;
        private System.Windows.Forms.Label B1;
        private System.Windows.Forms.Label B2;
        private System.Windows.Forms.Label A1;
        private System.Windows.Forms.Label A2;
        private System.Windows.Forms.Label C2;
        private System.Windows.Forms.Label B3;
        private System.Windows.Forms.Label C3;
    }
}

