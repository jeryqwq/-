using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using 桌面特效小工具;

namespace clock
{
    public partial class Form_Time : Form
    {
        public Form_Time()
        {
            InitializeComponent();
        }
        SystemVoid systemvoid = new SystemVoid();
        UserMessagebox usermessagebox = new UserMessagebox();
        //根据画好的图片得到流图，b=时钟背景，h时钟，m分钟，s秒钟
        Bitmap b = new Bitmap(@"Resources//defaultbgk.png");
        Bitmap h = new Bitmap(@"Resources//null.png");
        Bitmap m = new Bitmap(@"Resources//null.png");
        Bitmap s = new Bitmap(@"Resources//null.png");
        public static Bitmap Rotate(Bitmap b, int angle)//图片旋转
        {
            angle =360 - angle % 360;//角度

            double radian = angle * Math.PI / 180.0;
            double cos = Math.Cos(radian);
            double sin = Math.Sin(radian);
            
            Bitmap dsImage = new Bitmap(b.Width, b.Height);
            Graphics g = Graphics.FromImage(dsImage);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            
            Rectangle rect = new Rectangle(0, 0, b.Width, b.Height);
            Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
            g.TranslateTransform(center.X, center.Y);
            g.RotateTransform(360 - angle);
           
            g.TranslateTransform(-center.X, -center.Y);
            g.DrawImage(b, rect);
            
            g.ResetTransform();
            g.Dispose();
            return dsImage;
        }

        #region 窗体移动
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        #endregion

        #region 调用UpdateLayeredWindow函数

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;  
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | WS_MINIMIZEBOX;   
                cp.ExStyle |= 0x00080000;
                return cp;
            }
        }

        public void SetBits(Bitmap bitmap)
        {
            if (!Bitmap.IsCanonicalPixelFormat(bitmap.PixelFormat) || !Bitmap.IsAlphaPixelFormat(bitmap.PixelFormat))throw new ApplicationException("图片必须是32位带Alhpa通道的图片。");
            IntPtr oldBits = IntPtr.Zero;
            IntPtr screenDC = Win32.GetDC(IntPtr.Zero);
            IntPtr hBitmap = IntPtr.Zero;
            IntPtr memDc = Win32.CreateCompatibleDC(screenDC);
            try
            {
                Win32.Point topLoc = new Win32.Point(Left, Top);
                Win32.Size bitMapSize = new Win32.Size(bitmap.Width, bitmap.Height);
                Win32.BLENDFUNCTION blendFunc = new Win32.BLENDFUNCTION();
                Win32.Point srcLoc = new Win32.Point(0, 0);
                hBitmap = bitmap.GetHbitmap(Color.FromArgb(0));
                oldBits = Win32.SelectObject(memDc, hBitmap);
                blendFunc.BlendOp = Win32.AC_SRC_OVER;
                blendFunc.SourceConstantAlpha = 255;
                blendFunc.AlphaFormat = Win32.AC_SRC_ALPHA;
                blendFunc.BlendFlags = 0;
                Win32.UpdateLayeredWindow(Handle, screenDC, ref topLoc, ref bitMapSize, memDc, ref srcLoc, 0, ref blendFunc, Win32.ULW_ALPHA);
            }
            finally
            {
                if (hBitmap != IntPtr.Zero)
                {
                    Win32.SelectObject(memDc, oldBits);
                    Win32.DeleteObject(hBitmap);
                }
                Win32.ReleaseDC(IntPtr.Zero, screenDC);
                Win32.DeleteDC(memDc);
            }
        }

        #endregion

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//时钟移动
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(b);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(Rotate(h, DateTime.Now.Hour % 12 * 30 + DateTime.Now.Minute / 2),27,25);//时
            g.DrawImage(Rotate(m, DateTime.Now.Minute * 6),27,25);//分
            g.DrawImage(Rotate(s, DateTime.Now.Second * 6),27,25);//秒
            SetBits(bmp);
            g.Dispose();
            bmp.Dispose();
            GC.Collect();
        }




        public void Colorful()//炫彩风格
        {
            b = new Bitmap(@"Resources//bkg.png");
            h = new Bitmap(@"Resources//h.png");
            m = new Bitmap(@"Resources//m.png");
            s = new Bitmap(@"Resources//s.png");
            炫彩皮肤ToolStripMenuItem.Checked = true;
            扁平化时钟ToolStripMenuItem.Checked = false;
            金属风格ToolStripMenuItem.Checked = false;
            闹钟样式ToolStripMenuItem.Checked = false;
        }


        public void UiDesign()//扁平化
        {
            b = new Bitmap(@"Resources//bkg1.png");
            h = new Bitmap(@"Resources//h1.png");
            m = new Bitmap(@"Resources//m1.png");
            s = new Bitmap(@"Resources//s1.png");
            扁平化时钟ToolStripMenuItem.Checked = true;
            炫彩皮肤ToolStripMenuItem.Checked = false;
            金属风格ToolStripMenuItem.Checked = false;
            闹钟样式ToolStripMenuItem.Checked = false;
        }

        private void 金属ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gray();

        }
        public void Gray()//机械
        {
            b = new Bitmap(@"Resources//bkg2.png");
            h = new Bitmap(@"Resources//h2.png");
            m = new Bitmap(@"Resources//m2.png");
            s = new Bitmap(@"Resources//s2.png");
            金属风格ToolStripMenuItem.Checked = true;
            炫彩皮肤ToolStripMenuItem.Checked = false;
            扁平化时钟ToolStripMenuItem.Checked = false;
            闹钟样式ToolStripMenuItem.Checked = false;
        }

        private void 黄色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clock();
        
        }
        public void Clock()//闹钟样式
        {
            b = new Bitmap(@"Resources//bkg3.png");
            h = new Bitmap(@"Resources//h3.png");
            m = new Bitmap(@"Resources//m3.png");
            s = new Bitmap(@"Resources//s3.png");
            闹钟样式ToolStripMenuItem.Checked = true;
            炫彩皮肤ToolStripMenuItem.Checked = false;
            扁平化时钟ToolStripMenuItem.Checked = false;
            金属风格ToolStripMenuItem.Checked = false;
        }
