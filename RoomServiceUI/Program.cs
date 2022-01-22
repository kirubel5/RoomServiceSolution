using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomServiceUI.Views;

namespace RoomServiceUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(ReceptionPage.Instance);
            //Application.Run(AdminPage.Instance);
            Application.Run(new AppShell());
        }
    }
}
