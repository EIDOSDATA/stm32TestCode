﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EPT_LED_Blinky
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
            Application.Run(new EPT_LED_Blinky());
        }
    }
}