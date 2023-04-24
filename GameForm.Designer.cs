namespace TicTacToe_with_Winforms
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.FirstPlayerLabel = new System.Windows.Forms.Label();
            this.FirstPlayerScore = new System.Windows.Forms.TextBox();
            this.ScoresLabel = new System.Windows.Forms.Label();
            this.SecondPlayerLabel = new System.Windows.Forms.Label();
            this.SecondPlayerScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstPlayerLabel
            // 
            this.FirstPlayerLabel.AutoSize = true;
            this.FirstPlayerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.FirstPlayerLabel.Location = new System.Drawing.Point(27, 71);
            this.FirstPlayerLabel.Name = "FirstPlayerLabel";
            this.FirstPlayerLabel.Size = new System.Drawing.Size(110, 19);
            this.FirstPlayerLabel.TabIndex = 0;
            this.FirstPlayerLabel.Text = "PlayerName:";
            // 
            // FirstPlayerScore
            // 
            this.FirstPlayerScore.BackColor = System.Drawing.Color.White;
            this.FirstPlayerScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstPlayerScore.Enabled = false;
            this.FirstPlayerScore.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlayerScore.ForeColor = System.Drawing.Color.Black;
            this.FirstPlayerScore.Location = new System.Drawing.Point(137, 71);
            this.FirstPlayerScore.Name = "FirstPlayerScore";
            this.FirstPlayerScore.Size = new System.Drawing.Size(51, 26);
            this.FirstPlayerScore.TabIndex = 1;
            // 
            // ScoresLabel
            // 
            this.ScoresLabel.AutoSize = true;
            this.ScoresLabel.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoresLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.ScoresLabel.Location = new System.Drawing.Point(209, 9);
            this.ScoresLabel.Name = "ScoresLabel";
            this.ScoresLabel.Size = new System.Drawing.Size(108, 31);
            this.ScoresLabel.TabIndex = 0;
            this.ScoresLabel.Text = "Scores";
            // 
            // SecondPlayerLabel
            // 
            this.SecondPlayerLabel.AutoSize = true;
            this.SecondPlayerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.SecondPlayerLabel.Location = new System.Drawing.Point(319, 71);
            this.SecondPlayerLabel.Name = "SecondPlayerLabel";
            this.SecondPlayerLabel.Size = new System.Drawing.Size(91, 19);
            this.SecondPlayerLabel.TabIndex = 0;
            this.SecondPlayerLabel.Text = "Computer:";
            // 
            // SecondPlayerScore
            // 
            this.SecondPlayerScore.BackColor = System.Drawing.Color.White;
            this.SecondPlayerScore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SecondPlayerScore.Enabled = false;
            this.SecondPlayerScore.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlayerScore.ForeColor = System.Drawing.Color.Black;
            this.SecondPlayerScore.Location = new System.Drawing.Point(429, 71);
            this.SecondPlayerScore.Name = "SecondPlayerScore";
            this.SecondPlayerScore.Size = new System.Drawing.Size(51, 26);
            this.SecondPlayerScore.TabIndex = 1;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.SecondPlayerScore);
            this.Controls.Add(this.FirstPlayerScore);
            this.Controls.Add(this.ScoresLabel);
            this.Controls.Add(this.SecondPlayerLabel);
            this.Controls.Add(this.FirstPlayerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstPlayerLabel;
        private System.Windows.Forms.TextBox FirstPlayerScore;
        private System.Windows.Forms.Label ScoresLabel;
        private System.Windows.Forms.Label SecondPlayerLabel;
        private System.Windows.Forms.TextBox SecondPlayerScore;
    }
}