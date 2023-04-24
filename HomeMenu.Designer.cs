namespace TicTacToe_with_Winforms
{
    partial class HomeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMenu));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SelectModeLabel = new System.Windows.Forms.Label();
            this.VersusComButton = new System.Windows.Forms.Button();
            this.VersusPlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(52, 37);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(319, 56);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Tic-Tac-Toe";
            // 
            // SelectModeLabel
            // 
            this.SelectModeLabel.AutoSize = true;
            this.SelectModeLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectModeLabel.Location = new System.Drawing.Point(147, 128);
            this.SelectModeLabel.Name = "SelectModeLabel";
            this.SelectModeLabel.Size = new System.Drawing.Size(124, 33);
            this.SelectModeLabel.TabIndex = 1;
            this.SelectModeLabel.Text = "Select Mode";
            // 
            // VersusComButton
            // 
            this.VersusComButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.VersusComButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VersusComButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersusComButton.ForeColor = System.Drawing.Color.Black;
            this.VersusComButton.Location = new System.Drawing.Point(36, 187);
            this.VersusComButton.Name = "VersusComButton";
            this.VersusComButton.Size = new System.Drawing.Size(138, 41);
            this.VersusComButton.TabIndex = 2;
            this.VersusComButton.Text = "Versus Computer";
            this.VersusComButton.UseVisualStyleBackColor = false;
            // 
            // VersusPlayerButton
            // 
            this.VersusPlayerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.VersusPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VersusPlayerButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersusPlayerButton.ForeColor = System.Drawing.Color.Black;
            this.VersusPlayerButton.Location = new System.Drawing.Point(248, 187);
            this.VersusPlayerButton.Name = "VersusPlayerButton";
            this.VersusPlayerButton.Size = new System.Drawing.Size(138, 41);
            this.VersusPlayerButton.TabIndex = 2;
            this.VersusPlayerButton.Text = "Versus Player";
            this.VersusPlayerButton.UseVisualStyleBackColor = false;
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(422, 287);
            this.Controls.Add(this.VersusPlayerButton);
            this.Controls.Add(this.VersusComButton);
            this.Controls.Add(this.SelectModeLabel);
            this.Controls.Add(this.TitleLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SelectModeLabel;
        private System.Windows.Forms.Button VersusComButton;
        private System.Windows.Forms.Button VersusPlayerButton;
    }
}

