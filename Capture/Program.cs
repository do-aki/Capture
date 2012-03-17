using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Capture
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (0 < args.Length && string.Compare(args[0], "/setting", true) == 0)
            {
                Application.Run(new SettingForm());
                Properties.Settings.Default.Save();
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
