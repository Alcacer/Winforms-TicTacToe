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
            this.BackButton = new System.Windows.Forms.Button();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.PlayerIndicatorLabel = new System.Windows.Forms.Label();
            this.GridOne = new System.Windows.Forms.Button();
            this.GridTwo = new System.Windows.Forms.Button();
            this.GridThree = new System.Windows.Forms.Button();
            this.GridFour = new System.Windows.Forms.Button();
            this.GridFive = new System.Windows.Forms.Button();
            this.GridSix = new System.Windows.Forms.Button();
            this.GridSeven = new System.Windows.Forms.Button();
            this.GridEight = new System.Windows.Forms.Button();
            this.GridNine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstPlayerLabel
            // 
            this.FirstPlayerLabel.AutoSize = true;
            this.FirstPlayerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.FirstPlayerLabel.Location = new System.Drawing.Point(49, 56);
            this.FirstPlayerLabel.Name = "FirstPlayerLabel";
            this.FirstPlayerLabel.Size = new System.Drawing.Size(98, 19);
            this.FirstPlayerLabel.TabIndex = 0;
            this.FirstPlayerLabel.Text = "Player One:";
            // 
            // FirstPlayerScore
            // 
            this.FirstPlayerScore.BackColor = System.Drawing.Color.White;
            this.FirstPlayerScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstPlayerScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.FirstPlayerScore.Enabled = false;
            this.FirstPlayerScore.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlayerScore.ForeColor = System.Drawing.Color.IndianRed;
            this.FirstPlayerScore.Location = new System.Drawing.Point(153, 56);
            this.FirstPlayerScore.Name = "FirstPlayerScore";
            this.FirstPlayerScore.Size = new System.Drawing.Size(29, 26);
            this.FirstPlayerScore.TabIndex = 1;
            this.FirstPlayerScore.TabStop = false;
            this.FirstPlayerScore.Text = "0";
            this.FirstPlayerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScoresLabel
            // 
            this.ScoresLabel.AutoSize = true;
            this.ScoresLabel.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoresLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.ScoresLabel.Location = new System.Drawing.Point(170, 9);
            this.ScoresLabel.Name = "ScoresLabel";
            this.ScoresLabel.Size = new System.Drawing.Size(115, 34);
            this.ScoresLabel.TabIndex = 0;
            this.ScoresLabel.Text = "Scores";
            // 
            // SecondPlayerLabel
            // 
            this.SecondPlayerLabel.AutoSize = true;
            this.SecondPlayerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.SecondPlayerLabel.Location = new System.Drawing.Point(242, 56);
            this.SecondPlayerLabel.Name = "SecondPlayerLabel";
            this.SecondPlayerLabel.Size = new System.Drawing.Size(91, 19);
            this.SecondPlayerLabel.TabIndex = 0;
            this.SecondPlayerLabel.Text = "Computer:";
            // 
            // SecondPlayerScore
            // 
            this.SecondPlayerScore.BackColor = System.Drawing.Color.White;
            this.SecondPlayerScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondPlayerScore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SecondPlayerScore.Enabled = false;
            this.SecondPlayerScore.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlayerScore.ForeColor = System.Drawing.Color.IndianRed;
            this.SecondPlayerScore.Location = new System.Drawing.Point(339, 56);
            this.SecondPlayerScore.Name = "SecondPlayerScore";
            this.SecondPlayerScore.Size = new System.Drawing.Size(29, 26);
            this.SecondPlayerScore.TabIndex = 1;
            this.SecondPlayerScore.TabStop = false;
            this.SecondPlayerScore.Text = "0";
            this.SecondPlayerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(100, 420);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(109, 41);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back to Menu";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.PlayAgainButton.Enabled = false;
            this.PlayAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgainButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainButton.ForeColor = System.Drawing.Color.Black;
            this.PlayAgainButton.Location = new System.Drawing.Point(230, 420);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(103, 41);
            this.PlayAgainButton.TabIndex = 2;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // PlayerIndicatorLabel
            // 
            this.PlayerIndicatorLabel.AutoSize = true;
            this.PlayerIndicatorLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerIndicatorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.PlayerIndicatorLabel.Location = new System.Drawing.Point(131, 101);
            this.PlayerIndicatorLabel.Name = "PlayerIndicatorLabel";
            this.PlayerIndicatorLabel.Size = new System.Drawing.Size(180, 19);
            this.PlayerIndicatorLabel.TabIndex = 0;
            this.PlayerIndicatorLabel.Text = "Player One to play..."; 
            
            // 
            // GridOne
            // 
            this.GridOne.BackColor = System.Drawing.Color.Silver;
            this.GridOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridOne.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridOne.ForeColor = System.Drawing.Color.Black;
            this.GridOne.Location = new System.Drawing.Point(78, 135);
            this.GridOne.Name = "GridOne";
            this.GridOne.Size = new System.Drawing.Size(89, 84);
            this.GridOne.TabIndex = 4;
            this.GridOne.TabStop = false;
            this.GridOne.UseVisualStyleBackColor = false;
            this.GridOne.Click += new System.EventHandler(this.Button_Click);
            // 
            // GridTwo
            // 
            this.GridTwo.BackColor = System.Drawing.Color.Silver;
            this.GridTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridTwo.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridTwo.ForeColor = System.Drawing.Color.Black;
            this.GridTwo.Location = new System.Drawing.Point(173, 135);
            this.GridTwo.Name = "GridTwo";
            this.GridTwo.Size = new System.Drawing.Size(89, 84);
            this.GridTwo.TabIndex = 5;
            this.GridTwo.TabStop = false;
            this.GridTwo.UseVisualStyleBackColor = false;
            this.GridTwo.Click += new System.EventHandler(this.Button_Click);
            // 
            // GridThree
            // 
            this.GridThree.BackColor = System.Drawing.Color.Silver;
            this.GridThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridThree.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridThree.ForeColor = System.Drawing.Color.Black;
            this.GridThree.Location = new System.Drawing.Point(268, 135);
            this.GridThree.Name = "GridThree";
            this.GridThree.Size = new System.Drawing.Size(89, 84);
            this.GridThree.TabIndex = 6;
            this.GridThree.TabStop = false;
            this.GridThree.UseVisualStyleBackColor = false;
            this.GridThree.Click += new System.EventHandler(this.Button_Click);
            // 
            // GridFour
            // 
            this.GridFour.BackColor = System.Drawing.Color.Silver;
            this.GridFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridFour.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridFour.ForeColor = System.Drawing.Color.Black;
            this.GridFour.Location = new System.Drawing.Point(78, 225);
            this.GridFour.Name = "GridFour";
            this.GridFour.Size = new System.Drawing.Size(89, 84);
            this.GridFour.TabIndex = 4;
            this.GridFour.TabStop = false;
            this.GridFour.UseVisualStyleBackColor = false;
            this.GridFour.Click += new System.EventHandler(this.Button_Click);
            // 
            // GridFive
            // 
            this.GridFive.BackColor = System.Drawing.Color.Silver;
            this.GridFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridFive.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridFive.ForeColor = System.Drawing.Color.Black;
            this.GridFive.Location = new System.Drawing.Point(173, 225);
            this.GridFive.Name = "GridFive";
            this.GridFive.Size = new System.Drawing.Size(89, 84);
            this.GridFive.TabIndex = 5;
            this.GridFive.TabStop = false;
            this.GridFive.UseVisualStyleBackColor = false;
            this.GridFive.Click += new System.EventHandler(this.Button_Click);
            // 
            // GridSix
            // 
            this.GridSix.BackColor = System.Drawing.Color.Silver;
            this.GridSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridSix.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridSix.ForeColor = System.Drawing.Color.Black;
            this.GridSix.Location = new System.Drawing.Point(268, 225);
            this.GridSix.Name = "GridSix";
            this.GridSix.Size = new System.Drawing.Size(89, 84);
            this.GridSix.TabIndex = 6;
            this.GridSix.TabStop = false;
            this.GridSix.UseVisualStyleBackColor = false;
            this.GridSix.Click += new System.EventHandler(this.Button_Click);
            // 
            // GridSeven
            // 
            this.GridSeven.BackColor = System.Drawing.Color.Silver;
            this.GridSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridSeven.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridSeven.ForeColor = System.Drawing.Color.Black;
            this.GridSeven.Location = new System.Drawing.Point(77, 315);
            this.GridSeven.Name = "GridSeven";
            this.GridSeven.Size = new System.Drawing.Size(90, 84);
            this.GridSeven.TabIndex = 4;
            this.GridSeven.TabStop = false;
            this.GridSeven.UseVisualStyleBackColor = false;
            this.GridSeven.Click += new System.EventHandler(this.Button_Click);
            // 
            // GridEight
            // 
            this.GridEight.BackColor = System.Drawing.Color.Silver;
            this.GridEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridEight.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridEight.ForeColor = System.Drawing.Color.Black;
            this.GridEight.Location = new System.Drawing.Point(173, 315);
            this.GridEight.Name = "GridEight";
            this.GridEight.Size = new System.Drawing.Size(89, 84);
            this.GridEight.TabIndex = 5;
            this.GridEight.TabStop = false;
            this.GridEight.UseVisualStyleBackColor = false;
            this.GridEight.Click += new System.EventHandler(this.Button_Click);
            // 
            // GridNine
            // 
            this.GridNine.BackColor = System.Drawing.Color.Silver;
            this.GridNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GridNine.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridNine.ForeColor = System.Drawing.Color.Black;
            this.GridNine.Location = new System.Drawing.Point(268, 315);
            this.GridNine.Name = "GridNine";
            this.GridNine.Size = new System.Drawing.Size(89, 84);
            this.GridNine.TabIndex = 6;
            this.GridNine.TabStop = false;
            this.GridNine.UseVisualStyleBackColor = false;
            this.GridNine.Click += new System.EventHandler(this.Button_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(438, 494);
            this.Controls.Add(this.GridNine);
            this.Controls.Add(this.GridSix);
            this.Controls.Add(this.GridThree);
            this.Controls.Add(this.GridEight);
            this.Controls.Add(this.GridFive);
            this.Controls.Add(this.GridTwo);
            this.Controls.Add(this.GridSeven);
            this.Controls.Add(this.GridFour);
            this.Controls.Add(this.GridOne);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SecondPlayerScore);
            this.Controls.Add(this.FirstPlayerScore);
            this.Controls.Add(this.ScoresLabel);
            this.Controls.Add(this.SecondPlayerLabel);
            this.Controls.Add(this.PlayerIndicatorLabel);
            this.Controls.Add(this.FirstPlayerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameFormClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label FirstPlayerLabel;
        internal System.Windows.Forms.TextBox FirstPlayerScore;
        private System.Windows.Forms.Label ScoresLabel;
        internal System.Windows.Forms.Label SecondPlayerLabel;
        internal System.Windows.Forms.TextBox SecondPlayerScore;
        private System.Windows.Forms.Button BackButton;
        internal System.Windows.Forms.Button GridOne;
        internal System.Windows.Forms.Button GridTwo;
        internal System.Windows.Forms.Button GridThree;
        internal System.Windows.Forms.Button GridFour;
        internal System.Windows.Forms.Button GridFive;
        internal System.Windows.Forms.Button GridSix;
        internal System.Windows.Forms.Button GridSeven;
        internal System.Windows.Forms.Button GridEight;
        internal System.Windows.Forms.Button GridNine;
        internal System.Windows.Forms.Label PlayerIndicatorLabel;
        internal System.Windows.Forms.Button PlayAgainButton;
    }
}