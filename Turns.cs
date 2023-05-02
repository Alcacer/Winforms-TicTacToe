using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static TicTacToe_with_Winforms.HomeMenu;

namespace TicTacToe_with_Winforms
{
    internal class Turns
    {
        internal static int sessions = 1;
        internal static int turns = 1;
        internal static bool firstPlayerTurn = true;
        internal static bool gameOver = false;

        internal static char GetTurn()
        {
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

        //To remove repetition of code.
        internal static void SettingLabel(Label label, bool status)
        {
            gameForm.PlayerIndicatorLabel.Text =
                        $"{label.Text.TrimEnd(':')} to play...";
            firstPlayerTurn = status;
        }

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
