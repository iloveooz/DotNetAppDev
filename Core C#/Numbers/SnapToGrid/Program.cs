﻿/**
 * Округление точек на сетке
 */
using System;
using System.Windows.Forms;

namespace SnapToGrid
{
   static class Program
   {
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new MainForm());
      }
   }
}
