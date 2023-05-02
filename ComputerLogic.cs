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
    internal class ComputerLogic
    {

        internal static (Button, bool, string) SmartComputerChoice(Button buttonOne, Button buttonTwo, Button buttonThree)
        {
            if (buttonOne.Text != "" && (buttonTwo.Text == buttonOne.Text || buttonThree.Text == buttonOne.Text))
            {
                if (buttonTwo.Text == buttonOne.Text)
                {
                    return (buttonThree, true, buttonOne.Text);
                }
                else if (buttonThree.Text == buttonOne.Text)
                {
                    return (buttonTwo, true, buttonOne.Text);
                }
            }
            else if (buttonTwo.Text != "" && (buttonTwo.Text == buttonThree.Text))
            {
                return (buttonOne, true, buttonTwo.Text);
            }
            return (buttonOne, false, "");
        }

        internal static Button PossibleWinCheck((Button, string) firstCheck, (Button, string) secondCheck)
        {
            if (Turns.sessions % 2 == 0 && firstCheck.Item2 == "X")
            {
                return firstCheck.Item1;
            }
            else if (Turns.sessions % 2 == 0 && secondCheck.Item2 == "X")
            {
                return secondCheck.Item1;
            }

            else if (Turns.sessions % 2 != 0 && firstCheck.Item2 == "O")
            {
                return firstCheck.Item1;
            }

            else if (Turns.sessions % 2 != 0 && secondCheck.Item2 == "O")
            {
                return secondCheck.Item1;
            }
            //This is in case the player has a double win; both Xs in odd sessions or both Os in even sessions.
            else { return firstCheck.Item1; }
        }

        internal static void ComputerClick(List<Button> buttonList, Random random)
        {
            Button computerChoice = new Button();
            (Button, string) horizontalValue = (gameForm.PlayAgainButton, "");
            (Button, string) horizontalValueTwo = (gameForm.PlayAgainButton, "");
            (Button, string) verticalValue = (gameForm.PlayAgainButton, "");
            (Button, string) verticalValueTwo = (gameForm.PlayAgainButton, "");
            (Button, string) diagonalValue = (gameForm.PlayAgainButton, "");
            int index = random.Next(buttonList.Count);
            if (Turns.turns > 3)
            {
                //Horizontal checks
                var values = SmartComputerChoice(gameForm.GridOne, gameForm.GridTwo, gameForm.GridThree);
                if (values.Item2 && values.Item1.Enabled)
                {
                    horizontalValue = (values.Item1, values.Item3);
                    //Checking if there are two horizontals adjacent to each other
                    values = SmartComputerChoice(gameForm.GridFour, gameForm.GridFive, gameForm.GridSix);
                    if (values.Item2 && values.Item1.Enabled)
                    {
                        horizontalValueTwo = (values.Item1, values.Item3);
                    }
                    else
                    {
                        values = SmartComputerChoice(gameForm.GridSeven, gameForm.GridEight, gameForm.GridNine);
                        if (values.Item2 && values.Item1.Enabled)
                        {
                            horizontalValueTwo = (values.Item1, values.Item3);
                        }
                    }
                }
                else
                {
                    values = SmartComputerChoice(gameForm.GridFour, gameForm.GridFive, gameForm.GridSix);
                    if (values.Item2 && values.Item1.Enabled)
                    {
                        horizontalValue = (values.Item1, values.Item3);
                        //Checking if there are two horizontals adjacent to each other
                        values = SmartComputerChoice(gameForm.GridSeven, gameForm.GridEight, gameForm.GridNine);
                        if (values.Item2 && values.Item1.Enabled)
                        {
                            horizontalValueTwo = (values.Item1, values.Item3);
                        }
                    }
                    else
                    {
                        values = SmartComputerChoice(gameForm.GridSeven, gameForm.GridEight, gameForm.GridNine);
                        if (values.Item2 && values.Item1.Enabled)
                        {
                            horizontalValue = (values.Item1, values.Item3);
                        }
                    }
                }

                //Vertical Checks
                values = SmartComputerChoice(gameForm.GridOne, gameForm.GridFour, gameForm.GridSeven);
                if (values.Item2 && values.Item1.Enabled)
                {
                    verticalValue = (values.Item1, values.Item3);
                    //Checking if there are two verticals adjacent to each other
                    values = SmartComputerChoice(gameForm.GridTwo, gameForm.GridFive, gameForm.GridEight);
                    if (values.Item2 && values.Item1.Enabled)
                    {
                        verticalValueTwo = (values.Item1, values.Item3);
                    }
                    else
                    {
                        values = SmartComputerChoice(gameForm.GridThree, gameForm.GridSix, gameForm.GridNine);
                        if (values.Item2 && values.Item1.Enabled)
                        {
                            verticalValueTwo = (values.Item1, values.Item3);
                        }
                    }
                }
                else
                {
                    values = SmartComputerChoice(gameForm.GridTwo, gameForm.GridFive, gameForm.GridEight);
                    if (values.Item2 && values.Item1.Enabled)
                    {
                        verticalValue = (values.Item1, values.Item3);
                        //Checking if there are two verticals adjacent to each other
                        values = SmartComputerChoice(gameForm.GridThree, gameForm.GridSix, gameForm.GridNine);
                        if (values.Item2 && values.Item1.Enabled)
                        {
                            verticalValueTwo = (values.Item1, values.Item3);
                        }
                    }
                    else
                    {
                        values = SmartComputerChoice(gameForm.GridThree, gameForm.GridSix, gameForm.GridNine);
                        if (values.Item2 && values.Item1.Enabled)
                        {
                            verticalValue = (values.Item1, values.Item3);
                        }
                    }
                }

                //Diagonal Checks
                values = SmartComputerChoice(gameForm.GridOne, gameForm.GridFive, gameForm.GridNine);
                if (values.Item2 && values.Item1.Enabled)
                {
                    diagonalValue = (values.Item1, values.Item3);
                }
                else
                {
                    values = SmartComputerChoice(gameForm.GridThree, gameForm.GridFive, gameForm.GridSeven);
                    if (values.Item2 && values.Item1.Enabled)
                    {
                        diagonalValue = (values.Item1, values.Item3);
                    }
                }

                if (diagonalValue.Item2 != "" && verticalValue.Item2 != "")
                {
                    computerChoice = PossibleWinCheck(diagonalValue, verticalValue);

                }
                else if (diagonalValue.Item2 != "" && horizontalValue.Item2 != "")
                {
                    computerChoice = PossibleWinCheck(diagonalValue, horizontalValue);
                }
                else if (horizontalValue.Item2 != "" && verticalValue.Item2 != "")
                {
                    computerChoice = PossibleWinCheck(verticalValue, horizontalValue);
                }
                else if (horizontalValue.Item2 != "" && horizontalValueTwo.Item2 != "")
                {
                    computerChoice = PossibleWinCheck(horizontalValue, horizontalValueTwo);
                }
                else if (verticalValue.Item2 != "" && verticalValueTwo.Item2 != "")
                {
                    computerChoice = PossibleWinCheck(verticalValue, verticalValueTwo);
                }
                else
                {
                    if (horizontalValue.Item2 != "") { computerChoice = horizontalValue.Item1; }
                    else if (verticalValue.Item2 != "") { computerChoice = verticalValue.Item1; }
                    else if (diagonalValue.Item2 != "") { computerChoice = diagonalValue.Item1; }
                    else { computerChoice = buttonList[index]; }

                }

            }
            else
            {
                computerChoice = buttonList[index];
            }
            computerChoice.PerformClick();

        }
    }
}
