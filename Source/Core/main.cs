using System;
using System.Windows.Forms;

namespace ClassroomManagement
{
    static class MainApplication
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home.Home());
        }
    }
}