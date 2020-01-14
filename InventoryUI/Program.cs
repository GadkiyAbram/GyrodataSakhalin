using InventoryUI.FormsUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the database connections
            InventoryLibrary.GlobalConfig.InitializeConnections(true);

            Application.Run(new InventoryViewerForm());
            //Application.Run(new AddNewItemForm());
        }
    }
}
