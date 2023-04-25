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

namespace TicTacToe_with_Winforms
{
    internal class Turns
    {
        static internal int sessions = 1;
        static internal int turns = 1;
        static internal bool firstPlayerTurn = true;

        static GameForm labels = HomeMenu.gameForm;
        readonly static string firstPlayerText = labels.FirstPlayerLabel.Text;
        readonly static string secondPlayerText = labels.SecondPlayerLabel.Text;
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
                    labels.PlayerIndicatorLabel.Text = 
                        $"{secondPlayerText.Substring(0, secondPlayerText.Length - 1)} to play...";
                    firstPlayerTurn = false;
                }
                else
                {
                    labels.PlayerIndicatorLabel.Text =
                        $"{firstPlayerText.Substring(0, firstPlayerText.Length - 1)} to play...";
                    firstPlayerTurn = true;
                }
            }
            else
            {
                if (firstPlayerTurn)
                {
                    labels.PlayerIndicatorLabel.Text = 
                        $"{secondPlayerText.Substring(0, secondPlayerText.Length - 1)} to play..."; ;
                    firstPlayerTurn = false;
                }
                else
                {
                    labels.PlayerIndicatorLabel.Text = 
                        $"{firstPlayerText.Substring(0, firstPlayerText.Length - 1)} to play...";
                    firstPlayerTurn = true;
                }
            }  
        }
    }
}
