using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLKS
{
    static class Program
    {
        public static string bophan = "";
        public static string manv = "";
        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LFQ4D05\MINHLONG;
                    Initial Catalog=QLKS;User ID=sa;Password=long2710jkl");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
