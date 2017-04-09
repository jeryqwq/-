namespace 桌面特效小工具
{
    partial class Form_NumClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NumClock));
            this.lb_hour = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.lb_second = new CCWin.SkinControl.SkinLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.menu_colck = new CCWin.SkinControl.SkinContextMenuStrip();
            this.返回主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_weather2 = new System.Windows.Forms.Label();
            this.lb_s = new CCWin.SkinControl.SkinLabel();
            this.menu_colck.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_hour
            // 
            this.lb_hour.AutoSize = true;
            this.lb_hour.BackColor = System.Drawing.Color.Transparent;
            this.lb_hour.BorderColor = System.Drawing.Color.Transparent;
            this.lb_hour.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_hour.Location = new System.Drawing.Point(24, 8);
            this.lb_hour.Name = "lb_hour";
            this.lb_hour.Size = new System.Drawing.Size(111, 83);
            this.lb_hour.TabIndex = 0;
            this.lb_hour.Text = "00";
            this.lb_hour.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_hour_MouseDown);
            this.lb_hour.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_hour_MouseMove);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(119, 5);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(50, 83);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = ":";
            // 
            // lb_second
            // 
            this.lb_second.AutoSize = true;
            this.lb_second.BackColor = System.Drawing.Color.Transparent;
            this.lb_second.BorderColor = System.Drawing.Color.Transparent;
            this.lb_second.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_second.Location = new System.Drawing.Point(145, 8);
            this.lb_second.Name = "lb_second";
            this.lb_second.Size = new System.Drawing.Size(111, 83);
            this.lb_second.TabIndex = 2;
            this.lb_second.Text = "00";
            this.lb_second.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_second_MouseDown);
            this.lb_second.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_second_MouseMove);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.Blue;
            this.skinLabel1.Location = new System.Drawing.Point(1, 2);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 4;
            this.skinLabel1.Text = "切换城市";
            this.skinLabel1.Click += new System.EventHandler(this.skinLabel1_Click);
            // 
            // menu_colck
            // 
            this.menu_colck.Arrow = System.Drawing.SystemColors.Highlight;
            this.menu_colck.AutoSize = false;
            this.menu_colck.Back = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_colck.BackRadius = 4;
            this.menu_colck.Base = System.Drawing.SystemColors.Highlight;
            this.menu_colck.DropDownImageSeparator = System.Drawing.SystemColors.Highlight;
            this.menu_colck.Fore = System.Drawing.Color.Black;
            this.menu_colck.HoverFore = System.Drawing.Color.White;
            this.menu_colck.ItemAnamorphosis = false;
            this.menu_colck.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_colck.ItemBorderShow = true;
            this.menu_colck.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_colck.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_colck.ItemRadius = 10;
            this.menu_colck.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu_colck.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回主界面ToolStripMenuItem,
            this.小组ToolStripMenuItem,
            this.设置中心ToolStripMenuItem});
            this.menu_colck.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_colck.Name = "menu_setting";
            this.menu_colck.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu_colck.Size = new System.Drawing.Size(120, 80);
            this.menu_colck.SkinAllColor = true;
            this.menu_colck.TitleAnamorphosis = false;
            this.menu_colck.TitleColor = System.Drawing.Color.White;
            this.menu_colck.TitleRadius = 10;
            this.menu_colck.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 返回主界面ToolStripMenuItem
            // 
            this.返回主界面ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("返回主界面ToolStripMenuItem.Image")));
            this.返回主界面ToolStripMenuItem.Name = "返回主界面ToolStripMenuItem";
            this.返回主界面ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.返回主界面ToolStripMenuItem.Text = "返回主界面";
            this.返回主界面ToolStripMenuItem.Click += new System.EventHandler(this.返回主界面ToolStripMenuItem_Click);
            // 
            // 小组ToolStripMenuItem
            // 
            this.小组ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("小组ToolStripMenuItem.Image")));
            this.小组ToolStripMenuItem.Name = "小组ToolStripMenuItem";
            this.小组ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.小组ToolStripMenuItem.Text = "经典时钟";
            this.小组ToolStripMenuItem.Click += new System.EventHandler(this.小组ToolStripMenuItem_Click);
            // 
            // 设置中心ToolStripMenuItem
            // 
            this.设置中心ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.设置中心ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("设置中心ToolStripMenuItem.Image")));
            this.设置中心ToolStripMenuItem.Name = "设置中心ToolStripMenuItem";
            this.设置中心ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.设置中心ToolStripMenuItem.Text = "总在最前";
            // 
            // lb_weather2
            // 
            this.lb_weather2.BackColor = System.Drawing.Color.Transparent;
            this.lb_weather2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_weather2.ForeColor = System.Drawing.Color.White;
            this.lb_weather2.Location = new System.Drawing.Point(19, 78);
            this.lb_weather2.Name = "lb_weather2";
            this.lb_weather2.Size = new System.Drawing.Size(237, 67);
            this.lb_weather2.TabIndex = 8;
            this.lb_weather2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_weather2_MouseDown);
            this.lb_weather2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb_weather2_MouseMove);
            // 
            // lb_s
            // 
            this.lb_s.AutoSize = true;
            this.lb_s.BackColor = System.Drawing.Color.Transparent;
            this.lb_s.BorderColor = System.Drawing.Color.Transparent;
            this.lb_s.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_s.Location = new System.Drawing.Point(232, 53);
            this.lb_s.Name = "lb_s";
            this.lb_s.Size = new System.Drawing.Size(36, 27);
            this.lb_s.TabIndex = 9;
            this.lb_s.Text = "00";
            // 
            // Form_NumClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(271, 149);
            this.ContextMenuStrip = this.menu_colck;
            this.ControlBox = false;
            this.Controls.Add(this.lb_s);
            this.Controls.Add(this.lb_weather2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.lb_second);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.lb_hour);
            this.Name = "Form_NumClock";
            this.ShowDrawIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.Form_NumClock_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_NumClock_MouseMove);
            this.menu_colck.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel lb_hour;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel lb_second;
        private System.Windows.Forms.Timer timer;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinContextMenuStrip menu_colck;
        private System.Windows.Forms.ToolStripMenuItem 返回主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小组ToolStripMenuItem;
        private System.Windows.Forms.Label lb_weather2;
        private CCWin.SkinControl.SkinLabel lb_s;
    }
}