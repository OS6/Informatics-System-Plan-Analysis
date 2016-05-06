using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XoSoKienThiet.Presentation;

namespace XoSoKienThiet
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
            //Application.Run(new frmDOITAC());
            //Application.Run(new frmDANHSACHLOAIVE());
            //Application.Run(new frmCOCAUGIAITHUONG());
            Application.Run(new frmPHIEUNHANVE());
        }
    }
}
