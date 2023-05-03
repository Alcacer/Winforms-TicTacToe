using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static TicTacToe_with_Winforms.HomeMenu;

namespace TicTacToe_with_Winforms
{
    internal class ComputerLogic
    {
        /// <summary>
        /// This function is to select a button for the computer to click. It compares the three buttons and if there is 
        /// a possibility for a win, i.e two buttons with the same text and one button with empty text, it returns the button in a
        /// tuple together with a boolean value and a string.
        /// If there is a button with a possible win, it returns boolean value of true, and the text of the buttons in the tuple,
        /// which would be used in the PossibleWinCheck function. In case of no possible win, the function returns false, 
        /// with an empty string, with a button(in this case buttonOne, but just to fulfill all righteuousness).
        /// </summary>
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

        /// <summary>
        /// This function takes in two variables; tuples containing a Button and a string.
        /// Left alone the SmartComputerChoice function would pick the first possible winning grid when faced with a scenario
        /// where more than one win(be it for the computer or the player) is possible and play there, regardless
        /// of what that would mean, be it blocking a win or getting a win itself. 
        /// This function on the other hand, takes in two possible winning scenarios and checks if there is a chance for the
        /// computer to win and then plays there first. 
        /// If there is no chance for the computer to win, it simply plays the first passed variable.
        /// </summary>
        /// <param name="firstCheck"> A tuple of Button and string types. It contains the first winning scenario grid and 
        /// the text of that possible winning grid.</param>
        /// <param name="secondCheck">A tuple of Button and string types. It contains the first winning scenario grid and 
        /// the text of that possible winning grid.</param>
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
            //This is in the case the player has a double win chance; both Xs in odd sessions or both Os in even sessions.
            else { return firstCheck.Item1; }
        }

        internal static void ComputerClick(List<Button> buttonList, Random random)
        {
            // The reason these variables are initialized to the play again button is simply for that; initialization.
            // Rather than create new buttons, I just set them to the already existing button which is disabled by default.
            //This won't matter as the values of these variables would be changed when they're used.
            Button computerChoice = gameForm.PlayAgainButton;
            (Button, string) horizontalValue = (gameForm.PlayAgainButton, "");
            (Button, string) horizontalValueTwo = (gameForm.PlayAgainButton, "");
            (Button, string) verticalValue = (gameForm.PlayAgainButton, "");
            (Button, string) verticalValueTwo = (gameForm.PlayAgainButton, "");
            (Button, string) diagonalValue = (gameForm.PlayAgainButton, "");
            int index = random.Next(buttonList.Count); // Generates a random number within the index range of the buttons List.

            //The computer clicks randomly on any enabled button on the grid, until turns is greater than three, which is the minimum
            //point at which it is able to play to win or block a potential win by the player.
            if (Turns.turns > 3)
            {
                //Checks for potential wins in the horizontal rows.
                HorizontalChecks(ref horizontalValue, ref horizontalValueTwo);

                //Checks for potential wins in the vertical columns. There is no need to check in the vertical columns if there is a
                //second potential horizontal win. If there are two Xs on one horizontal row, and two Os on another horizontal row, it
                // is not possible to have a vertical win.
                if (horizontalValueTwo.Item2 == "")
                {
                    VerticalChecks(ref verticalValue, ref verticalValueTwo);
                }

                //Checks for wins in the diagonal grids, of course if there are no second vertical or horizontal winning scenarios.
                if (horizontalValueTwo.Item2 == "" || verticalValueTwo.Item2 == "")
                {
                    DiagonalChecks(ref diagonalValue);
                }
                

                //This compares the win scenarios and picks the most optimal for the computer.
                //If there are two win possiblities, it picks the one that
                //lets the computer win, else if there is only one possibility it picks that one.
                //If there are no possibilities, a random button is clicked.
                if (horizontalValue.Item2 != "" && horizontalValueTwo.Item2 != "")
                {
                    computerChoice = PossibleWinCheck(horizontalValue, horizontalValueTwo);
                }
                else if (verticalValue.Item2 != "" && verticalValueTwo.Item2 != "")
                {
                    computerChoice = PossibleWinCheck(verticalValue, verticalValueTwo);
                }
                else if (diagonalValue.Item2 != "" && verticalValue.Item2 != "")
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
                else
                {
                    if (horizontalValue.Item2 != "") 
                    { 
                        computerChoice = horizontalValue.Item1; 
                    }
                    else if (verticalValue.Item2 != "") 
                    { 
                        computerChoice = verticalValue.Item1; 
                    }
                    else if (diagonalValue.Item2 != "") 
                    { 
                        computerChoice = diagonalValue.Item1; 
                    }
                    else 
                    { 
                        computerChoice = buttonList[index]; 
                    }
                }
            }

            //When the number of turns is less than 3, a random button is picked.
            else
            {
                computerChoice = buttonList[index];
            }

            //Performs a click after a choice has been made.
            computerChoice.PerformClick();
        }

