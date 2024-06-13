﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubliminaleWahrnehmungTest
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ViewSubTest());
        }
        static private string modelSubTest = IModelSubTest;
        static private string viewSubTest = IViewSubTest;
        static private string controllerSubTest = IControllerSubTest;
    }
}
