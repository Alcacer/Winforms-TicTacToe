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
                    gameForm.PlayerIndicatorLabel.Text = 
                        $"{gameForm.SecondPlayerLabel.Text.Substring(0, gameForm.SecondPlayerLabel.Text.Length - 1)} to play...";
                    firstPlayerTurn = false;
                }
                else
                {
                    gameForm.PlayerIndicatorLabel.Text =
                        $"{gameForm.FirstPlayerLabel.Text.Substring(0, gameForm.FirstPlayerLabel.Text.Length - 1)} to play...";
                    firstPlayerTurn = true;
                }
            }
            else
            {
                if (firstPlayerTurn)
                {
                    gameForm.PlayerIndicatorLabel.Text = 
                        $"{gameForm.SecondPlayerLabel.Text.Substring(0, gameForm.SecondPlayerLabel.Text.Length - 1)} to play..."; ;
                    firstPlayerTurn = false;
                }
                else
                {
                    gameForm.PlayerIndicatorLabel.Text = 
                        $"{gameForm.FirstPlayerLabel.Text.Substring(0, gameForm.FirstPlayerLabel.Text.Length - 1)} to play...";
                    firstPlayerTurn = true;
                }
            }  
        }
    }
}
