
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using 桌面特效小工具;

namespace Desk
{
    public partial class Form_DeskImg : Form
    {
        
        private static readonly Random rand = new Random();
        private readonly List<SnowFlake> SnowFlakes = new List<SnowFlake>();
        private int Tick = 0;
        private class SnowFlake
        {
            public float Rotation;
            public float RotVelocity;
            public float Scale;
            public float X;
            public float XVelocity;
            public float Y;
            public float YVelocity;
            public Image image;
        }

        Image screenImage;

        public Form_DeskImg()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
        }

        private void Form_DeskImg_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = false;
            screenImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void SetBackground(Image img)
        {
            try
            {
                Bitmap bitmap = (Bitmap)img;
                if (bitmap.PixelFormat != PixelFormat.Format32bppArgb)
                {
                    throw new ApplicationException();
                }
                IntPtr hObject = IntPtr.Zero;
                IntPtr zero = IntPtr.Zero;
                IntPtr hDC = Win32.GetDC(IntPtr.Zero);
                IntPtr ptr2 = Win32.CreateCompatibleDC(hDC);
                try
                {
                    hObject = bitmap.GetHbitmap(Color.FromArgb(0));
                    zero = Win32.SelectObject(ptr2, hObject);
                    Win32.Size size2 = new Win32.Size(bitmap.Width, bitmap.Height);
                    Win32.Size psize = size2;
                    Win32.Point point3 = new Win32.Point(0, 0);
                    Win32.Point pprSrc = point3;
                    point3 = new Win32.Point(base.Left, base.Top);
                    Win32.Point pptDst = point3;
                    Win32.BLENDFUNCTION pblend = new Win32.BLENDFUNCTION();
                    pblend.BlendOp = 0;
                    pblend.BlendFlags = 0;
                    pblend.SourceConstantAlpha = 0xff;
                    pblend.AlphaFormat = 1;
                    Win32.UpdateLayeredWindow(this.Handle, hDC, ref pptDst, ref psize, ptr2, ref pprSrc, 0, ref pblend, 2);
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    throw exception;
                }
                finally
                {
                    Win32.ReleaseDC(IntPtr.Zero, hDC);
                    if (hObject != IntPtr.Zero)
                    {
                        Win32.SelectObject(ptr2, zero);
                        Win32.DeleteObject(hObject);
                    }
                    Win32.DeleteDC(ptr2);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                System.Windows.Forms.CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x80000;
                return createParams;
            }
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Tick++;
            if (Tick % 10 == 0)
            {
                SnowFlake s = new SnowFlake();
                Random rd = new Random();
                s.X = rand.Next(-20, this.Width + 20);
                s.Y = 0f;
                s.XVelocity = (float)(rand.NextDouble() - 0.5f) * 2f;
                s.YVelocity = (float)(rand.NextDouble() * 3) + 1f;
                s.Rotation = rand.Next(0, 359);
                s.RotVelocity = rand.Next(-3, 3) * 2;

                if  (MyApp.Default .DeskStyle=="snow")s.image = Image.FromFile(@"DeskImg\雪花\S" + rd.Next(1, 4) + ".gif");
                if (MyApp.Default.DeskStyle == "蒲公英") s.image = Image.FromFile(@"DeskImg\蒲公英\蒲公英_" + rd.Next(1,3) + ".png");
                if (MyApp.Default.DeskStyle == "paopao") s.image = Image.FromFile(@"DeskImg\泡泡\泡泡_" + rd.Next(1, 3) + ".png");
                if (MyApp.Default.DeskStyle == "love") s.image = Image.FromFile(@"DeskImg\爱心\爱心" + rd.Next(1, 4) + ".png");
                if (s.RotVelocity == 0)
                {
                    s.RotVelocity = 3;
                }

                s.Scale = (float)(rand.NextDouble() / 2) + 0.75f;
                SnowFlakes.Add(s);
            }

            Graphics g = Graphics.FromImage(screenImage);
            g.Clear(Color.Transparent);
            g.SmoothingMode = SmoothingMode.HighSpeed;

            for (int i = 0; i < SnowFlakes.Count; i++)
            {
                SnowFlake s1 = SnowFlakes[i];
                s1.X += s1.XVelocity;
                s1.Y += s1.YVelocity;
                s1.Rotation += s1.RotVelocity;
                s1.XVelocity += ((float)rand.NextDouble() - 0.5f) * 0.7f;
                s1.XVelocity = Math.Max(s1.XVelocity, -2f);
                s1.XVelocity = Math.Min(s1.XVelocity, +2f);

                if (s1.Y > this.Height)
                {
                    SnowFlakes.RemoveAt(i);
                }
                else
                {

                    g.ResetTransform();
                    g.TranslateTransform(-16, -16, MatrixOrder.Append); //pan
                    g.ScaleTransform(s1.Scale, s1.Scale, MatrixOrder.Append); //scale
                    g.RotateTransform(s1.Rotation, MatrixOrder.Append); //rotate
                    g.TranslateTransform(s1.X, s1.Y, MatrixOrder.Append); //pan
                    g.DrawImage(s1.image, 0, 0); //draw
                }
            }
            g.Dispose();
           SetBackground(screenImage );
        }
     

    }
}