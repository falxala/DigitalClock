using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Digital_Clock
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //if (Control.ModifierKeys == Keys.Alt || Control.ModifierKeys == Keys.Shift || Control.ModifierKeys == Keys.Control)
            //    Properties.Settings.Default.Reload();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //二重起動をチェックする
            if (System.Diagnostics.Process.GetProcessesByName(
                System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                //すでに起動していると判断して終了
                MessageBox.Show("Application is already running");
                return;
            }



            Application.Run(new Form1());
        }
    }
}
