namespace Digital_Clock
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_opa_100 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_opa_90 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_opa_80 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_opa_70 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_opa_60 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_opa_50 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_opa_40 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_opa_30 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_opa_20 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_opa_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_size_L = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_size_M = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_size_S = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsm_size_custom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_customsizeTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
            this.mode1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mode2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mode3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mode4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_font = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_fontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.tsm_color = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingFIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTheFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTheFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label_size = new System.Windows.Forms.Label();
            this.label_mode = new System.Windows.Forms.Label();
            this.label_font = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.advanceSettingToolStripMenuItem,
            this.settingFIleToolStripMenuItem,
            this.toolStripMenuItem14,
            this.toolStripMenuItem13,
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 136);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem15,
            this.toolStripMenuItem26,
            this.toolStripMenuItem31,
            this.tsm_font,
            this.tsm_color});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_opa_100,
            this.tsm_opa_90,
            this.tsm_opa_80,
            this.tsm_opa_70,
            this.tsm_opa_60,
            this.tsm_opa_50,
            this.tsm_opa_40,
            this.tsm_opa_30,
            this.tsm_opa_20,
            this.tsm_opa_10});
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItem15.Text = "Opacity";
            // 
            // tsm_opa_100
            // 
            this.tsm_opa_100.Name = "tsm_opa_100";
            this.tsm_opa_100.Size = new System.Drawing.Size(102, 22);
            this.tsm_opa_100.Text = "100%";
            this.tsm_opa_100.Click += new System.EventHandler(this.tsm_opa100_Click);
            // 
            // tsm_opa_90
            // 
            this.tsm_opa_90.Name = "tsm_opa_90";
            this.tsm_opa_90.Size = new System.Drawing.Size(102, 22);
            this.tsm_opa_90.Text = "90%";
            this.tsm_opa_90.Click += new System.EventHandler(this.tsm_opa90__Click);
            // 
            // tsm_opa_80
            // 
            this.tsm_opa_80.Name = "tsm_opa_80";
            this.tsm_opa_80.Size = new System.Drawing.Size(102, 22);
            this.tsm_opa_80.Text = "80%";
            this.tsm_opa_80.Click += new System.EventHandler(this.tsm_opa80__Click);
            // 
            // tsm_opa_70
            // 
            this.tsm_opa_70.Name = "tsm_opa_70";
            this.tsm_opa_70.Size = new System.Drawing.Size(102, 22);
            this.tsm_opa_70.Text = "70%";
            this.tsm_opa_70.Click += new System.EventHandler(this.tsm_opa70__Click);
            // 
            // tsm_opa_60
            // 
            this.tsm_opa_60.Name = "tsm_opa_60";
            this.tsm_opa_60.Size = new System.Drawing.Size(102, 22);
            this.tsm_opa_60.Text = "60%";
            this.tsm_opa_60.Click += new System.EventHandler(this.tsm_opa60__Click);
            // 
            // tsm_opa_50
            // 
            this.tsm_opa_50.Name = "tsm_opa_50";
            this.tsm_opa_50.Size = new System.Drawing.Size(102, 22);
            this.tsm_opa_50.Text = "50%";
            this.tsm_opa_50.Click += new System.EventHandler(this.tsm_opa50__Click);
            // 
            // tsm_opa_40
            // 
            this.tsm_opa_40.Name = "tsm_opa_40";
            this.tsm_opa_40.Size = new System.Drawing.Size(102, 22);
            this.tsm_opa_40.Text = "40%";
            this.tsm_opa_40.Click += new System.EventHandler(this.tsm_opa40__Click);
            // 
            // tsm_opa_30
            // 
            this.tsm_opa_30.Name = "tsm_opa_30";
            this.tsm_opa_30.Size = new System.Drawing.Size(102, 22);
            this.tsm_opa_30.Text = "30%";
            this.tsm_opa_30.Click += new System.EventHandler(this.tsm_opa30__Click);
            // 
            // tsm_opa_20
            // 
            this.tsm_opa_20.Name = "tsm_opa_20";
            this.tsm_opa_20.Size = new System.Drawing.Size(102, 22);
            this.tsm_opa_20.Text = "20%";
            this.tsm_opa_20.Click += new System.EventHandler(this.tsm_opa20__Click);
            // 
            // tsm_opa_10
            // 
            this.tsm_opa_10.Name = "tsm_opa_10";
            this.tsm_opa_10.Size = new System.Drawing.Size(102, 22);
            this.tsm_opa_10.Text = "10%";
            this.tsm_opa_10.Click += new System.EventHandler(this.tsm_opa10__Click);
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_size_L,
            this.tsm_size_M,
            this.tsm_size_S,
            this.toolStripSeparator2,
            this.tsm_size_custom});
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItem26.Text = "Size";
            // 
            // tsm_size_L
            // 
            this.tsm_size_L.Name = "tsm_size_L";
            this.tsm_size_L.Size = new System.Drawing.Size(137, 22);
            this.tsm_size_L.Text = "Large";
            this.tsm_size_L.Click += new System.EventHandler(this.LargeToolStripMenuItem_Click);
            // 
            // tsm_size_M
            // 
            this.tsm_size_M.Name = "tsm_size_M";
            this.tsm_size_M.Size = new System.Drawing.Size(137, 22);
            this.tsm_size_M.Text = "Medium ";
            this.tsm_size_M.Click += new System.EventHandler(this.MediumToolStripMenuItem_Click);
            // 
            // tsm_size_S
            // 
            this.tsm_size_S.Name = "tsm_size_S";
            this.tsm_size_S.Size = new System.Drawing.Size(137, 22);
            this.tsm_size_S.Text = "Small";
            this.tsm_size_S.Click += new System.EventHandler(this.SmallToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(134, 6);
            // 
            // tsm_size_custom
            // 
            this.tsm_size_custom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_customsizeTextBox});
            this.tsm_size_custom.Name = "tsm_size_custom";
            this.tsm_size_custom.Size = new System.Drawing.Size(137, 22);
            this.tsm_size_custom.Text = "Custom Size";
            // 
            // tsm_customsizeTextBox
            // 
            this.tsm_customsizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsm_customsizeTextBox.Name = "tsm_customsizeTextBox";
            this.tsm_customsizeTextBox.Size = new System.Drawing.Size(100, 23);
            this.tsm_customsizeTextBox.ToolTipText = "It should not be more than display resolution(10<=size<=500)";
            this.tsm_customsizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // toolStripMenuItem31
            // 
            this.toolStripMenuItem31.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mode1,
            this.mode2,
            this.mode3,
            this.mode4});
            this.toolStripMenuItem31.Name = "toolStripMenuItem31";
            this.toolStripMenuItem31.Size = new System.Drawing.Size(115, 22);
            this.toolStripMenuItem31.Text = "Mode";
            // 
            // mode1
            // 
            this.mode1.Name = "mode1";
            this.mode1.Size = new System.Drawing.Size(213, 22);
            this.mode1.Text = "mode1(Y/M/D h:m:s)";
            this.mode1.Click += new System.EventHandler(this.mode1ToolStripMenuItem_Click);
            // 
            // mode2
            // 
            this.mode2.Name = "mode2";
            this.mode2.Size = new System.Drawing.Size(213, 22);
            this.mode2.Text = "mode2(2line Y/M/D h:m:s)";
            this.mode2.Click += new System.EventHandler(this.mode2ToolStripMenuItem_Click);
            // 
            // mode3
            // 
            this.mode3.Name = "mode3";
            this.mode3.Size = new System.Drawing.Size(213, 22);
            this.mode3.Text = "mode3(hh:mm:ss)";
            this.mode3.Click += new System.EventHandler(this.mode3ToolStripMenuItem_Click);
            // 
            // mode4
            // 
            this.mode4.Name = "mode4";
            this.mode4.Size = new System.Drawing.Size(213, 22);
            this.mode4.Text = "mode4(2line hh:mm))";
            this.mode4.Click += new System.EventHandler(this.mode4ToolStripMenuItem_Click);
            // 
            // tsm_font
            // 
            this.tsm_font.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_fontComboBox});
            this.tsm_font.Name = "tsm_font";
            this.tsm_font.Size = new System.Drawing.Size(115, 22);
            this.tsm_font.Text = "Font";
            // 
            // tsm_fontComboBox
            // 
            this.tsm_fontComboBox.Name = "tsm_fontComboBox";
            this.tsm_fontComboBox.Size = new System.Drawing.Size(121, 23);
            this.tsm_fontComboBox.ToolTipText = "test";
            this.tsm_fontComboBox.DropDown += new System.EventHandler(this.tsm_font_DropDown);
            this.tsm_fontComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // tsm_color
            // 
            this.tsm_color.Name = "tsm_color";
            this.tsm_color.Size = new System.Drawing.Size(115, 22);
            this.tsm_color.Text = "Color";
            this.tsm_color.Click += new System.EventHandler(this.tsm_coror_Click);
            // 
            // advanceSettingToolStripMenuItem
            // 
            this.advanceSettingToolStripMenuItem.Name = "advanceSettingToolStripMenuItem";
            this.advanceSettingToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.advanceSettingToolStripMenuItem.Text = "Advance Setting";
            this.advanceSettingToolStripMenuItem.Click += new System.EventHandler(this.advanceSettingToolStripMenuItem_Click);
            // 
            // settingFIleToolStripMenuItem
            // 
            this.settingFIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTheFileToolStripMenuItem,
            this.viewTheFolderToolStripMenuItem});
            this.settingFIleToolStripMenuItem.Name = "settingFIleToolStripMenuItem";
            this.settingFIleToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.settingFIleToolStripMenuItem.Text = "Setting file";
            // 
            // viewTheFileToolStripMenuItem
            // 
            this.viewTheFileToolStripMenuItem.Name = "viewTheFileToolStripMenuItem";
            this.viewTheFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.viewTheFileToolStripMenuItem.Text = "View the file";
            this.viewTheFileToolStripMenuItem.Click += new System.EventHandler(this.View_the_fileToolStripMenuItem_Click);
            // 
            // viewTheFolderToolStripMenuItem
            // 
            this.viewTheFolderToolStripMenuItem.Name = "viewTheFolderToolStripMenuItem";
            this.viewTheFolderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.viewTheFolderToolStripMenuItem.Text = "View the folder";
            this.viewTheFolderToolStripMenuItem.Click += new System.EventHandler(this.ViewTheFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem14.Text = "Reset Position";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem13.Text = "Reset all setting";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ExitToolStripMenuItem.Text = "Quit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Digital_Clock.Properties.Settings.Default, "fsize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label_size.Location = new System.Drawing.Point(12, 214);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(23, 12);
            this.label_size.TabIndex = 1;
            this.label_size.Text = global::Digital_Clock.Properties.Settings.Default.fsize;
            this.label_size.Visible = false;
            // 
            // label_mode
            // 
            this.label_mode.AutoSize = true;
            this.label_mode.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Digital_Clock.Properties.Settings.Default, "mode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label_mode.Location = new System.Drawing.Point(12, 227);
            this.label_mode.Name = "label_mode";
            this.label_mode.Size = new System.Drawing.Size(11, 12);
            this.label_mode.TabIndex = 2;
            this.label_mode.Text = global::Digital_Clock.Properties.Settings.Default.mode;
            this.label_mode.Visible = false;
            // 
            // label_font
            // 
            this.label_font.AutoSize = true;
            this.label_font.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Digital_Clock.Properties.Settings.Default, "font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label_font.Location = new System.Drawing.Point(12, 241);
            this.label_font.Name = "label_font";
            this.label_font.Size = new System.Drawing.Size(29, 12);
            this.label_font.TabIndex = 3;
            this.label_font.Text = global::Digital_Clock.Properties.Settings.Default.font;
            this.label_font.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Digital Clock";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 316);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Digital_Clock.Properties.Settings.Default.FormColor;
            this.BackgroundImage = global::Digital_Clock.Properties.Resources.wallpaper_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(834, 316);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_font);
            this.Controls.Add(this.label_mode);
            this.Controls.Add(this.label_size);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Digital_Clock.Properties.Settings.Default, "FormColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Digital_Clock.Properties.Settings.Default, "Form1Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = global::Digital_Clock.Properties.Settings.Default.Form1Location;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Label label_mode;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Label label_font;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem settingFIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTheFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTheFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem tsm_opa_100;
        private System.Windows.Forms.ToolStripMenuItem tsm_opa_90;
        private System.Windows.Forms.ToolStripMenuItem tsm_opa_80;
        private System.Windows.Forms.ToolStripMenuItem tsm_opa_70;
        private System.Windows.Forms.ToolStripMenuItem tsm_opa_60;
        private System.Windows.Forms.ToolStripMenuItem tsm_opa_50;
        private System.Windows.Forms.ToolStripMenuItem tsm_opa_40;
        private System.Windows.Forms.ToolStripMenuItem tsm_opa_30;
        private System.Windows.Forms.ToolStripMenuItem tsm_opa_20;
        private System.Windows.Forms.ToolStripMenuItem tsm_opa_10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ToolStripMenuItem tsm_size_L;
        private System.Windows.Forms.ToolStripMenuItem tsm_size_M;
        private System.Windows.Forms.ToolStripMenuItem tsm_size_S;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsm_size_custom;
        private System.Windows.Forms.ToolStripTextBox tsm_customsizeTextBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem31;
        private System.Windows.Forms.ToolStripMenuItem mode1;
        private System.Windows.Forms.ToolStripMenuItem mode2;
        private System.Windows.Forms.ToolStripMenuItem mode3;
        private System.Windows.Forms.ToolStripMenuItem mode4;
        private System.Windows.Forms.ToolStripMenuItem tsm_font;
        private System.Windows.Forms.ToolStripComboBox tsm_fontComboBox;
        private System.Windows.Forms.ToolStripMenuItem tsm_color;
        private System.Windows.Forms.ToolStripMenuItem advanceSettingToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

