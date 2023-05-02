using System;
using System.Windows.Forms;

namespace TicTacToe_with_Winforms
{
    internal static class Program
    {
        //Initialized it and made it static so that it'd be callable in other classes.
        internal static HomeMenu homeMenu;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            homeMenu = new HomeMenu();
            Application.Run(homeMenu);
        }
    }
}
