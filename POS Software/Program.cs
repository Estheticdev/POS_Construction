using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS_Software
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Admin.UserLogin());
            //Application.Run(new frmMDI());
            // Application.Run(new frmconnection());
            //Application.Run(new Reports.Purchase.frmPSVAT());
        }
    }
}
