using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp
{
    internal static class Program
    {
        public static User currentUser;
        [STAThread]
        static void Main()
        {
            DBManager.DBConnection("administrator", "admin", "RZD");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
