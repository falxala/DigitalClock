using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Digital_Clock
{
    public static class close
    {
        public static void _close_dialog()
        {
            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("Save setting and exit?",
                "Close the application",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            ////終了処理
            if (result == DialogResult.Yes)
            {
                Form1.Instance.Close();
                //アプリケーション終了時に設定を保存する
                Digital_Clock.Properties.Settings.Default.Save();
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                Form1.Instance.Close();
                Application.Exit();
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }
    }
}
