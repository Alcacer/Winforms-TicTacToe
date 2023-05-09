using System;
using System.Threading;
using System.Windows.Forms;

namespace TicTacToe_with_Winforms
{
    internal static class Program
    {
        private static Mutex mutex = null; // mutex used to make sure only one instance of the app is run when clicked.
        
        internal static HomeMenu homeMenu; //Initialized it and made it static so that it'd be callable in other classes.
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            mutex = new Mutex(true, "X and O", out bool createdNew);

            if (!createdNew)
            {
                // If another instance is trying to run...
                MessageBox.Show("X and O is already running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            homeMenu = new HomeMenu();
            Application.Run(homeMenu);

            mutex.ReleaseMutex();
        }
    }
}
