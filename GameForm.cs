using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
            Program.homeMenu.Show(); //From the Program class.   
            Turns.sessions = Turns.turns = 1;
            Turns.firstPlayerTurn = true;
        }
        private void GridOne_Click(object sender, EventArgs e)
        {
            Turns.SetTurnLabel();
            GridOne.Text = Turns.GetTurn().ToString();
        }
    }
}
