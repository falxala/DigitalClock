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
            this.OpacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.customSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.ModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mode1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mode2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mode3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mode42lineHhmmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label_size = new System.Windows.Forms.Label();
            this.label_mode = new System.Windows.Forms.Label();
            this.label_font = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpacityToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ModeToolStripMenuItem,
            this.toolStripMenuItem12,
            this.ColorToolStripMenuItem,
            this.toolStripMenuItem14,
            this.toolStripMenuItem13,
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 202);
            // 
            // OpacityToolStripMenuItem
            // 
            this.OpacityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.OpacityToolStripMenuItem.Name = "OpacityToolStripMenuItem";
            this.OpacityToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpacityToolStripMenuItem.Text = "Opacity";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem2.Text = "100%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem3.Text = "90%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem4.Text = "80%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem5.Text = "70%";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem6.Text = "60%";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem7.Text = "50%";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem8.Text = "40%";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem9.Text = "30%";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem10.Text = "20%";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem11.Text = "10%";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LargeToolStripMenuItem,
            this.MediumToolStripMenuItem,
            this.SmallToolStripMenuItem,
            this.toolStripSeparator1,
            this.customSizeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Size";
            // 
            // LargeToolStripMenuItem
            // 
            this.LargeToolStripMenuItem.Name = "LargeToolStripMenuItem";
            this.LargeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LargeToolStripMenuItem.Text = "Large";
            this.LargeToolStripMenuItem.Click += new System.EventHandler(this.LargeToolStripMenuItem_Click);
            // 
            // MediumToolStripMenuItem
            // 
            this.MediumToolStripMenuItem.Name = "MediumToolStripMenuItem";
            this.MediumToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MediumToolStripMenuItem.Text = "Medium ";
            this.MediumToolStripMenuItem.Click += new System.EventHandler(this.MediumToolStripMenuItem_Click);
            // 
            // SmallToolStripMenuItem
            // 
            this.SmallToolStripMenuItem.Name = "SmallToolStripMenuItem";
            this.SmallToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SmallToolStripMenuItem.Text = "Small";
            this.SmallToolStripMenuItem.Click += new System.EventHandler(this.SmallToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // customSizeToolStripMenuItem
            // 
            this.customSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.customSizeToolStripMenuItem.Name = "customSizeToolStripMenuItem";
            this.customSizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customSizeToolStripMenuItem.Text = "Custom Size";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.ToolTipText = "It should not be more than display resolution(10<=size<=500)";
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // ModeToolStripMenuItem
            // 
            this.ModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mode1ToolStripMenuItem,
            this.mode2ToolStripMenuItem,
            this.mode3ToolStripMenuItem,
            this.mode42lineHhmmToolStripMenuItem});
            this.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem";
            this.ModeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ModeToolStripMenuItem.Text = "Mode";
            // 
            // mode1ToolStripMenuItem
            // 
            this.mode1ToolStripMenuItem.Name = "mode1ToolStripMenuItem";
            this.mode1ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.mode1ToolStripMenuItem.Text = "mode1(Y/M/D h:m:s)";
            this.mode1ToolStripMenuItem.Click += new System.EventHandler(this.mode1ToolStripMenuItem_Click);
            // 
            // mode2ToolStripMenuItem
            // 
            this.mode2ToolStripMenuItem.Name = "mode2ToolStripMenuItem";
            this.mode2ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.mode2ToolStripMenuItem.Text = "mode2(2line Y/M/D h:m:s)";
            this.mode2ToolStripMenuItem.Click += new System.EventHandler(this.mode2ToolStripMenuItem_Click);
            // 
            // mode3ToolStripMenuItem
            // 
            this.mode3ToolStripMenuItem.Name = "mode3ToolStripMenuItem";
            this.mode3ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.mode3ToolStripMenuItem.Text = "mode3(hh:mm:ss)";
            this.mode3ToolStripMenuItem.Click += new System.EventHandler(this.mode3ToolStripMenuItem_Click);
            // 
            // mode42lineHhmmToolStripMenuItem
            // 
            this.mode42lineHhmmToolStripMenuItem.Name = "mode42lineHhmmToolStripMenuItem";
            this.mode42lineHhmmToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.mode42lineHhmmToolStripMenuItem.Text = "mode4(2line hh:mm))";
            this.mode42lineHhmmToolStripMenuItem.Click += new System.EventHandler(this.mode4ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem12.Text = "Font";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.ToolTipText = "test";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            this.toolStripComboBox1.DropDown += new System.EventHandler(this.toolStripComboBox1_DropDown);
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ColorToolStripMenuItem.Text = "Color";
            this.ColorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem14.Text = "Reset Position";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem14_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem13.Text = "Reset all";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Quit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Digital_Clock.Properties.Settings.Default, "fsize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label_size.Location = new System.Drawing.Point(12, 214);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(17, 12);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Digital_Clock.Properties.Settings.Default.FormColor;
            this.ClientSize = new System.Drawing.Size(834, 316);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label_font);
            this.Controls.Add(this.label_mode);
            this.Controls.Add(this.label_size);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Digital_Clock.Properties.Settings.Default, "FormColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Digital_Clock.Properties.Settings.Default, "Form1Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = global::Digital_Clock.Properties.Settings.Default.Form1Location;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpacityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SmallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mode1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mode2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mode3ToolStripMenuItem;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Label label_mode;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Label label_font;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem mode42lineHhmmToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem customSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
    }
}

