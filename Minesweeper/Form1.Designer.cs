namespace Minesweeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMine = new System.Windows.Forms.TextBox();
            this.StartGame = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Developer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(328, 117);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(213, 22);
            this.txtPlayerName.TabIndex = 0;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(127, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTER YOUR NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(240, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 53);
            this.label2.TabIndex = 2;
            this.label2.Text = "MINESWEEPER";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(127, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ENTER GRID NUMBER";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtGrid
            // 
            this.txtGrid.Location = new System.Drawing.Point(328, 172);
            this.txtGrid.Name = "txtGrid";
            this.txtGrid.Size = new System.Drawing.Size(213, 22);
            this.txtGrid.TabIndex = 4;
            this.txtGrid.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(127, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "ENTER MINE COUNT";
            // 
            // txtMine
            // 
            this.txtMine.Location = new System.Drawing.Point(328, 222);
            this.txtMine.Name = "txtMine";
            this.txtMine.Size = new System.Drawing.Size(213, 22);
            this.txtMine.TabIndex = 6;
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.SystemColors.HotTrack;
            this.StartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.StartGame.Location = new System.Drawing.Point(163, 304);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(179, 51);
            this.StartGame.TabIndex = 7;
            this.StartGame.Text = "START";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QuitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.QuitButton.Location = new System.Drawing.Point(394, 304);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(182, 51);
            this.QuitButton.TabIndex = 8;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(283, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "SCOREBOARD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Scoreboard_Click);
            // 
            // Developer
            // 
            this.Developer.BackColor = System.Drawing.Color.Black;
            this.Developer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Developer.ForeColor = System.Drawing.Color.Red;
            this.Developer.Location = new System.Drawing.Point(2, 426);
            this.Developer.Multiline = true;
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(219, 70);
            this.Developer.TabIndex = 10;
            this.Developer.Text = "Muhammet Emir AYDIN\r\n230229041\r\n";
            this.Developer.TextChanged += new System.EventHandler(this.Developer_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Minesweeper.Properties.Resources.bakcground;
            this.ClientSize = new System.Drawing.Size(821, 468);
            this.Controls.Add(this.Developer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.txtMine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMine;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Developer;
    }
}