        /// <summary>
        /// This runs the SmartComputerChoice function on diagonal grids, and if winning possibilities are found, the 
        /// diagonalValue variable is updated. The ref keyword in the method signature, basically passes the address of the
        /// argument that is put in and changes the content. It is like the global keyword in python and the ampersand in C.
        /// </summary>
        internal static void DiagonalChecks(ref (Button, string) diagonalValue)
        {
            var values = SmartComputerChoice(gameForm.GridOne, gameForm.GridFive, gameForm.GridNine);
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
        }

        /// <summary>
        /// This runs the SmartComputerChoice function on the horizontal grids. Since there are 3 possible ways to win horizontally,
        /// it is possible to get two horizontal winning possibilities at once, with 2 Xs and 2 Os. This is only possible when turns 
        /// is more than 5, hence the condition. The ref keyword is also used here for the parameters.
        /// </summary>
        internal static void HorizontalChecks(ref (Button, string) horizontalValue, ref (Button, string) horizontalValueTwo)
        {
            var values = SmartComputerChoice(gameForm.GridOne, gameForm.GridTwo, gameForm.GridThree);
            if (values.Item2 && values.Item1.Enabled)
            {
                horizontalValue = (values.Item1, values.Item3);

                //Checking if there are two winning horizontals adjacent to each other. 
                if (Turns.turns > 4)
                {
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
            }
            else
            {
                values = SmartComputerChoice(gameForm.GridFour, gameForm.GridFive, gameForm.GridSix);
                if (values.Item2 && values.Item1.Enabled)
                {
                    horizontalValue = (values.Item1, values.Item3);

                    //Checking if there are two winning horizontals adjacent to each other
                    if (Turns.turns > 4)
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
                    values = SmartComputerChoice(gameForm.GridSeven, gameForm.GridEight, gameForm.GridNine);
                    if (values.Item2 && values.Item1.Enabled)
                    {
                        horizontalValue = (values.Item1, values.Item3);
                    }
                }
            }
        }

        /// <summary>
        /// This runs the SmartComputerChoice function on the vertical grids. Since there are 3 possible ways to win vertically,
        /// it is possible to get two vertical winning possibilities at once, with 2 Xs and 2 Os. This is only possible when turns 
        /// is more than 5, hence the condition. The ref keyword is also used here for the parameters.
        /// </summary>
        internal static void VerticalChecks(ref (Button, string) verticalValue, ref (Button, string) verticalValueTwo)
        {
            var values = SmartComputerChoice(gameForm.GridOne, gameForm.GridFour, gameForm.GridSeven);
            if (values.Item2 && values.Item1.Enabled)
            {
                verticalValue = (values.Item1, values.Item3);

                //Checking if there are two winning verticals adjacent to each other
                if (Turns.turns > 4) 
                {
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
            }
            else
            {
                values = SmartComputerChoice(gameForm.GridTwo, gameForm.GridFive, gameForm.GridEight);
                if (values.Item2 && values.Item1.Enabled)
                {
                    verticalValue = (values.Item1, values.Item3);

                    //Checking if there are two winning verticals adjacent to each other
                    if (Turns.turns > 4) 
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
                    values = SmartComputerChoice(gameForm.GridThree, gameForm.GridSix, gameForm.GridNine);
                    if (values.Item2 && values.Item1.Enabled)
                    {
                        verticalValue = (values.Item1, values.Item3);
                    }
                }
            }
        }
    }
}
