﻿using System;
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

        private void VersusComButton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }
    }
}