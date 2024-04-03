using DevExpress.Skins;
using DevExpress.UserSkins;
using SimulationDevelopment.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimulationDevelopment
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

            // chạy form main
            //Application.Run(new MainForm());

            // mở comment để chạy chức năng preview trận đấu
            Application.Run(new TestBattleMap());
        }
    }
}