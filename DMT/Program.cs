﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMT
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendungg.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Würfel würfel = new Würfel();
            würfel.Würfeln(20, true, false);
            

            Application.Run(new Form1());
        }
    }
}
