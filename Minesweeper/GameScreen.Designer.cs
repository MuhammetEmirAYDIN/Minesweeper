using System.Runtime.CompilerServices;

namespace Minesweeper
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.Hamle = new System.Windows.Forms.Label();
            this.GERCEKHAMLE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hamle
            // 
            this.Hamle.AutoSize = true;
            this.Hamle.BackColor = System.Drawing.Color.DarkOrange;
            this.Hamle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hamle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Hamle.Location = new System.Drawing.Point(1302, 28);
            this.Hamle.MinimumSize = new System.Drawing.Size(0, 200);
            this.Hamle.Name = "Hamle";
            this.Hamle.Size = new System.Drawing.Size(175, 200);
            this.Hamle.TabIndex = 0;
            this.Hamle.Text = "HAMLE SAYISI";
            // 
            // GERCEKHAMLE
            // 
            this.GERCEKHAMLE.AutoSize = true;
            this.GERCEKHAMLE.BackColor = System.Drawing.Color.DarkOrange;
            this.GERCEKHAMLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GERCEKHAMLE.ForeColor = System.Drawing.Color.Red;
            this.GERCEKHAMLE.Location = new System.Drawing.Point(1303, 141);
            this.GERCEKHAMLE.MinimumSize = new System.Drawing.Size(174, 87);
            this.GERCEKHAMLE.Name = "GERCEKHAMLE";
            this.GERCEKHAMLE.Size = new System.Drawing.Size(174, 87);
            this.GERCEKHAMLE.TabIndex = 1;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1504, 854);
            this.Controls.Add(this.GERCEKHAMLE);
            this.Controls.Add(this.Hamle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameScreen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hamle;
        private System.Windows.Forms.Label GERCEKHAMLE;
    }
}