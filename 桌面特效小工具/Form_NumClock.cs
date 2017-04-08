using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using 桌面特效小工具;

namespace 桌面特效小工具
{
    public partial class Form_NumClock :CCSkinMain
    {
        public Form_NumClock()
        {
            InitializeComponent();
        }
        private void Form_NumClock_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(MyApp.Default.Path_background);

          lb_weather2.Text= Weather.GetweatherInfo(MyApp.Default.City);

          //  桌面特效小工具.cn.com.webxml.www.WeatherWebService w = new 桌面特效小工具.cn.com.webxml.www.WeatherWebService();
          //  //把webservice当做一个类来操作  
          //  string[] s = new string[23];//声明string数组存放返回结果  
          //  string city = "福州";//获得文本框录入的查询城市  
          //  s = w.getWeatherbyCityName(city);
          //  //以文本框内容为变量实现方法getWeatherbyCityName  
          //  if (s[8] == "")
          //  {
          //      MessageBox.Show("暂时不支持您查询的城市");
          //  }
          //  else
          //  {
          //      lb_weather2.Text = s[1] + " " + s[6];
          //      lb_weather2.Text = s[10];
          //}
        }
        Point downPoint;
        private void lb_second_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X, this.Location.Y + e.Y - downPoint.Y);//将鼠标坐标与窗体位置绑定
            }
        }

        private void lb_second_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);//获得当前鼠标的XY坐标
        }

        private void lb_hour_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);//获得当前鼠标的XY坐标
        }

        private void lb_hour_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X, this.Location.Y + e.Y - downPoint.Y);//将鼠标坐标与窗体位置绑定
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_hour.Text = DateTime.Now.Hour.ToString();
            lb_second.Text  = DateTime.Now.Minute.ToString();
        }
        SystemVoid systemvoid = new SystemVoid();
        UserMessagebox usermessagebox = new UserMessagebox();
        private void 小组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            systemvoid.ShowForm("Form_Time");
            this.Hide();
        }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            systemvoid.ShowForm("Form_Main");
            systemvoid.ReturnFormSize("Form_Main");
        }

        private void lb_weather2_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);//获得当前鼠标的XY坐标
        }

        private void lb_weather2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X, this.Location.Y + e.Y - downPoint.Y);//将鼠标坐标与窗体位置绑定
            }
        }

        private void skinLabel1_Click(object sender, EventArgs e)
        {string str = usermessagebox.InputForm("城市切换", "请输入您要查询的城市", "例：福州/莆田/三明，请去除市区的后缀", "");
if (str != "" && str != null) {
                MyApp.Default.City = str;
            }
            else
            {
                usermessagebox.Print("提示信息","请输入您要查询的城市");
            }
            lb_weather2.Text = Weather.GetweatherInfo(MyApp.Default.City);
        }

        private void Form_NumClock_MouseMove(object sender, MouseEventArgs e)
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
