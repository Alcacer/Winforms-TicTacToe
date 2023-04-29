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
    public partial class HomeMenu : Form
    {
        public HomeMenu()
        {
            InitializeComponent();
        }

        internal static GameForm gameForm;
        internal static bool computerMode;
        private void VersusComButton_Click(object sender, EventArgs e)
        {
            computerMode = true;
            gameForm = new GameForm();
            gameForm.Show();
            Hide();
            
        }

        private void VersusPlayerButton_Click(object sender, EventArgs e)
        {
            computerMode = false;
            gameForm = new GameForm();
            gameForm.SecondPlayerLabel.Text = "Player Two:";
            gameForm.Show();
            Hide();
        }
    }
}
