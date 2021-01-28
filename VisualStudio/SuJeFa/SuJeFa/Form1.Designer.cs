namespace SuJeFa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.paper2 = new System.Windows.Forms.PictureBox();
            this.scissors2 = new System.Windows.Forms.PictureBox();
            this.paper1 = new System.Windows.Forms.PictureBox();
            this.rock1 = new System.Windows.Forms.PictureBox();
            this.scissors1 = new System.Windows.Forms.PictureBox();
            this.rock2 = new System.Windows.Forms.PictureBox();
            this.Winner2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Winner1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.press = new System.Windows.Forms.Label();
            this.comp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paper2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Location = new System.Drawing.Point(233, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button1_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 94);
            this.label1.TabIndex = 1;
            this.label1.Text = "SU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // paper2
            // 
            this.paper2.Image = ((System.Drawing.Image)(resources.GetObject("paper2.Image")));
            this.paper2.Location = new System.Drawing.Point(389, 123);
            this.paper2.Name = "paper2";
            this.paper2.Size = new System.Drawing.Size(214, 156);
            this.paper2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paper2.TabIndex = 2;
            this.paper2.TabStop = false;
            this.paper2.Visible = false;
            // 
            // scissors2
            // 
            this.scissors2.Image = ((System.Drawing.Image)(resources.GetObject("scissors2.Image")));
            this.scissors2.Location = new System.Drawing.Point(436, 89);
            this.scissors2.Name = "scissors2";
            this.scissors2.Size = new System.Drawing.Size(114, 220);
            this.scissors2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scissors2.TabIndex = 3;
            this.scissors2.TabStop = false;
            this.scissors2.Visible = false;
            // 
            // paper1
            // 
            this.paper1.Image = ((System.Drawing.Image)(resources.GetObject("paper1.Image")));
            this.paper1.Location = new System.Drawing.Point(12, 123);
            this.paper1.Name = "paper1";
            this.paper1.Size = new System.Drawing.Size(214, 156);
            this.paper1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paper1.TabIndex = 5;
            this.paper1.TabStop = false;
            this.paper1.Visible = false;
            // 
            // rock1
            // 
            this.rock1.Image = ((System.Drawing.Image)(resources.GetObject("rock1.Image")));
            this.rock1.Location = new System.Drawing.Point(35, 122);
            this.rock1.Name = "rock1";
            this.rock1.Size = new System.Drawing.Size(177, 157);
            this.rock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock1.TabIndex = 6;
            this.rock1.TabStop = false;
            this.rock1.Visible = false;
            // 
            // scissors1
            // 
            this.scissors1.Image = ((System.Drawing.Image)(resources.GetObject("scissors1.Image")));
            this.scissors1.Location = new System.Drawing.Point(59, 89);
            this.scissors1.Name = "scissors1";
            this.scissors1.Size = new System.Drawing.Size(114, 220);
            this.scissors1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scissors1.TabIndex = 7;
            this.scissors1.TabStop = false;
            this.scissors1.Visible = false;
            // 
            // rock2
            // 
            this.rock2.Image = ((System.Drawing.Image)(resources.GetObject("rock2.Image")));
            this.rock2.Location = new System.Drawing.Point(403, 123);
            this.rock2.Name = "rock2";
            this.rock2.Size = new System.Drawing.Size(177, 157);
            this.rock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock2.TabIndex = 8;
            this.rock2.TabStop = false;
            this.rock2.Visible = false;
            // 
            // Winner2
            // 
            this.Winner2.AutoSize = true;
            this.Winner2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner2.Location = new System.Drawing.Point(430, 55);
            this.Winner2.Name = "Winner2";
            this.Winner2.Size = new System.Drawing.Size(123, 31);
            this.Winner2.TabIndex = 9;
            this.Winner2.Text = "Winner!";
            this.Winner2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Winner2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.exitToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetScoreToolStripMenuItem,
            this.computerToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // resetScoreToolStripMenuItem
            // 
            this.resetScoreToolStripMenuItem.Name = "resetScoreToolStripMenuItem";
            this.resetScoreToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.resetScoreToolStripMenuItem.Text = "Reset Score";
            this.resetScoreToolStripMenuItem.Click += new System.EventHandler(this.resetScoreToolStripMenuItem_Click);
            // 
            // computerToolStripMenuItem
            // 
            this.computerToolStripMenuItem.CheckOnClick = true;
            this.computerToolStripMenuItem.Name = "computerToolStripMenuItem";
            this.computerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.computerToolStripMenuItem.Text = "Computer";
            this.computerToolStripMenuItem.CheckedChanged += new System.EventHandler(this.computerToolStripMenuItem_CheckedChanged);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Winner1
            // 
            this.Winner1.AutoSize = true;
            this.Winner1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Winner1.Location = new System.Drawing.Point(50, 54);
            this.Winner1.Name = "Winner1";
            this.Winner1.Size = new System.Drawing.Size(123, 31);
            this.Winner1.TabIndex = 11;
            this.Winner1.Text = "Winner!";
            this.Winner1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Winner1.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 90);
            this.label2.TabIndex = 12;
            this.label2.Text = "J = Rock\r\nK = Paper\r\nL = Scissors ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 90);
            this.label3.TabIndex = 13;
            this.label3.Text = "A = Rock\r\nS = Paper\r\nD = Scissors";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.BackColor = System.Drawing.Color.Orange;
            this.score2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(472, 325);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(48, 25);
            this.score2.TabIndex = 14;
            this.score2.Text = "200";
            this.score2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.score1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(100, 325);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(48, 25);
            this.score1.TabIndex = 15;
            this.score1.Text = "200";
            this.score1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // press
            // 
            this.press.AutoSize = true;
            this.press.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.press.Location = new System.Drawing.Point(282, 217);
            this.press.Name = "press";
            this.press.Size = new System.Drawing.Size(55, 16);
            this.press.TabIndex = 16;
            this.press.Text = "Press...";
            this.press.Visible = false;
            // 
            // comp
            // 
            this.comp.AutoSize = true;
            this.comp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comp.Location = new System.Drawing.Point(445, 28);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(95, 22);
            this.comp.TabIndex = 17;
            this.comp.Text = "Computer";
            this.comp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.comp.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 460);
            this.Controls.Add(this.comp);
            this.Controls.Add(this.press);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Winner1);
            this.Controls.Add(this.Winner2);
            this.Controls.Add(this.rock2);
            this.Controls.Add(this.scissors1);
            this.Controls.Add(this.rock1);
            this.Controls.Add(this.paper1);
            this.Controls.Add(this.scissors2);
            this.Controls.Add(this.paper2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.paper2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissors1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox paper2;
        private System.Windows.Forms.PictureBox scissors2;
        private System.Windows.Forms.PictureBox paper1;
        private System.Windows.Forms.PictureBox rock1;
        private System.Windows.Forms.PictureBox scissors1;
        private System.Windows.Forms.PictureBox rock2;
        private System.Windows.Forms.Label Winner2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label Winner1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label press;
        private System.Windows.Forms.ToolStripMenuItem computerToolStripMenuItem;
        private System.Windows.Forms.Label comp;
    }
}

