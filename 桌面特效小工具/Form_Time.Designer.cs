namespace clock
{
    partial class Form_Time
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Time));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu_colck = new CCWin.SkinControl.SkinContextMenuStrip();
            this.返回主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.炫彩皮肤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.扁平化时钟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.金属风格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.闹钟样式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.软件源码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_colck.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "桌面时钟";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
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
            this.主页ToolStripMenuItem,
            this.设置中心ToolStripMenuItem,
            this.小组ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.软件源码ToolStripMenuItem});
            this.menu_colck.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_colck.Name = "menu_setting";
            this.menu_colck.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu_colck.Size = new System.Drawing.Size(120, 145);
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
            this.返回主界面ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.返回主界面ToolStripMenuItem.Text = "返回主界面";
            this.返回主界面ToolStripMenuItem.Click += new System.EventHandler(this.返回主界面ToolStripMenuItem_Click);
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.AutoSize = false;
            this.主页ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.炫彩皮肤ToolStripMenuItem,
            this.扁平化时钟ToolStripMenuItem,
            this.金属风格ToolStripMenuItem,
            this.闹钟样式ToolStripMenuItem});
            this.主页ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("主页ToolStripMenuItem.Image")));
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.主页ToolStripMenuItem.Text = "时钟皮肤";
            this.主页ToolStripMenuItem.Click += new System.EventHandler(this.主页ToolStripMenuItem_Click);
            // 
            // 炫彩皮肤ToolStripMenuItem
            // 
            this.炫彩皮肤ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("炫彩皮肤ToolStripMenuItem.Image")));
            this.炫彩皮肤ToolStripMenuItem.Name = "炫彩皮肤ToolStripMenuItem";
            this.炫彩皮肤ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.炫彩皮肤ToolStripMenuItem.Text = "炫彩皮肤";
            this.炫彩皮肤ToolStripMenuItem.Click += new System.EventHandler(this.炫彩皮肤ToolStripMenuItem_Click);
            // 
            // 扁平化时钟ToolStripMenuItem
            // 
            this.扁平化时钟ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("扁平化时钟ToolStripMenuItem.Image")));
            this.扁平化时钟ToolStripMenuItem.Name = "扁平化时钟ToolStripMenuItem";
            this.扁平化时钟ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.扁平化时钟ToolStripMenuItem.Text = "扁平化时钟";
            this.扁平化时钟ToolStripMenuItem.Click += new System.EventHandler(this.扁平化时钟ToolStripMenuItem_Click);
            // 
            // 金属风格ToolStripMenuItem
            // 
            this.金属风格ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("金属风格ToolStripMenuItem.Image")));
            this.金属风格ToolStripMenuItem.Name = "金属风格ToolStripMenuItem";
            this.金属风格ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.金属风格ToolStripMenuItem.Text = "机械风格";
            this.金属风格ToolStripMenuItem.Click += new System.EventHandler(this.金属风格ToolStripMenuItem_Click);
            // 
            // 闹钟样式ToolStripMenuItem
            // 
            this.闹钟样式ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("闹钟样式ToolStripMenuItem.Image")));
            this.闹钟样式ToolStripMenuItem.Name = "闹钟样式ToolStripMenuItem";
            this.闹钟样式ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.闹钟样式ToolStripMenuItem.Text = "闹钟样式";
            this.闹钟样式ToolStripMenuItem.Click += new System.EventHandler(this.闹钟样式ToolStripMenuItem_Click);
            // 
            // 设置中心ToolStripMenuItem
            // 
            this.设置中心ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.设置中心ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("设置中心ToolStripMenuItem.Image")));
            this.设置中心ToolStripMenuItem.Name = "设置中心ToolStripMenuItem";
            this.设置中心ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.设置中心ToolStripMenuItem.Text = "总在最前";
            this.设置中心ToolStripMenuItem.Click += new System.EventHandler(this.设置中心ToolStripMenuItem_Click);
            // 
            // 小组ToolStripMenuItem
            // 
            this.小组ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("小组ToolStripMenuItem.Image")));
            this.小组ToolStripMenuItem.Name = "小组ToolStripMenuItem";
            this.小组ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.小组ToolStripMenuItem.Text = "透过鼠标";
            this.小组ToolStripMenuItem.Click += new System.EventHandler(this.小组ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "最小化";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 软件源码ToolStripMenuItem
            // 
            this.软件源码ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("软件源码ToolStripMenuItem.Image")));
            this.软件源码ToolStripMenuItem.Name = "软件源码ToolStripMenuItem";
            this.软件源码ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.软件源码ToolStripMenuItem.Text = "退出软件";
            this.软件源码ToolStripMenuItem.Click += new System.EventHandler(this.软件源码ToolStripMenuItem_Click);
            // 
            // Form_Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.ContextMenuStrip = this.menu_colck;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Time_MouseMove);
            this.menu_colck.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private CCWin.SkinControl.SkinContextMenuStrip menu_colck;
        private System.Windows.Forms.ToolStripMenuItem 主页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 炫彩皮肤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 扁平化时钟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 金属风格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 闹钟样式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软件源码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 返回主界面ToolStripMenuItem;
    }
}

