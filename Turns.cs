using System;
using System.Collections.Generic;
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
                    HorizontalChecks();
                }
                else
                {
                    SettingLabel(gameForm.FirstPlayerLabel, true);
                    HorizontalChecks();
                }
            }
        }
        //To remove repetition of code.
        internal static void SettingLabel(System.Windows.Forms.Label label, bool status)
        {
            
            gameForm.PlayerIndicatorLabel.Text =
                        $"{label.Text.Substring(0, label.Text.Length - 1)} to play...";
            firstPlayerTurn = status;
        }
        internal static bool CheckWins(System.Windows.Forms.Button buttonOne,
            System.Windows.Forms.Button buttonTwo,
            System.Windows.Forms.Button buttonThree)
        {
            ///<summary>
            ///Basically, there are three ways to win, horisontally, vertically and diagonally.
            ///In the horizontal alone, there are three paths to win, same with the vertical, 
            ///while the diagonal has two. So that is 8 potential paths to a win.
            ///Can I define a single function for all these permutations?
            ///If in the function i pass in three arguments which are buttons of course, and i say
            ///if the three buttons are equal, then we have a winner, and to return the text of that
            ///button.
            ///Horizontal: one two three; four five six; seven eight nine.
            ///Vertical: one four seven; two five eight; three, six nine.
            ///Horizontal: one five nine; three five seven
            /// </summary>
            if (buttonOne.Text == buttonTwo.Text && buttonOne.Text == buttonThree.Text 
                && buttonOne.Text != "")
            {
                buttonOne.BackColor = System.Drawing.Color.Red;
                buttonTwo.BackColor = System.Drawing.Color.Red;
                buttonThree.BackColor = System.Drawing.Color.Red;
                string winner;
                if (sessions % 2 != 0 && buttonOne.Text == "X")
                {
                    winner = gameForm.FirstPlayerLabel.Text.Trim(':');
                }
                else if(sessions % 2 == 0 && buttonOne.Text == "O") 
                {
                    winner = gameForm.FirstPlayerLabel.Text.TrimEnd(':');
                }else
                {
                    winner = gameForm.SecondPlayerLabel.Text.TrimEnd(':');
                }
                gameForm.PlayerIndicatorLabel.Text = $"The winner is {winner}";
                return true;
            }
            return false;
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
