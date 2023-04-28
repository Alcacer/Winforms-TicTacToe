﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static TicTacToe_with_Winforms.HomeMenu;

namespace TicTacToe_with_Winforms
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }
        
        private void PlayAgainButton_Click(object sender, EventArgs e)
        { 
            Turns.InitialGrid();
            PlayAgainButton.Enabled = false;
        }
        private char closeReason = 'X';
        private void BackButton_Click(object sender, EventArgs e)
        {
            closeReason = 'B';
            Close();
            Program.homeMenu.Show(); //From the Program class.   
            Turns.sessions = Turns.turns = 1;
            Turns.firstPlayerTurn = true;
            Turns.gameOver = false;
        }

        /// <summary>
        /// This function is for all the buttons on the grid and is passed into all the buttons' 
        /// event handlers in the partial class. When a button is pressed, the sender stores the 
        /// button that is pressed and sets the text of the button. The button is disabled after
        /// the button is pressed to avoid changing the first inputed value.
        /// In the same vein, that is the same thing that i want to do to the people of oz.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender != null && sender is Button)
            {
                Button clickedButton = sender as Button;
                clickedButton.Text = Turns.GetTurn().ToString();
                clickedButton.BackColor = Color.White;
                Turns.MainFunction();

                //If the game is over...
                if (Turns.gameOver)
                {
                    foreach(Control control in gameForm.Controls)
                    {
                        if( control is Button && control.Text.Length < 2) 
                        {
                            control.Enabled = false; 
                        }                            
                    }
                    PlayAgainButton.Enabled = true;
                }
                clickedButton.Enabled = false;
                Turns.buttons.Remove(clickedButton);
                if (computerMode && Turns.buttons.Count > 0) 
                {
                    Turns.ComputerClick(Turns.buttons, Turns.random); 
                }
            }
        }
        //Closes the hidden homemenu form if the gameform is closed without the back 
        //button being pressed.
        private void GameFormClose(object sender, FormClosedEventArgs e)
        {
            if (closeReason == 'X')
            {
                Program.homeMenu.Close();
            }
        }
    }
}
