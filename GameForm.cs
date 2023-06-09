﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
        // This closeReason variable is used to check how the program was closed.
        //If B, which is the back button, it closes the gameForm and brings up the homeMenu.
        //If X, which is the default, the user has pressed the X button, or Alt + F4 and so on, and therefore the entire application is closed.
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
        /// 
        /// </summary>
        internal static Random random = new Random();
        internal static List<Button> buttons;

        private void Button_Click(object sender, EventArgs e)
        {
            //At the start of the game, this sets the buttons List to all the buttons on the form.
            //This is important to do before the buttons variable is accessed by any part of the code.
            if (Turns.turns == 1 && Turns.sessions == 1) 
            {
                buttons = new List<Button> { GridOne, GridTwo,GridThree,
                                         GridFour, GridFive, GridSix,
                                         GridSeven, GridEight, GridNine};
            }

            if (sender != null && sender is Button)
            {
                Button clickedButton = sender as Button;
                clickedButton.Text = Turns.GetTurn().ToString();
                clickedButton.BackColor = Color.White;
                
                Turns.MainFunction();
                clickedButton.Enabled = false;
                buttons.Remove(clickedButton);//Removes the clickedButton from the buttons List to avoid the choosing of that same button by the computer.
                
                //If the game is over...
                if (Turns.gameOver)
                {
                    foreach(Button button in buttons)
                    {
                        button.Enabled = false;    //Disables all the remaining unclicked buttons and enables the Play Again Button.                         
                    }
                    PlayAgainButton.Enabled = true;
                }

                //If the game is a draw...
                if (buttons.Count == 0 && !Turns.gameOver)
                {
                    PlayerIndicatorLabel.Text = "This Match is a Draw!";
                    PlayAgainButton.Enabled = true;
                }

                // This is the computer click when in Versus Computer Mode.
                if (computerMode && buttons.Count > 0 && !Turns.gameOver) 
                {
                    //Condition to check if it is actually the Computer's turn to play and if not to skip this part of the code.
                    if ((Turns.sessions % 2 != 0 && Turns.turns % 2 == 0) || 
                        (Turns.sessions % 2 == 0 && Turns.turns % 2 != 0))
                    {
                        System.Threading.Thread.Sleep(700); //Little delay before the click so that the user can actually see the computer play.
                        ComputerLogic.ComputerClick(buttons, random);
                    }
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
