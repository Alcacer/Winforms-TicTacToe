using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //TODO - Probable make an initial class that will store the initial image of the grid
            //and this button would just load that up.
        }
        private char closeReason = 'X';
        private void BackButton_Click(object sender, EventArgs e)
        {
            closeReason = 'B';
            Close();
            Program.homeMenu.Show(); //From the Program class.   
            Turns.sessions = Turns.turns = 1;
            Turns.firstPlayerTurn = true;
        }
        
        /// <summary>
        /// This function is for all the buttons on the grid and is passed into all the buttons' 
        /// event handlers in the partial class. When a button is pressed, the sender stores the 
        /// button that is pressed and sets the text of the button. The button is disabled after
        /// the button is pressed to avoid changing the first inputed value.
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
                Turns.SetTurnLabel();
                clickedButton.Enabled = false;                
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
