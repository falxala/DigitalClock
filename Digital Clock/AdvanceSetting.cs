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
    public partial class AdvanceSetting : Form
    {
        int w = 0;
        int h = 0;
        int dw = 0;//difference
        int dh = 0;

        System.Configuration.Configuration config =
         System.Configuration.ConfigurationManager.OpenExeConfiguration(
            System.Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal);


        public AdvanceSetting()
        {
            InitializeComponent();
        }

        string[] format_array = { "yyyy/MM/dd HH:mm:ss", "yyyy/MM/dd\r\nHH:mm:ss", "HH:mm:ss", "HH\r\nmm", "" };


        private void AdvanceSetting_Load(object sender, EventArgs e)
        {
            List<string> CB = new List<string>();
            get_font.get(CB);//フォント名取得
            foreach (string s in CB)
            {
                font.Items.Add(s);
            }

            string[] fstyke_array = { "Regular", "Bold" , "Italic" , "Strikeout" , "Underline" };//コンボボックス格納用
            //フォントスタイルコンボボックスに格納
            font_style_cb.Items.Add(FontStyle.Regular);
            font_style_cb.Items.Add(FontStyle.Bold);
            font_style_cb.Items.Add(FontStyle.Italic);
            font_style_cb.Items.Add(FontStyle.Strikeout);
            font_style_cb.Items.Add(FontStyle.Underline);
            display_CB.Items.Add("None");
            display_CB.Items.Add("Front");
            //display_CB.Items.Add("Back");//不安定なので除去

            mode_CB.Items.Add("Mode1");
            mode_CB.Items.Add("Mode2");
            mode_CB.Items.Add("Mode3");
            mode_CB.Items.Add("Mode4");
            mode_CB.Items.Add("Custom");

            //設定読み込み
            font.Text = Properties.Settings.Default.font;
            fcolor_pictureBox.BackColor = Properties.Settings.Default.FormColor;
            borderingcolor_pictureBox.BackColor = Properties.Settings.Default.pen_color;
            checkBox1.Checked = Properties.Settings.Default.Bordering_enable;
            numericUpDown1.Value = Properties.Settings.Default.pen_size;
            fontsize_numericUpDown.Value = int.Parse(Properties.Settings.Default.fsize);
            font_style_cb.Text = fstyke_array[Properties.Settings.Default.font_style];
            trackBar1.Value = (int)Properties.Settings.Default.Opacity;
            display_CB.SelectedIndex = Properties.Settings.Default.Z_Order;
            Form1.Form1Instance.click_prohibition = Properties.Settings.Default.click_prohibition;
            checkBox2.Checked = Properties.Settings.Default.click_prohibition;
            format_array[4] = Properties.Settings.Default.display_format;
            mode_CB.SelectedIndex =int.Parse(Properties.Settings.Default.mode)-1;

            opacity_label.Text = trackBar1.Value + "%";
            display_area();
            panel1.Visible = false;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Form1.Bordering_enable = true;
                Properties.Settings.Default.Bordering_enable = true;
            }

            else
            {
                Form1.Bordering_enable = false;
                Properties.Settings.Default.Bordering_enable = false;

            }


        }

        private void fcolor_pictureBox_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fcolor_pictureBox.BackColor = colorDialog1.Color;

                Properties.Settings.Default.FormColor = colorDialog1.Color;

                Form1.Form1Instance.form_color = Properties.Settings.Default.FormColor;

            }
        }

        private void borderingcolor_pictureBox_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                borderingcolor_pictureBox.BackColor = colorDialog1.Color;
                Form1.pen_color = colorDialog1.Color;
                Properties.Settings.Default.pen_color = colorDialog1.Color;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Digital_Clock.Properties.Settings.Default.Save();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Form1.Form1Instance._pen_size = (int)numericUpDown1.Value;
            Properties.Settings.Default.pen_size = (int)numericUpDown1.Value;
        }

        private void fontsize_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Form1.Form1Instance._font_size = (int)fontsize_numericUpDown.Value;
            Properties.Settings.Default.fsize = fontsize_numericUpDown.Value.ToString();
            display_area();
        }

        private void font_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.Form1Instance._font = font.Text;
            Properties.Settings.Default.font = font.Text;
            display_area();
        }

        private void font_style_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.Form1Instance._font_style = font_style_cb.SelectedIndex;
            Properties.Settings.Default.font_style = font_style_cb.SelectedIndex;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Form1.Form1Instance.Opacity = trackBar1.Value * 0.01;
            opacity_label.Text = trackBar1.Value+"%";
            Properties.Settings.Default.Opacity = trackBar1.Value; 
        }


        public void display_area()
        {
            w = Screen.PrimaryScreen.Bounds.Width;
            h = Screen.PrimaryScreen.Bounds.Height;
            dw = (w - Form1.w);
            dh = (h - Form1.h);
            Display_area_label.Text = "display area\n" + "w = " + Form1.w + "\n" + "h = " + Form1.h;
            label10.Text = "Primary Display\n" + "w = " + w + "\n" + "h = " + h;
            margin_label.Text = "Margin\n" + "w = " + dw + "\n" + "h = " + dh;
            if (dw < 0 || dh < 0)
            {
                drawing_label.ForeColor = Color.Red;
                drawing_label.Text = "drawing : " + "out";
            }
            else
            {
                drawing_label.ForeColor = Color.Green;
                drawing_label.Text = "drawing : " + "safe";
            }
        }

        private void display_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.Form1Instance.z_order = display_CB.SelectedIndex;
            Properties.Settings.Default.Z_Order = display_CB.SelectedIndex;
        }

        private void AdvanceSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
             
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Form1.Form1Instance.click_prohibition = true;
                Properties.Settings.Default.click_prohibition = true;
            }

            else
            {
                Form1.Form1Instance.click_prohibition = false;
                Properties.Settings.Default.click_prohibition = false;

            }
            
        }

        private void mode_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_fomat_txt.Text = format_array[mode_CB.SelectedIndex];
            Form1.Form1Instance.display_format = display_fomat_txt.Text;
            Form1.Form1Instance.display_mode = mode_CB.SelectedIndex + 1;
            Properties.Settings.Default.mode = (mode_CB.SelectedIndex + 1).ToString();
        }

        private void display_fomat_txt_TextChanged(object sender, EventArgs e)
        {
            if (mode_CB.SelectedIndex == 4)
            {
                format_array[4] = display_fomat_txt.Text;
                Form1.Form1Instance.display_format = format_array[4];
                Properties.Settings.Default.display_format = display_fomat_txt.Text;                   
            }
            else
            {
                display_fomat_txt.Text = format_array[mode_CB.SelectedIndex];
            }

            display_area();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(config.FilePath);//configがあるファイルを開く
            }
            catch
            {
                file_open_error();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //指定したパスから親ディレクトリを取得
            try
            {
                System.Diagnostics.Process.Start(System.IO.Directory.GetParent(config.FilePath).ToString());
            }
            catch
            {
                file_open_error();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            close._close_dialog();
        }


        private void file_open_error()
        {
            file_open_error_label.Text = "No files have been created yet";
            file_open_error_label.Visible = true;
            timer1.Start();
        }
        int tim = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_label.Text = "timer_c = " + tim;
            tim++;
            if (tim > 200)
            {
                tim = 0;
                timer1.Stop();
                file_open_error_label.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked == true)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            display_area();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1.Form1Instance.BackgroundImage = null;
        }
    }
    
}