using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        //ディスプレイの高さ
        int h = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        //ディスプレイの幅
        int w = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;

        int size;

        int mode = 1;

        string dt;

        string font;

        // カレントディレクトリを取得する
        //string stCurrentDir = System.IO.Directory.GetCurrentDirectory();



        public Form1()
        {
            InitializeComponent();
            //フォームのサイズをプライマリディスプレイと同じサイズにする
            this.SetDesktopBounds(0, 0, w, h);
            timer1.Start();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Visible = false;
            Opacity = 0;
            this.Opacity = Properties.Settings.Default.Opacity;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.Text = Properties.Settings.Default.font;
            font = Properties.Settings.Default.font;
            this.BackColor = Properties.Settings.Default.FormColor;
          //this.Opacity = Properties.Settings.Default.Opacity;
            size = int.Parse(this.label_size.Text);
            mode = int.Parse(this.label_mode.Text);
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            toolStripTextBox1.Text = Properties.Settings.Default.fsize;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //現在時刻を取得しカスタム文字列で表示
            switch (mode)
            {
                case 1:
                    dt = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    break;
                
                case 2:
                    dt = DateTime.Now.ToString("yyyy/MM/dd \n") + DateTime.Now.ToString("HH:mm:ss");
                    break;
              
                case 3:
                    dt = DateTime.Now.ToString("HH:mm:ss");
                    break;

                case 4:
                    dt = DateTime.Now.ToString("HH:mm");
                    break;
            }
            

            System.Drawing.Drawing2D.GraphicsPath path =
            new System.Drawing.Drawing2D.GraphicsPath();
            //文字のサイズは50
            path.AddString(dt, new FontFamily(font),
            (int)FontStyle.Bold, size, new Point(0,0),
            StringFormat.GenericDefault);
            this.Region = new Region(path);

            /*if(Visible == false)
                Visible = true;*/
        }

        private Point mousePoint;

        //マウスのボタンが押されたとき
        private void Form1_MouseDown(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        //マウスが動いたとき
        private void Form1_MouseMove(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        //不透明度変更
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
            Properties.Settings.Default.Opacity = 1;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
            Properties.Settings.Default.Opacity = 0.9;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
            Properties.Settings.Default.Opacity = 0.8;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.7;
            Properties.Settings.Default.Opacity = 0.7;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.6;
            Properties.Settings.Default.Opacity = 0.6;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            Properties.Settings.Default.Opacity = 0.5;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.4;
            Properties.Settings.Default.Opacity = 0.4;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.3;
            Properties.Settings.Default.Opacity = 0.3;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.2;
            Properties.Settings.Default.Opacity = 0.2;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Properties.Settings.Default.Opacity = 0.1;
            Digital_Clock.Properties.Settings.Default.Save();

        }

        //カラーダイアログを表示
        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;

                Digital_Clock.Properties.Settings.Default.Save();
            }
        }

        //Mode
        private void ModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mode1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 1;
            Properties.Settings.Default.mode = "1";
        }

        private void mode2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 2;
            Properties.Settings.Default.mode = "2";
        }

        private void mode3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 3;
            Properties.Settings.Default.mode = "3";
        }

        private void mode4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 4;
            Properties.Settings.Default.mode = "4";
        }

        //Size
        private void LargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 110;
            Properties.Settings.Default.fsize = "110";
        }

        private void MediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 80;
            Properties.Settings.Default.fsize = "80";
        }

        private void SmallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            size = 50;
            Properties.Settings.Default.fsize = "50";
        }

        //アプリケーンション終了
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //ApplicationExitイベントハンドラ
        private void Application_ApplicationExit(object sender, EventArgs e)
        {

            //アプリケーション終了時に設定を保存する
            Digital_Clock.Properties.Settings.Default.Save();
        
        //今回は使用しない
        /*  //Shift JISで書き込む
            //書き込むファイルが既に存在している場合は、上書きする
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                @"config.txt",
                false,
                System.Text.Encoding.GetEncoding("shift_jis"));
            //一行ずつ書き込み
            sw.WriteLine("size=" + size.ToString());
            sw.WriteLine("mode=" + mode.ToString());
            //閉じる
            sw.Close();
         */

            //ApplicationExitイベントハンドラを削除
            Application.ApplicationExit -= new EventHandler(Application_ApplicationExit);
        }



        private void toolStripComboBox1_DropDown(object sender, EventArgs e)
        {
            //InstalledFontCollectionオブジェクトの取得
            System.Drawing.Text.InstalledFontCollection InstalledFont =
                new System.Drawing.Text.InstalledFontCollection();

            //インストール済みフォントを取得してコンボボックスに表示する
            FontFamily[] FontFamilies = InstalledFont.Families;

            foreach ( FontFamily f in FontFamilies)
            toolStripComboBox1.Items.Add(f.Name);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            font = toolStripComboBox1.Text;
            Properties.Settings.Default.font = toolStripComboBox1.Text;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset ?","Reset",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                //「はい」が選択された時      
                //デフォルトのプロパティに変更
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Reload();
               
                //それぞれ変更適用
                mode = int.Parse(Properties.Settings.Default.mode);
                font = Properties.Settings.Default.font;
                Opacity = Properties.Settings.Default.Opacity;
                size = int.Parse(Properties.Settings.Default.fsize);
                
            }
            else if (result == DialogResult.No)
            {
                //「いいえ」が選択された時
                
            }
            else if (result == DialogResult.Cancel)
            {
                //「キャンセル」が選択された時
                
            }
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //EnterやEscapeキーでビープ音が鳴らないようにする
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
            }

            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                //0～9と、バックスペース以外の時は、イベントをキャンセルする
                e.Handled = true;
            }

            //文字列が空でない
            if ((e.KeyChar == (char)Keys.Enter && toolStripTextBox1.Text != string.Empty)
                && int.Parse(toolStripTextBox1.Text)>=10 && int.Parse(toolStripTextBox1.Text)<=500)
            {
                size = int.Parse(toolStripTextBox1.Text);

                Properties.Settings.Default.fsize = size.ToString();
            }
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
    }
}
