using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODM.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ODM.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Build the DI container
            var serviceProvider = Startup.ConfigureServices();

            Application.Run(new LoginForm());
        }
    }
}
