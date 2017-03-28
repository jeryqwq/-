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
using System.IO;
using 桌面特效小工具;
using clock;

namespace 桌面特效小工具
{
    public partial class Form_Main : CCSkinMain
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        Form_SkinChang sc = new Form_SkinChang();
        bool FormOpenOrClose = true;
        UserMessagebox usermessagebox = new UserMessagebox();
        Point downPoint;
        Form_Time form_time = new Form_Time();
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            this.BackgroundImage = Image.FromFile(MyApp.Default.Path_background);
            tab_tool.SelectedIndex = 0;
           
            // IEVersion.BrowserEmulationSet();//此行代码运行一次即可，只是为了获得管理员权限，更改IE内核版本，执行后可继续注释掉，不然每次打开都要二次运行
            
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Point p = new Point(0, 0);
            this.menu_setting.Show(btn_menu, p);
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    
        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (usermessagebox.Form_min("提示信息", "是否最小化到任务栏图标？", "", "") ==true)
            {
                timer_hide.Enabled = true;
               
               //最小化任务栏
            }
            else 
            {
                timer_hide.Enabled = true;
            }
           
        }
    
        private void pan_SysBtn_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);//获得当前鼠标的XY坐标
        }

        private void pan_SysBtn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X, this.Location.Y + e.Y - downPoint.Y);//将鼠标坐标与窗体位置绑定
            }
        }

        private void tab_tool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_tool.SelectedTab.Name== "page_proctect")
            {
                panel_web.Controls.Add(web);
            }
            if (tab_tool.SelectedTab.Name == "tab_file")
            {
                panel_webFile.Controls.Add(web);
                string dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                web.Url = new Uri(dir);
                btn_ChangClocl.Visible = false;
            }
            else {
                btn_ChangClocl.Visible = true;
            }
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            tab_tool.SelectedIndex = 5;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {

        }

  

      

        private void btn_skin_Click(object sender, EventArgs e)
        {

            if (FormOpenOrClose == true)
            {
                sc.Top = MousePosition.Y + 20;
                sc.Left = MousePosition.X - sc.Width / 2;
                sc.Show();
                FormOpenOrClose = false;

            }
            else if (FormOpenOrClose == false)
            {
                FormOpenOrClose = true;
                sc.Hide();
            }
        }



        private void web_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == (char)13 || e.KeyValue == (char)27)
            {
                this.WindowState = FormWindowState.Normal;
                panel_tabcontrol.Visible = true;
                pan_SysBtn.Visible = true;
                panel_web.Controls.Add(web);
            }
        }

        private void 桌面时钟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_time.Show();
        }

        private void 设置中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tp in tab_tool.TabPages)
            {
                if (tp.Name == "page_setting")
                {
                    this.tab_tool.SelectedTab = tp;
                    break;
                }
            }
        }

        private void 小组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            usermessagebox.Print("小组成员", "福建工程学院软件学园信管1502陈杰，杨汶锦");

        }

        private void skinRadioButton10_CheckedChanged_1(object sender, EventArgs e)
        {
            web.Url = new Uri(Path.GetFullPath(@"前端/黑客帝国.html"));
            panel_web.Controls.Add(web);
        }

        private void btn_begin_Click_1(object sender, EventArgs e)
        {
            this.Controls.Add(web);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            foreach (Control control in this.Controls)
            {
                if (control.Name != "web")
                {
                    control.Visible = false;
                }
            }

            this.TopMost = true;
            //CCSkinMain MessageboxForm = new CCSkinMain();
            //MessageboxForm.MinimizeBox = false;
            //MessageboxForm.MaximizeBox = false;
            //MessageboxForm.ControlBox = true;
            //MessageboxForm.FormBorderStyle = FormBorderStyle.None;
            //MessageboxForm.WindowState = FormWindowState.Maximized;
            ////  MessageboxForm.BackColor = this.BackColor;
            //MessageboxForm.BackgroundImage = Image.FromFile(MyApp.Default.Path_background);
            //MessageboxForm.BackgroundImageLayout = ImageLayout.Stretch;
            //MessageboxForm.ControlBox = false;
            //MessageboxForm.StartPosition = FormStartPosition.WindowsDefaultLocation;
            //MessageboxForm.ShowDrawIcon = false;
            //MessageboxForm.Controls.Add(web);
            //MessageboxForm.TopMost = true;
            //MessageboxForm.Show();
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            timer_hide.Enabled = true;
            form_time.Show();
        }

        private void timer_hide_Tick(object sender, EventArgs e)
        {
            for(int i=0; i < this.Size.Width/25; i++) { 
            this.Size = new Size(this.Size.Width, this.Size.Height-25);
                if (this.Size.Height <= 50 )
                {
                    this.Hide();
                    timer_hide.Enabled = false;
                }
            }
        }

        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab_tool.SelectedIndex = 0;
        }

        private void btn_goback_Click(object sender, EventArgs e)
        {
            if (tab_tool.SelectedIndex <= tab_tool.TabCount&&tab_tool.SelectedIndex-1>=0)
            {
                tab_tool.SelectedIndex = tab_tool.SelectedIndex - 1;
            }
            else
            {
                usermessagebox.Print("提示信息","已加载到首页");
            }
        }

        private void btn_gofoward_Click(object sender, EventArgs e)
        {
            if (tab_tool.SelectedIndex <= tab_tool.TabCount && tab_tool.SelectedIndex != tab_tool.TabCount-1)
            {
                tab_tool.SelectedIndex = tab_tool.SelectedIndex + 1;
            }
            else
            {
                usermessagebox.Print("提示信息", "已加载到末页");
            }
        }

        private void skinButton4_Click_1(object sender, EventArgs e)
        {

        }
        private void runJs(string str)
        {
            web.Document.InvokeScript("eval", new object[] { str });
        }
        private void skinRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            web.Url = new Uri(Path.GetFullPath(@"前端/3Dcanvas.html"));
            panel_web.Controls.Add(web);
        }

        private void skinRadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            web.Url = new Uri(Path.GetFullPath(@"前端/3dflower.html"));
            panel_web.Controls.Add(web);
        }
    }
}

