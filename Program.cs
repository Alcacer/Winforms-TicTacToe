using System;
using System.Windows.Forms;

namespace TicTacToe_with_Winforms
{
    internal static class Program
    {
        //Did it this way in order for the GameForm to be able to call up the home form.
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
