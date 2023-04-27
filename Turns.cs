using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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

        /// <summary>
        /// The first condition is to set the PlayerIndicatorLabel at the start of a new 
        /// session.
        /// </summary>
        internal static void SetTurnLabel()
        {

            if (sessions != 1 & turns == 1)
            {
                if (sessions % 2 == 0)
                {
                    SettingLabel(gameForm.SecondPlayerLabel, false);
                }
                else
                {
                    SettingLabel(gameForm.FirstPlayerLabel, true);
                }
            }
            else
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
        }
        //To remove repetition of code.
        internal static void SettingLabel(System.Windows.Forms.Label label, bool status)
        {
            gameForm.PlayerIndicatorLabel.Text =
                        $"{label.Text.TrimEnd(':')} to play...";
            firstPlayerTurn = status;
            HorizontalChecks();
        }
        internal static bool CheckWins(System.Windows.Forms.Button buttonOne,
            System.Windows.Forms.Button buttonTwo,
            System.Windows.Forms.Button buttonThree)
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
                }
                else if(sessions % 2 == 0 && buttonOne.Text == "O") 
                {
                    winner = gameForm.FirstPlayerLabel.Text.TrimEnd(':');
                }else
                {
                    winner = gameForm.SecondPlayerLabel.Text.TrimEnd(':');
                }
                gameForm.PlayerIndicatorLabel.Text = $"The winner is {winner}!";
                gameOver = true;
                return true;
            }
            return false;
        }
        internal static void InitialGrid()
        {
            foreach (Control control in gameForm.Controls)
            {
                SetTurnLabel();
                if (control is System.Windows.Forms.Button && control.Text.Length < 2)
                {
                    control.BackColor = Color.Silver;
                    control.Text = "";
                    control.Enabled = true;
                    sessions++;
                    turns = 1;
                    firstPlayerTurn = true;
                    gameOver = false;
                }
            }
        }
        internal static void HorizontalChecks()
        {
            bool horizontalOne = CheckWins(gameForm.GridOne, gameForm.GridTwo, gameForm.GridThree);
            bool horizontalTwo = CheckWins(gameForm.GridFour, gameForm.GridFive, gameForm.GridSix);
            bool horizontalThree = CheckWins(gameForm.GridSeven, gameForm.GridEight, gameForm.GridNine);

            bool verticalOne = CheckWins(gameForm.GridOne, gameForm.GridFour, gameForm.GridSeven);
            bool verticalTwo = CheckWins(gameForm.GridTwo, gameForm.GridFive, gameForm.GridEight);
            bool verticalThree = CheckWins(gameForm.GridThree, gameForm.GridSix, gameForm.GridNine);

            bool diagonalOne = CheckWins(gameForm.GridOne, gameForm.GridFive, gameForm.GridNine);
            bool diagonalTwo = CheckWins(gameForm.GridThree, gameForm.GridFive, gameForm.GridSeven);
        }
    }
}
