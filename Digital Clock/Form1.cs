using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        System.Configuration.Configuration config =
         System.Configuration.ConfigurationManager.OpenExeConfiguration(
          System.Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal);


        //Win32API
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        //ディスプレイの高さ
        public static int h = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        //public static int h;
        //ディスプレイの幅
        public static int w = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        //public static int w;

        int font_size;

        int mode = 1;
        string dt;//datatime
        string timmem = null;
        int timer_count = 0;

        string format_str = "";
        int z = 0;
        string font = Control.DefaultFont.ToString();
        bool clipro = false;        
        int pen_size = 5;
        public static Color pen_color = Color.Black;
        public static SmoothingMode smmode = SmoothingMode.AntiAlias;
        int fstyle = 0;
        public static bool Bordering_enable = true;        

        //Form1オブジェクトを保持するためのフィールド
        private static Form1 _form1Instance;

        //Form1オブジェクトを取得、設定するためのプロパティ
        public static Form1 Form1Instance
        {
            get
            {
                return _form1Instance;
            }
            set
            {
                _form1Instance = value;
            }
        }

        public Color form_color
        {
            get
            {
                return BackColor;
            }
            set
            {
                BackColor = value;
                drawing();
            }
        }

        public double Form_Opacity
        {
            get
            {
                return Opacity;
            }
            set
            {
                Opacity = value*0.01;
            }
        }

        public string _font
        {
            get
            {
                return font;
            }
            set
            {
                font = value;
                drawing();
            }
        }

        public int _font_size
        {
            get
            {
                return font_size;
            }
            set
            {
                font_size = value;
                drawing();
            }
        }
        public int _font_style
        {
            get
            {
                return fstyle;
            }
            set
            {
                fstyle = value;
                drawing();
            }
        }

        public int _pen_size
        {
            get
            {
                return pen_size;
            }
            set
            {
                pen_size = value;
                drawing();
            }
        }

        //表示形式
        public string display_format
        {
            get
            {
                return format_str;
            }
            set
            {
                format_str = value;
                drawing();
            }
        }
        //mode
        public int display_mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
            }
        }

        public bool click_prohibition//クリック禁止
        {
            get
            {
                return clipro;
            }
            set
            {
                clipro = value;
                if (clipro == true)
                {
                    pictureBox1.Enabled = false;
                }
                else
                {
                    pictureBox1.Enabled = true;

                }
            }
        }

        public int z_order
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
                if_zorder();
            }
        }

        private void if_zorder()//条件分岐メソッド
        {
            switch (z)
            {
                case 0:
                    this.TopMost = false;
                    break;
                case 1:
                    this.TopMost = true;
                    break;
                case 2:
                    this.TopMost = false;
                    SendToBack();
                    break;
            }
        }
        /*
        private void send_back()//再背面に移動　※フォーム移動するとフォームが行方不明になるので使わないことにした
        {
            IntPtr WinHandle = FindWindow(null, "Program Manager");
            if (WinHandle != null)
            {
                SetParent(this.Handle, WinHandle);
            }
        }*/

        public Form1()
        {
            InitializeComponent();
            config_load();
            //フォームのサイズをプライマリディスプレイと同じサイズにする
            this.SetDesktopBounds(0, 0, w, h);
            timer1.Start();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if_zorder();
            Opacity = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            font_size = int.Parse(this.label_size.Text);
            mode = int.Parse(this.label_mode.Text);
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);

            Form1.Form1Instance = this;

            if (clipro == true)
            {
                pictureBox1.Enabled = false;
            }
            else
            {
                pictureBox1.Enabled = true;

            }
        }

        private void config_load()
        {
            format_str = Properties.Settings.Default.display_format;
            z = Properties.Settings.Default.Z_Order;//z_order
            clipro = Properties.Settings.Default.click_prohibition;//クリック禁止
            Opacity = Properties.Settings.Default.Opacity * 0.01;
            tsm_fontComboBox.Text = Properties.Settings.Default.font;
            tsm_customsizeTextBox.Text = Properties.Settings.Default.fsize;
            font = Properties.Settings.Default.font;
            this.BackColor = Properties.Settings.Default.FormColor;
            pen_size = Properties.Settings.Default.pen_size;//EDGE
            pen_color = Properties.Settings.Default.pen_color;
            smmode = Properties.Settings.Default.smooth_mode;
            fstyle = Properties.Settings.Default.font_style;
            Bordering_enable = Properties.Settings.Default.Bordering_enable;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_count++;

            timmem = dt;

            //現在時刻を取得しカスタム文字列で表示
            switch (mode)
            {
                case 1:
                    dt = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    break;

                case 2:
                    dt = DateTime.Now.ToString("yyyy/MM/dd\nHH:mm:ss");
                    break;

                case 3:
                    dt = DateTime.Now.ToString("HH:mm:ss");
                    break;

                case 4:
                    dt = DateTime.Now.ToString("HH\nmm");
                    break;

                case 5://カスタム表示
                    try
                    {
                        dt = DateTime.Now.ToString(display_format);
                    }
                    catch
                    {
                        break;
                    }
                    break;

                default:
                    break;
            }

            if (timmem != dt || timer_count % 20 == 0)//現在記憶されている時刻と違う，または指定秒以上経過で描画を実行
            {
                drawing();
                timer_count = 0;

                if (z == 2 && (_instance == null || _instance.IsDisposed))
                    SendToBack();
            }
        }
        //描画位置オフセット
        int x = 600;
        int y = 100;
        private void drawing()//描画メソッド
        {
            if (Bordering_enable == true && pictureBox1.Image != null)
                pictureBox1.Image.Dispose();//開放
            if (pictureBox1.Image != null)
                pictureBox1.Image = null;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddString(dt, new FontFamily(font),
            (int)fstyle, font_size, new Point(x, y),
            StringFormat.GenericDefault);


            if (Bordering_enable == true)
            {
                //フォントオブジェクトの作成
                Font fnt = new Font(font, font_size);

                //描画先とするImageオブジェクトを作成する
                Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                //ImageオブジェクトのGraphicsオブジェクトを作成する
                Graphics g = Graphics.FromImage(canvas);


                //GraphicsPathオブジェクトの作成
                System.Drawing.Drawing2D.GraphicsPath gp =
                    new System.Drawing.Drawing2D.GraphicsPath();
                //GraphicsPathに文字列を追加する
                FontFamily ff = new FontFamily(font);
                gp.AddString(dt, ff, (int)fstyle, font_size,
                    new Point(x, y), StringFormat.GenericDefault);

                //SmoothingModeを指定する
                g.SmoothingMode = smmode;

                //文字列の中を塗りつぶす
                //g.FillPath(Brushes.White, gp);
                //文字列の縁を描画する
                Pen p = new Pen(pen_color, pen_size);
                g.DrawPath(p, gp);

                //スケーリング(文字列の幅に合わせてフォームサイズ変更)
                SizeF stringSize = g.MeasureString(dt, fnt, 4096, StringFormat.GenericDefault);//幅4096として計算
                //SizeF stringSize = g.MeasureString(dt, fnt, 4096, StringFormat.GenericDefault);//変更前
                this.Size = new Size((int)stringSize.Width + x, (int)stringSize.Height + y);//オフセットx,y
                w = (int)stringSize.Width;
                h = (int)stringSize.Height;

                //リソースを解放する
                ff.Dispose();
                fnt.Dispose();
                g.Dispose();

                //PictureBox1に表示する
                pictureBox1.Image = canvas;
            }

            this.Region = new Region(path);//フォーム変形

        }

        private Point mousePoint;

        //マウスのボタンが押されたとき
        private void Form_MouseDown(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        //マウスが動いたとき
        private void Form_MouseMove(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        //不透明度変更
        private void tsm_opa100_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
            Properties.Settings.Default.Opacity = 100;
        }

        private void tsm_opa90__Click(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
            Properties.Settings.Default.Opacity = 90;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void tsm_opa80__Click(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
            Properties.Settings.Default.Opacity = 80;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void tsm_opa70__Click(object sender, EventArgs e)
        {
            this.Opacity = 0.7;
            Properties.Settings.Default.Opacity = 70;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void tsm_opa60__Click(object sender, EventArgs e)
        {
            this.Opacity = 0.6;
            Properties.Settings.Default.Opacity = 60;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void tsm_opa50__Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            Properties.Settings.Default.Opacity = 50;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void tsm_opa40__Click(object sender, EventArgs e)
        {
            this.Opacity = 0.4;
            Properties.Settings.Default.Opacity = 40;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void tsm_opa30__Click(object sender, EventArgs e)
        {
            this.Opacity = 0.3;
            Properties.Settings.Default.Opacity = 30;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void tsm_opa20__Click(object sender, EventArgs e)
        {
            this.Opacity = 0.2;
            Properties.Settings.Default.Opacity = 20;
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void tsm_opa10__Click(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Properties.Settings.Default.Opacity = 10;
            Digital_Clock.Properties.Settings.Default.Save();

        }



        //カラーダイアログを表示
        private void tsm_coror_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BackColor = colorDialog1.Color;

                Digital_Clock.Properties.Settings.Default.Save();
            }
        }



        //Mode
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
            font_size = int.Parse(Properties.Settings.Default.preset_fsize[2]);
            Properties.Settings.Default.fsize = Properties.Settings.Default.preset_fsize[2];
        }

        private void MediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            font_size = int.Parse(Properties.Settings.Default.preset_fsize[1]);
            Properties.Settings.Default.fsize = Properties.Settings.Default.preset_fsize[1];
        }

        private void SmallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            font_size = int.Parse(Properties.Settings.Default.preset_fsize[0]);
            Properties.Settings.Default.fsize = Properties.Settings.Default.preset_fsize[0];
        }

        //アプリケーンション終了
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close._close_dialog();
        }


        //ApplicationExitイベントハンドラ
        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            //アプリケーション終了時に設定を保存する
            Digital_Clock.Properties.Settings.Default.Save();
            Application.ApplicationExit -= new EventHandler(Application_ApplicationExit);
        }



        private void tsm_font_DropDown(object sender, EventArgs e)
        {
            List<string> CB = new List<string>();
            get_font.get(CB);//フォント一覧を取得
            foreach (string s in CB)
            {
                tsm_fontComboBox.Items.Add(s);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            font = tsm_fontComboBox.Text;
            Properties.Settings.Default.font = tsm_fontComboBox.Text;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to completely reset setting ?", "Reset",
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
                Opacity = Properties.Settings.Default.Opacity*0.01;
                font_size = int.Parse(Properties.Settings.Default.fsize);

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
            if ((e.KeyChar == (char)Keys.Enter && tsm_customsizeTextBox.Text != string.Empty)
                && int.Parse(tsm_customsizeTextBox.Text) >= 10 && int.Parse(tsm_customsizeTextBox.Text) <= 500)
            {
                font_size = int.Parse(tsm_customsizeTextBox.Text);

                Properties.Settings.Default.fsize = font_size.ToString();
            }
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void View_the_fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(config.FilePath);//configがあるファイルを開く
            }
            catch
            {

            }
        }

        private void ViewTheFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //指定したパスから親ディレクトリを取得
            try
            {
                System.Diagnostics.Process.Start(System.IO.Directory.GetParent(config.FilePath).ToString());
            }
            catch
            {

            }
        }


        //ただ一つのフォームのインスタンスを保持するフィールド
        private static AdvanceSetting _instance;
    
        //ただ一つのフォームにアクセスするためのプロパティ
        public static AdvanceSetting Instance
        {
            get
            {
                //_instanceがnullまたは破棄されているときは、
                //新しくインスタンスを作成する
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new AdvanceSetting();
                }
                return _instance;
            }
        }

        private void advanceSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.Instance.Show();
        }

    }

}