/// <summary>
/// 窗体加载时应用上次配置信息
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

         
            if (MyApp.Default.ClockStyle == "UiDesign") UiDesign();
            if (MyApp.Default.ClockStyle == "Colorful") Colorful();
            if (MyApp.Default.ClockStyle == "Clock") Clock();
            if (MyApp.Default.ClockStyle == "Gray") Gray();
            设置中心ToolStripMenuItem.Checked = MyApp.Default.AlwaysAblove;
            this.TopMost = MyApp.Default.AlwaysAblove;

        }

   

        private void 鼠标穿透ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void CanPenetrate()
        {
            uint intExTemp = Win32.GetWindowLong(this.Handle, Win32.GWL_EXSTYLE);
            uint oldGWLEx = Win32.SetWindowLong(this.Handle, Win32.GWL_EXSTYLE, Win32.WS_EX_TRANSPARENT | Win32.WS_EX_LAYERED);
        }

        private void 置于顶层ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.TopMost = true;
        }

        private void 隐藏图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否隐藏托盘？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                notifyIcon1.Visible = false;

            }
            else toolStripMenuItem1.Checked = false;
        }

        private void 软件源码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if( usermessagebox.Form_CloseView("提示信息", "警告！是否关闭并施放所有占用资源？这样会关闭整个\n进程,包括主界面！！！") == false)
            {
                this.Dispose();
                Application.ExitThread();
            }
          


        }

    private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 炫彩皮肤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colorful();
            systemvoid.SaveStyle("Colorful");
        }

        private void 扁平化时钟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UiDesign();
            systemvoid.SaveStyle("UiDesign");
        }

        private void 金属风格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gray();
            systemvoid.SaveStyle("Gray");
        }

        private void 闹钟样式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clock();
            systemvoid.SaveStyle("Clock");
        }

        //private void 桌面时钟ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (桌面时钟ToolStripMenuItem.Checked == true)
        //    {
        //        try
        //        {
        //            RegistryKey key1 = Registry.LocalMachine;
        //            RegistryKey key2 = key1.CreateSubKey("software");
        //            RegistryKey key3 = key2.CreateSubKey("microsoft");
        //            RegistryKey key4 = key3.CreateSubKey("windows");
        //            RegistryKey key5 = key4.CreateSubKey("currentversion");
        //            RegistryKey key6 = key5.CreateSubKey("run");
        //            key6.SetValue(file, file);
        //            SystemConfig.WriteConfigData("Boot", "true");
        //            MessageBox.Show("设置成功");
        //        }
        //        catch { MessageBox.Show("设置失败"); }
        //    }
        //    else
        //    {
        //        try
        //        {
        //            RegistryKey key1 = Registry.LocalMachine;
        //            RegistryKey key2 = key1.CreateSubKey("software");
        //            RegistryKey key3 = key2.CreateSubKey("microsoft");
        //            RegistryKey key4 = key3.CreateSubKey("windows");
        //            RegistryKey key5 = key4.CreateSubKey("currentversion");
        //            RegistryKey key6 = key5.CreateSubKey("run");
        //            key6.DeleteValue(file, false);//撤消开机启动
        //            SystemConfig.WriteConfigData("Boot", "false");
        //            MessageBox.Show("取消成功");
        //        }
        //        catch { MessageBox.Show("取消失败"); }
        //    }
        //}
        Form_NumClock numclock = new Form_NumClock();

        private void 小组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numclock.Show();
            this.Hide();
  //  CanPenetrate(); 

        }

        private void 设置中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            {
                设置中心ToolStripMenuItem.Checked = false;
                this.TopMost = false;
            }
            else
            {
                设置中心ToolStripMenuItem.Checked = true;
                this.TopMost = true;
            }
             systemvoid.SaveAlwaysAblove(this.TopMost);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            usermessagebox.Print("提示信息", "已最小化到任务栏图标");
                notifyIcon1.Visible =true;
                this.Visible = false;
            
         
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            systemvoid.ShowForm("Form_Main");
            systemvoid.ReturnFormSize("Form_Main");
        }

        private void Form_Time_MouseMove(object sender, MouseEventArgs e)
        {
            int screenRight = Screen.PrimaryScreen.Bounds.Right;//屏幕右边缘  
            int formRight = this.Left + this.Size.Width;
            if (Math.Abs(screenRight - formRight) <= 150)//右
                this.Location = new System.Drawing.Point(screenRight - this.Size.Width, this.Top);//当前窗口坐标赋值，实现吸附  

            if (Math.Abs(this.Left) <= 150)//左
                this.Location = new System.Drawing.Point(0, this.Top);

            int screenBottom = Screen.PrimaryScreen.Bounds.Bottom;
            int formBottom = this.Top + this.Size.Height;
            if (Math.Abs(screenBottom - formBottom) <= 100)//下
                this.Location = new System.Drawing.Point(this.Left, screenBottom - this.Size.Height);

            if (Math.Abs(this.Top) <= 150)//上
                this.Location = new System.Drawing.Point(this.Left, 0);
        }
    }

}
