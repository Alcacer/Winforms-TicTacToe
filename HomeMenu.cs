﻿using System;
using System.Windows.Forms;

namespace TicTacToe_with_Winforms
{
    public partial class HomeMenu : Form
    {
        public HomeMenu()
        {
            InitializeComponent();
        }

        internal static GameForm gameForm;
        //This computerMode variable is to check when the Versus Computer mode is selected. Pretty obvious I might say.
        internal static bool computerMode;
        private void VersusComButton_Click(object sender, EventArgs e)
        {
            computerMode = true;
            gameForm = new GameForm();
            gameForm.PlayerIndicatorLabel.Text = "Player One is X!"; ;
            gameForm.Show();
            Hide();
        }

        private void VersusPlayerButton_Click(object sender, EventArgs e)
        {
            computerMode = false;
            gameForm = new GameForm();
            gameForm.SecondPlayerLabel.Text = "Player Two:";
            gameForm.Show();
            Hide();
        }
    }
}
