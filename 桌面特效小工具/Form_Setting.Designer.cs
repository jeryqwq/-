namespace 桌面特效小工具
{
    partial class Form_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Setting));
            this.panel_tabcontrol = new CCWin.SkinControl.SkinPanel();
            this.tab_music = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.cb_CloseTeskImg = new CCWin.SkinControl.SkinCheckBox();
            this.cb_locked = new CCWin.SkinControl.SkinCheckBox();
            this.cb_prected = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBox1 = new CCWin.SkinControl.SkinCheckBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.num_LockedTime = new CCWin.SkinControl.SkinNumericUpDown();
            this.num_loop = new CCWin.SkinControl.SkinNumericUpDown();
            this.check_AutoLight = new CCWin.SkinControl.SkinCheckBox();
            this.trabar_light = new CCWin.SkinControl.SkinTrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.num_usernodo = new CCWin.SkinControl.SkinNumericUpDown();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.btn_Close = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.btn_mainpage = new CCWin.SkinControl.SkinButton();
            this.panel_tabcontrol.SuspendLayout();
            this.tab_music.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_LockedTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_loop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabar_light)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_usernodo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_tabcontrol
            // 
            this.panel_tabcontrol.BackColor = System.Drawing.Color.Transparent;
            this.panel_tabcontrol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_tabcontrol.Controls.Add(this.tab_music);
            this.panel_tabcontrol.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_tabcontrol.DownBack = null;
            this.panel_tabcontrol.Location = new System.Drawing.Point(-2, 46);
            this.panel_tabcontrol.MouseBack = null;
            this.panel_tabcontrol.Name = "panel_tabcontrol";
            this.panel_tabcontrol.NormlBack = null;
            this.panel_tabcontrol.Size = new System.Drawing.Size(640, 352);
            this.panel_tabcontrol.TabIndex = 2;
            // 
            // tab_music
            // 
            this.tab_music.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tab_music.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tab_music.ArrowBaseColor = System.Drawing.Color.Transparent;
            this.tab_music.ArrowBorderColor = System.Drawing.Color.Transparent;
            this.tab_music.ArrowColor = System.Drawing.Color.Transparent;
            this.tab_music.BackColor = System.Drawing.Color.White;
            this.tab_music.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tab_music.Controls.Add(this.skinTabPage1);
            this.tab_music.Controls.Add(this.skinTabPage2);
            this.tab_music.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_music.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tab_music.HeadBack = null;
            this.tab_music.ImgSize = new System.Drawing.Size(15, 15);
            this.tab_music.ImgTxtOffset = new System.Drawing.Point(20, 0);
            this.tab_music.ImgTxtSpace = 12;
            this.tab_music.ItemSize = new System.Drawing.Size(30, 130);
            this.tab_music.Location = new System.Drawing.Point(0, 0);
            this.tab_music.Multiline = true;
            this.tab_music.Name = "tab_music";
            this.tab_music.Padding = new System.Drawing.Point(0, 0);
            this.tab_music.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tab_music.PageArrowDown")));
            this.tab_music.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tab_music.PageArrowHover")));
            this.tab_music.PageBaseColor = System.Drawing.Color.Transparent;
            this.tab_music.PageBorderColor = System.Drawing.Color.Transparent;
            this.tab_music.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tab_music.PageCloseHover")));
            this.tab_music.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tab_music.PageCloseNormal")));
            this.tab_music.PageDown = ((System.Drawing.Image)(resources.GetObject("tab_music.PageDown")));
            this.tab_music.PageHover = ((System.Drawing.Image)(resources.GetObject("tab_music.PageHover")));
            this.tab_music.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tab_music.PageNorml = null;
            this.tab_music.PageNormlTxtColor = System.Drawing.Color.DimGray;
            this.tab_music.PageTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab_music.SelectedIndex = 0;
            this.tab_music.Size = new System.Drawing.Size(638, 350);
            this.tab_music.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_music.TabIndex = 4;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.White;
            this.skinTabPage1.Controls.Add(this.skinLabel7);
            this.skinTabPage1.Controls.Add(this.skinLabel6);
            this.skinTabPage1.Controls.Add(this.skinLabel5);
            this.skinTabPage1.Controls.Add(this.skinLabel4);
            this.skinTabPage1.Controls.Add(this.skinLabel3);
            this.skinTabPage1.Controls.Add(this.skinLabel2);
            this.skinTabPage1.Controls.Add(this.skinLabel1);
            this.skinTabPage1.Controls.Add(this.cb_CloseTeskImg);
            this.skinTabPage1.Controls.Add(this.cb_locked);
            this.skinTabPage1.Controls.Add(this.cb_prected);
            this.skinTabPage1.Controls.Add(this.skinCheckBox1);
            this.skinTabPage1.Controls.Add(this.tb_pwd);
            this.skinTabPage1.Controls.Add(this.num_LockedTime);
            this.skinTabPage1.Controls.Add(this.num_loop);
            this.skinTabPage1.Controls.Add(this.check_AutoLight);
            this.skinTabPage1.Controls.Add(this.trabar_light);
            this.skinTabPage1.Controls.Add(this.label2);
            this.skinTabPage1.Controls.Add(this.num_usernodo);
            this.skinTabPage1.Controls.Add(this.skinButton2);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Location = new System.Drawing.Point(130, 0);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(508, 350);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "常规设置";
            // 
            // cb_CloseTeskImg
            // 
            this.cb_CloseTeskImg.AutoSize = true;
            this.cb_CloseTeskImg.BackColor = System.Drawing.Color.Transparent;
            this.cb_CloseTeskImg.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb_CloseTeskImg.DownBack = null;
            this.cb_CloseTeskImg.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_CloseTeskImg.Location = new System.Drawing.Point(51, 181);
            this.cb_CloseTeskImg.MouseBack = null;
            this.cb_CloseTeskImg.Name = "cb_CloseTeskImg";
            this.cb_CloseTeskImg.NormlBack = null;
            this.cb_CloseTeskImg.SelectedDownBack = null;
            this.cb_CloseTeskImg.SelectedMouseBack = null;
            this.cb_CloseTeskImg.SelectedNormlBack = null;
            this.cb_CloseTeskImg.Size = new System.Drawing.Size(140, 24);
            this.cb_CloseTeskImg.TabIndex = 64;
            this.cb_CloseTeskImg.Text = "一键关闭窗体特效";
            this.cb_CloseTeskImg.UseVisualStyleBackColor = false;
            this.cb_CloseTeskImg.CheckedChanged += new System.EventHandler(this.cb_CloseTeskImg_CheckedChanged_1);
            // 
            // cb_locked
            // 
            this.cb_locked.AutoSize = true;
            this.cb_locked.BackColor = System.Drawing.Color.Transparent;
            this.cb_locked.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb_locked.DownBack = null;
            this.cb_locked.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_locked.Location = new System.Drawing.Point(51, 151);
            this.cb_locked.MouseBack = null;
            this.cb_locked.Name = "cb_locked";
            this.cb_locked.NormlBack = null;
            this.cb_locked.SelectedDownBack = null;
            this.cb_locked.SelectedMouseBack = null;
            this.cb_locked.SelectedNormlBack = null;
            this.cb_locked.Size = new System.Drawing.Size(84, 24);
            this.cb_locked.TabIndex = 63;
            this.cb_locked.Text = "一键锁机";
            this.cb_locked.UseVisualStyleBackColor = false;
            // 
            // cb_prected
            // 
            this.cb_prected.AutoSize = true;
            this.cb_prected.BackColor = System.Drawing.Color.Transparent;
            this.cb_prected.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb_prected.DownBack = null;
            this.cb_prected.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_prected.Location = new System.Drawing.Point(282, 151);
            this.cb_prected.MouseBack = null;
            this.cb_prected.Name = "cb_prected";
            this.cb_prected.NormlBack = null;
            this.cb_prected.SelectedDownBack = null;
            this.cb_prected.SelectedMouseBack = null;
            this.cb_prected.SelectedNormlBack = null;
            this.cb_prected.Size = new System.Drawing.Size(112, 24);
            this.cb_prected.TabIndex = 62;
            this.cb_prected.Text = "开启屏保功能";
            this.cb_prected.UseVisualStyleBackColor = false;
            this.cb_prected.CheckedChanged += new System.EventHandler(this.cb_prected_CheckedChanged);
            // 
            // skinCheckBox1
            // 
            this.skinCheckBox1.AutoSize = true;
            this.skinCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox1.DownBack = null;
            this.skinCheckBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox1.Location = new System.Drawing.Point(282, 181);
            this.skinCheckBox1.MouseBack = null;
            this.skinCheckBox1.Name = "skinCheckBox1";
            this.skinCheckBox1.NormlBack = null;
            this.skinCheckBox1.SelectedDownBack = null;
            this.skinCheckBox1.SelectedMouseBack = null;
            this.skinCheckBox1.SelectedNormlBack = null;
            this.skinCheckBox1.Size = new System.Drawing.Size(140, 24);
            this.skinCheckBox1.TabIndex = 61;
            this.skinCheckBox1.Text = "开启桌面文件窗体";
            this.skinCheckBox1.UseVisualStyleBackColor = false;
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(373, 78);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(100, 21);
            this.tb_pwd.TabIndex = 59;
            // 
            // num_LockedTime
            // 
            this.num_LockedTime.ArrowColor = System.Drawing.SystemColors.ActiveBorder;
            this.num_LockedTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.num_LockedTime.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.num_LockedTime.BorderColor = System.Drawing.Color.Black;
            this.num_LockedTime.ForeColor = System.Drawing.Color.Black;
            this.num_LockedTime.Location = new System.Drawing.Point(118, 78);
            this.num_LockedTime.Name = "num_LockedTime";
            this.num_LockedTime.Size = new System.Drawing.Size(35, 21);
            this.num_LockedTime.TabIndex = 58;
            // 
            // num_loop
            // 
            this.num_loop.ArrowColor = System.Drawing.SystemColors.ActiveBorder;
            this.num_loop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.num_loop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.num_loop.BorderColor = System.Drawing.Color.Black;
            this.num_loop.ForeColor = System.Drawing.Color.Black;
            this.num_loop.Location = new System.Drawing.Point(374, 46);
            this.num_loop.Name = "num_loop";
            this.num_loop.Size = new System.Drawing.Size(35, 21);
            this.num_loop.TabIndex = 56;
            // 
            // check_AutoLight
            // 
            this.check_AutoLight.AutoSize = true;
            this.check_AutoLight.BackColor = System.Drawing.Color.Transparent;
            this.check_AutoLight.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.check_AutoLight.DownBack = null;
            this.check_AutoLight.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_AutoLight.Location = new System.Drawing.Point(282, 211);
            this.check_AutoLight.MouseBack = null;
            this.check_AutoLight.Name = "check_AutoLight";
            this.check_AutoLight.NormlBack = null;
            this.check_AutoLight.SelectedDownBack = null;
            this.check_AutoLight.SelectedMouseBack = null;
            this.check_AutoLight.SelectedNormlBack = null;
            this.check_AutoLight.Size = new System.Drawing.Size(140, 24);
            this.check_AutoLight.TabIndex = 54;
            this.check_AutoLight.Text = "开启智能调节功能";
            this.check_AutoLight.UseVisualStyleBackColor = false;
            // 
            // trabar_light
            // 
            this.trabar_light.AutoSize = false;
            this.trabar_light.BackColor = System.Drawing.Color.Transparent;
            this.trabar_light.Bar = ((System.Drawing.Image)(resources.GetObject("trabar_light.Bar")));
            this.trabar_light.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Img;
            this.trabar_light.BaseColor = System.Drawing.Color.Transparent;
            this.trabar_light.LargeChange = 2;
            this.trabar_light.Location = new System.Drawing.Point(102, 307);
            this.trabar_light.Maximum = 44;
            this.trabar_light.Minimum = 3;
            this.trabar_light.Name = "trabar_light";
            this.trabar_light.Size = new System.Drawing.Size(281, 20);
            this.trabar_light.TabIndex = 53;
            this.trabar_light.Track = ((System.Drawing.Image)(resources.GetObject("trabar_light.Track")));
            this.trabar_light.Value = 3;
            this.trabar_light.Scroll += new System.EventHandler(this.trabar_light_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 52;
            this.label2.Text = "屏幕饱和度调节";
            // 
            // num_usernodo
            // 
            this.num_usernodo.ArrowColor = System.Drawing.SystemColors.ActiveBorder;
            this.num_usernodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.num_usernodo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.num_usernodo.BorderColor = System.Drawing.Color.Black;
            this.num_usernodo.ForeColor = System.Drawing.Color.Black;
            this.num_usernodo.Location = new System.Drawing.Point(117, 46);
            this.num_usernodo.Name = "num_usernodo";
            this.num_usernodo.Size = new System.Drawing.Size(35, 21);
            this.num_usernodo.TabIndex = 51;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinButton2.BackgroundImage")));
            this.skinButton2.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton2.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton2.DownBack")));
            this.skinButton2.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton2.FadeGlow = false;
            this.skinButton2.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton2.ForeColor = System.Drawing.Color.Transparent;
            this.skinButton2.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton2.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton2.Location = new System.Drawing.Point(410, 296);
            this.skinButton2.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton2.MouseBack")));
            this.skinButton2.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton2.NormlBack")));
            this.skinButton2.Size = new System.Drawing.Size(72, 34);
            this.skinButton2.TabIndex = 49;
            this.skinButton2.Text = "保存";
            this.skinButton2.UseVisualStyleBackColor = true;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.White;
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Location = new System.Drawing.Point(130, 0);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(508, 350);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "主页加载项设置";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Close.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_Close.DownBack")));
            this.btn_Close.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_Close.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_Close.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.GlowColor = System.Drawing.Color.Transparent;
            this.btn_Close.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_Close.Location = new System.Drawing.Point(607, 12);
            this.btn_Close.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_Close.MouseBack")));
            this.btn_Close.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_Close.NormlBack")));
            this.btn_Close.Size = new System.Drawing.Size(16, 16);
            this.btn_Close.TabIndex = 66;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(275, 79);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(93, 20);
            this.skinLabel1.TabIndex = 65;
            this.skinLabel1.Text = "系统解锁密码";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(278, 47);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(93, 20);
            this.skinLabel2.TabIndex = 66;
            this.skinLabel2.Text = "屏保循环间隔";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(414, 47);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(37, 20);
            this.skinLabel3.TabIndex = 67;
            this.skinLabel3.Text = "分钟";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(47, 78);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(65, 20);
            this.skinLabel4.TabIndex = 68;
            this.skinLabel4.Text = "系统空闲";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(159, 79);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(51, 20);
            this.skinLabel5.TabIndex = 69;
            this.skinLabel5.Text = "锁电脑";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(47, 47);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(65, 20);
            this.skinLabel6.TabIndex = 70;
            this.skinLabel6.Text = "系统空闲";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(159, 47);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(93, 20);
            this.skinLabel7.TabIndex = 71;
            this.skinLabel7.Text = "自动开启屏保";
            // 
            // btn_mainpage
            // 
            this.btn_mainpage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_mainpage.BackColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.BaseColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.BorderColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_mainpage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mainpage.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_mainpage.DownBack")));
            this.btn_mainpage.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_mainpage.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_mainpage.ForeColor = System.Drawing.Color.White;
            this.btn_mainpage.GlowColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.Location = new System.Drawing.Point(0, 0);
            this.btn_mainpage.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_mainpage.MouseBack")));
            this.btn_mainpage.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.Name = "btn_mainpage";
            this.btn_mainpage.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_mainpage.NormlBack")));
            this.btn_mainpage.Size = new System.Drawing.Size(190, 45);
            this.btn_mainpage.TabIndex = 67;
            this.btn_mainpage.UseVisualStyleBackColor = false;
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 395);
            this.ControlBox = false;
            this.Controls.Add(this.btn_mainpage);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.panel_tabcontrol);
            this.Name = "Form_Setting";
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.Form_Setting_Load);
            this.panel_tabcontrol.ResumeLayout(false);
            this.tab_music.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.skinTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_LockedTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_loop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabar_light)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_usernodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinPanel panel_tabcontrol;
        private CCWin.SkinControl.SkinTabControl tab_music;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private CCWin.SkinControl.SkinCheckBox cb_CloseTeskImg;
        private CCWin.SkinControl.SkinCheckBox cb_locked;
        private CCWin.SkinControl.SkinCheckBox cb_prected;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox1;
        private System.Windows.Forms.TextBox tb_pwd;
        private CCWin.SkinControl.SkinNumericUpDown num_LockedTime;
        private CCWin.SkinControl.SkinNumericUpDown num_loop;
        private CCWin.SkinControl.SkinCheckBox check_AutoLight;
        private CCWin.SkinControl.SkinTrackBar trabar_light;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinNumericUpDown num_usernodo;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private CCWin.SkinControl.SkinButton btn_Close;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton btn_mainpage;
    }
}