namespace Digital_Clock
{
    partial class AdvanceSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.font = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.fontsize_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.font_style_cb = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.opacity_label = new System.Windows.Forms.Label();
            this.display_CB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Display_area_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.display_fomat_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mode_CB = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.file_open_error_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.drawing_label = new System.Windows.Forms.Label();
            this.margin_label = new System.Windows.Forms.Label();
            this.timer_label = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.borderingcolor_pictureBox = new System.Windows.Forms.PictureBox();
            this.fcolor_pictureBox = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontsize_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderingcolor_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fcolor_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // font
            // 
            this.font.FormattingEnabled = true;
            this.font.Location = new System.Drawing.Point(27, 24);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(175, 20);
            this.font.TabIndex = 0;
            this.font.SelectedIndexChanged += new System.EventHandler(this.font_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(29, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Bordering";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bordering  thickness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Font Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bordering Color";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(27, 76);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fontsize_numericUpDown
            // 
            this.fontsize_numericUpDown.Location = new System.Drawing.Point(335, 24);
            this.fontsize_numericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.fontsize_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fontsize_numericUpDown.Name = "fontsize_numericUpDown";
            this.fontsize_numericUpDown.Size = new System.Drawing.Size(120, 19);
            this.fontsize_numericUpDown.TabIndex = 13;
            this.fontsize_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fontsize_numericUpDown.ValueChanged += new System.EventHandler(this.fontsize_numericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Font Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "Font Style";
            // 
            // font_style_cb
            // 
            this.font_style_cb.FormattingEnabled = true;
            this.font_style_cb.Location = new System.Drawing.Point(208, 24);
            this.font_style_cb.Name = "font_style_cb";
            this.font_style_cb.Size = new System.Drawing.Size(121, 20);
            this.font_style_cb.TabIndex = 14;
            this.font_style_cb.SelectedIndexChanged += new System.EventHandler(this.font_style_cb_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(208, 213);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(241, 45);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "Opacity";
            // 
            // opacity_label
            // 
            this.opacity_label.AutoSize = true;
            this.opacity_label.Location = new System.Drawing.Point(255, 198);
            this.opacity_label.Name = "opacity_label";
            this.opacity_label.Size = new System.Drawing.Size(29, 12);
            this.opacity_label.TabIndex = 18;
            this.opacity_label.Text = "100%";
            // 
            // display_CB
            // 
            this.display_CB.FormattingEnabled = true;
            this.display_CB.Location = new System.Drawing.Point(27, 204);
            this.display_CB.Name = "display_CB";
            this.display_CB.Size = new System.Drawing.Size(121, 20);
            this.display_CB.TabIndex = 19;
            this.display_CB.SelectedIndexChanged += new System.EventHandler(this.display_CB_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "Display";
            // 
            // Display_area_label
            // 
            this.Display_area_label.AutoSize = true;
            this.Display_area_label.Location = new System.Drawing.Point(3, 62);
            this.Display_area_label.Name = "Display_area_label";
            this.Display_area_label.Size = new System.Drawing.Size(71, 36);
            this.Display_area_label.TabIndex = 21;
            this.Display_area_label.Text = "Display Area\r\nw = xxx\r\nh = xxx ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "debug";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 36);
            this.label10.TabIndex = 23;
            this.label10.Text = "Primary Display\r\nw = xxx\r\nh = xxx ";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(27, 230);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 16);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Click Prohibition";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // display_fomat_txt
            // 
            this.display_fomat_txt.Location = new System.Drawing.Point(208, 133);
            this.display_fomat_txt.Multiline = true;
            this.display_fomat_txt.Name = "display_fomat_txt";
            this.display_fomat_txt.Size = new System.Drawing.Size(247, 50);
            this.display_fomat_txt.TabIndex = 25;
            this.display_fomat_txt.TextChanged += new System.EventHandler(this.display_fomat_txt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(206, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "Display Format";
            // 
            // mode_CB
            // 
            this.mode_CB.FormattingEnabled = true;
            this.mode_CB.Location = new System.Drawing.Point(27, 133);
            this.mode_CB.Name = "mode_CB";
            this.mode_CB.Size = new System.Drawing.Size(175, 20);
            this.mode_CB.TabIndex = 27;
            this.mode_CB.SelectedIndexChanged += new System.EventHandler(this.mode_CB_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "View the file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 286);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "View the folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(489, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Close the application";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // file_open_error_label
            // 
            this.file_open_error_label.AutoSize = true;
            this.file_open_error_label.ForeColor = System.Drawing.Color.Red;
            this.file_open_error_label.Location = new System.Drawing.Point(308, 297);
            this.file_open_error_label.Name = "file_open_error_label";
            this.file_open_error_label.Size = new System.Drawing.Size(29, 12);
            this.file_open_error_label.TabIndex = 31;
            this.file_open_error_label.Text = "error";
            this.file_open_error_label.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 12);
            this.label12.TabIndex = 32;
            this.label12.Text = "Config";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.drawing_label);
            this.panel1.Controls.Add(this.margin_label);
            this.panel1.Controls.Add(this.timer_label);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Display_area_label);
            this.panel1.Location = new System.Drawing.Point(489, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 200);
            this.panel1.TabIndex = 33;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(5, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // drawing_label
            // 
            this.drawing_label.AutoSize = true;
            this.drawing_label.Location = new System.Drawing.Point(3, 134);
            this.drawing_label.Name = "drawing_label";
            this.drawing_label.Size = new System.Drawing.Size(44, 12);
            this.drawing_label.TabIndex = 26;
            this.drawing_label.Text = "drawing";
            // 
            // margin_label
            // 
            this.margin_label.AutoSize = true;
            this.margin_label.Location = new System.Drawing.Point(3, 98);
            this.margin_label.Name = "margin_label";
            this.margin_label.Size = new System.Drawing.Size(47, 36);
            this.margin_label.TabIndex = 25;
            this.margin_label.Text = "margin\r\nw = xxx\r\nh = xxx ";
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Location = new System.Drawing.Point(3, 180);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(71, 12);
            this.timer_label.TabIndex = 24;
            this.timer_label.Text = "timer_c = xx ";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(489, 230);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 16);
            this.checkBox3.TabIndex = 34;
            this.checkBox3.Text = "debug";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // borderingcolor_pictureBox
            // 
            this.borderingcolor_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.borderingcolor_pictureBox.Location = new System.Drawing.Point(208, 76);
            this.borderingcolor_pictureBox.Name = "borderingcolor_pictureBox";
            this.borderingcolor_pictureBox.Size = new System.Drawing.Size(39, 19);
            this.borderingcolor_pictureBox.TabIndex = 7;
            this.borderingcolor_pictureBox.TabStop = false;
            this.borderingcolor_pictureBox.Click += new System.EventHandler(this.borderingcolor_pictureBox_Click);
            // 
            // fcolor_pictureBox
            // 
            this.fcolor_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fcolor_pictureBox.Location = new System.Drawing.Point(347, 76);
            this.fcolor_pictureBox.Name = "fcolor_pictureBox";
            this.fcolor_pictureBox.Size = new System.Drawing.Size(39, 19);
            this.fcolor_pictureBox.TabIndex = 6;
            this.fcolor_pictureBox.TabStop = false;
            this.fcolor_pictureBox.Click += new System.EventHandler(this.fcolor_pictureBox_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(29, 350);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 23);
            this.button6.TabIndex = 35;
            this.button6.Text = "form1.image.dispose()";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AdvanceSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 385);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.file_open_error_label);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mode_CB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.display_fomat_txt);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.display_CB);
            this.Controls.Add(this.opacity_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.font_style_cb);
            this.Controls.Add(this.fontsize_numericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.borderingcolor_pictureBox);
            this.Controls.Add(this.fcolor_pictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.font);
            this.Name = "AdvanceSetting";
            this.Text = "AdvanceSetting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdvanceSetting_FormClosing);
            this.Load += new System.EventHandler(this.AdvanceSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontsize_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderingcolor_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fcolor_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox font;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox fcolor_pictureBox;
        private System.Windows.Forms.PictureBox borderingcolor_pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown fontsize_numericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox font_style_cb;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label opacity_label;
        private System.Windows.Forms.ComboBox display_CB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Display_area_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox display_fomat_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox mode_CB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label file_open_error_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Label margin_label;
        private System.Windows.Forms.Label drawing_label;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}