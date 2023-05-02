using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static TicTacToe_with_Winforms.HomeMenu;

namespace TicTacToe_with_Winforms
{
    internal class Turns
    {
        // The sessions variable is for the amount of sessions or times the duel has been played for, while the turns is the number of turns in a session.
        internal static int sessions = 1;
        internal static int turns = 1;
        internal static bool firstPlayerTurn = true;
        internal static bool gameOver = false;

        internal static char GetTurn()
        {
            //Since X always starts no matter what, then for even turns X is returned, while O is returned for odd turns.
            if (turns % 2 == 0)
            {
                turns++;
                return 'O';
            }
            else
            {
                turns++;
                return 'X';
            }
        }

        //This is for the setting of the PlayerIndicator Label to specify who's going to play next. Only in the versus player mode.
        internal static void SettingLabel(Label label, bool status)
        {
            gameForm.PlayerIndicatorLabel.Text =
                        $"{label.Text.TrimEnd(':')} to play...";
            firstPlayerTurn = status;
        }
        /// <summary>
        /// The Main Function of this class. The playerIndicator label for the computerMode is constant for each session. 
        /// But in the versus Player mode it changes after every turn. Hence the first condition check.
        /// The wins are checked after turns is more than 5, because that is the least amount of turns to get a winner in this case.
        /// Turns is 1, and after every click it is incremented. After 5 clicks, is the minimum amount of turns for a winner to emerge.
        /// </summary>
        internal static void MainFunction()
        {
            if (!computerMode)
            {
                if (firstPlayerTurn)
                {
                    SettingLabel(gameForm.SecondPlayerLabel, false);
                }
                else
                {
                    SettingLabel(gameForm.FirstPlayerLabel, true);
                }
            }

            if (turns > 5)
            {
                //Check Horizontal wins
                CheckWins(gameForm.GridOne, gameForm.GridTwo, gameForm.GridThree);
                CheckWins(gameForm.GridFour, gameForm.GridFive, gameForm.GridSix);
                CheckWins(gameForm.GridSeven, gameForm.GridEight, gameForm.GridNine);

                //Check Vertical wins
                CheckWins(gameForm.GridOne, gameForm.GridFour, gameForm.GridSeven);
                CheckWins(gameForm.GridTwo, gameForm.GridFive, gameForm.GridEight);
                CheckWins(gameForm.GridThree, gameForm.GridSix, gameForm.GridNine);

                //Check Diagonal wins
                CheckWins(gameForm.GridOne, gameForm.GridFive, gameForm.GridNine);
                CheckWins(gameForm.GridThree, gameForm.GridFive, gameForm.GridSeven);
            }
        }

        /// <summary>
        /// This checks the game for possible wins.
        /// It takes three buttons and checks if those buttons have the same texts.
        /// if there is a winner, it increases the score of the winner by 1.
        /// </summary>
        /// <param name="buttonOne"></param>
        /// <param name="buttonTwo"></param>
        /// <param name="buttonThree"></param>
        internal static void CheckWins(Button buttonOne, Button buttonTwo, Button buttonThree)
        {
            if (buttonOne.Text == buttonTwo.Text && buttonOne.Text == buttonThree.Text
                && buttonOne.Text != "")
            {
                buttonOne.BackColor = Color.Red;
                buttonTwo.BackColor = Color.Red;
                buttonThree.BackColor = Color.Red;
                string winner;
                if (sessions % 2 != 0 && buttonOne.Text == "X")
                {
                    winner = gameForm.FirstPlayerLabel.Text.TrimEnd(':');
                    gameForm.FirstPlayerScore.Text = (Convert.ToInt16(gameForm.FirstPlayerScore.Text) + 1).ToString();
                }
                else if (sessions % 2 == 0 && buttonOne.Text == "O")
                {
                    winner = gameForm.FirstPlayerLabel.Text.TrimEnd(':');
                    gameForm.FirstPlayerScore.Text = (Convert.ToInt16(gameForm.FirstPlayerScore.Text) + 1).ToString();
                }
                else
                {
                    winner = gameForm.SecondPlayerLabel.Text.TrimEnd(':');
                    gameForm.SecondPlayerScore.Text = (Convert.ToInt16(gameForm.SecondPlayerScore.Text) + 1).ToString();
                }
                gameForm.PlayerIndicatorLabel.Text = $"{winner} [{buttonOne.Text}] Wins!!!";
                gameOver = true;
            }
        }

        /// <summary>
        /// This initializes the grid. It takes everything and sets it to their initial values apart from the sessions variable
        /// which is incremented by one. If it is an even session, the computer then clicks a button.
        /// </summary>
        internal static void InitialGrid()
        {
            sessions++;
            turns = 1;
            firstPlayerTurn = true;
            gameOver = false;
            GameForm.buttons = new List<Button> { gameForm.GridOne, gameForm.GridTwo,gameForm.GridThree,
                                         gameForm.GridFour, gameForm.GridFive, gameForm.GridSix,
                                         gameForm.GridSeven, gameForm.GridEight, gameForm.GridNine };

            foreach (Button button in GameForm.buttons)
            {
                button.BackColor = Color.Silver;
                button.Text = "";
                button.Enabled = true;
            }
            if (sessions % 2 == 0)
            {
                if (computerMode)
                {
                    gameForm.PlayerIndicatorLabel.Text = $"{gameForm.SecondPlayerLabel.Text.TrimEnd(':')} is now X!";
                    ComputerLogic.ComputerClick(GameForm.buttons, GameForm.random); 
                }
                else
                {
                    SettingLabel(gameForm.SecondPlayerLabel, false);
                }
            }
            else
            {
                if (computerMode)
                {
                    gameForm.PlayerIndicatorLabel.Text = $"{gameForm.FirstPlayerLabel.Text.TrimEnd(':')} is X!";
                }
                else
                {
                    SettingLabel(gameForm.FirstPlayerLabel, true);
                }
            }
        }
    }
    
}
