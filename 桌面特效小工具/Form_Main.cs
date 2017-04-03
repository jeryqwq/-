using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;
using System.IO;
using clock;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using LightControl;
using Desk;
using System.Text;
using Newtonsoft.Json;
using Setting.Model;
using System.Threading;
using System.Collections.Generic;
using System.Net;
using CCWin.SkinClass;

namespace 桌面特效小工具
{
    public partial class Form_Main : CCSkinMain
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        string receivePath = Application.StartupPath + "\\img\\";
        string receivePath2 = Application.StartupPath + "\\img_back\\";
        ImageList imgList = new ImageList();
        SystemVoid systemvoid = new SystemVoid();
        Form_SkinChang sc = new Form_SkinChang();
        bool FormOpenOrClose = true;
        UserMessagebox usermessagebox = new UserMessagebox();
        Form_Setting form_setting = new Form_Setting();
        Point downPoint;
        Form_Time form_time = new Form_Time();
        FileReader fileready = new FileReader();
        string path_desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"//";
        string path_music = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//多媒体文件//";
        string path_debug = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//可执行文件//";
        string path_other = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//其他文件//";
        //[StructLayout(LayoutKind.Sequential)]
        //public struct LASTINPUTINFO
        //{
        //    [MarshalAs(UnmanagedType.U4)]
        //    public int cbSize;
        //    [MarshalAs(UnmanagedType.U4)]
        //    public uint dwTime;
        //}
        //[DllImport("user32.dll")]
        //public static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);


        //public long getIdleTick()
        //{
        //    LASTINPUTINFO vLastInputInfo = new LASTINPUTINFO();
        //    vLastInputInfo.cbSize = Marshal.SizeOf(vLastInputInfo);
        //    if (!GetLastInputInfo(ref vLastInputInfo)) return 0;
        //    return (Environment.TickCount - (long)vLastInputInfo.dwTime)/1000;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            this.BackgroundImage = Image.FromFile(MyApp.Default.Path_background);
            tab_tool.SelectedIndex = 0;
            Light.SetGamma(MyApp.Default.Light);
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
                notifyIcon1.Visible = true;
               //最小化任务栏
            }
            else 
            {
                timer_hide.Enabled = true;
                this.Dispose();
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
              
            }

            if(tab_tool.SelectedTab.Name== "page_background")
            {
                if (!Directory.Exists(receivePath))
                {
                    Directory.CreateDirectory(receivePath);
                }
                if (!Directory.Exists(receivePath2))
                {
                    Directory.CreateDirectory(receivePath2);
                }
                imgList.ImageSize = new Size(90, 55);
                imgList.ColorDepth = ColorDepth.Depth32Bit;
                lvList.LargeImageList = imgList;
                var hi = new HttpItem()
                {
                    Accept = "text/plain, */*; q=0.01",
                    UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.90 Safari/537.36",
                    Referer = "https://www.baidu.com/",
                    URL = "https://www.baidu.com/home/skin/data/skin",
                    Encoding = Encoding.UTF8
                };
                var http = new HttpHelper();
                var html = http.GetHtml(hi);
                var root = JsonConvert.DeserializeObject<Root>(html.Html);
                foreach (var item in root.bsResult.data)
                {
                    if (item.type == "最近使用" || item.type == "自定义")
                    {
                        continue;
                    }
                    TreeNode tn = new TreeNode(item.type);

                    if (item.bgitem != null)
                    {
                        tn.Tag = item.bgitem;
                    }
                        tvList.Nodes.Add(tn);
                    if (item.starData != null)
                    {

                        foreach (var subItem in item.starData)
                        {
                            TreeNode subTN = new TreeNode(subItem.name);
                            tn.Nodes.Add(subTN);
                            subTN.Tag = subItem.list;
                        }
                    }
                }
            }

        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            form_setting.Show();
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
           
            if (!Directory.Exists(path_music))
            {
                Directory.CreateDirectory(path_music);
            }
            if (!Directory.Exists(path_debug))
            {
                Directory.CreateDirectory(path_debug);
            }
            if (!Directory.Exists(path_other))
            {
                Directory.CreateDirectory(path_other);
            }
            DirectoryInfo TheFolder = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            List<string> ImgNames = new List<string>();
            string allowtype = ".jpg.jpeg.png.bmp.mp3.avi.mov.flv.mp4.gif.3gp.swf";
            string CanDebug = ".exe";
            FileInfo[] Files = TheFolder.GetFiles();
            //imageList1.ColorDepth = ColorDepth.Depth24Bit;
            //imageList1.ImageSize = new Size(100, 100);
            try
            {
                for (int i = 0; i < Files.Length; i++)
                {
                    if (Files[i].Length > 0 && allowtype.IndexOf(Files[i].Extension.ToLower()) > -1)
                    {
                        Files[i].MoveTo(path_music + Files[i].Name);
                    }
                    else if (Files[i].Length > 0 && CanDebug.IndexOf(Files[i].Extension.ToLower()) > -1)
                    {
                        Files[i].MoveTo(path_debug + Files[i].Name);
                    }
                    else
                    {
                        Files[i].MoveTo(path_other + Files[i].Name);
                    }
                }
            }
            catch (Exception ex)
            {
                usermessagebox.Print("异常提示", ex.ToString());
            }
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


        private void timer_userNoDo_Tick(object sender, EventArgs e)
        {
          
            if (UserNoDoSomething.UserNoDoSomething.GetLastInputTime()==MyApp.Default.userNoDoThing)//系统的API参数返回的用户无操作时间与用户配置的时间相同  单位/秒
            {
                btn_begin.PerformClick();
            }
        }
        private void GotoWeb(string weburl)
        {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command\");
            string s = key.GetValue("").ToString();
            System.Diagnostics.Process.Start(s.Substring(0, s.Length - 8),weburl );
        }
        private void 软件源码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GotoWeb("https://github.com/jeryqwq/-");
        }

     
     

        private void btn_mainpage_Click(object sender, EventArgs e)
        {

        }

        private void skinCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void ShowForm_Img()
        {
            Form_DeskImg frm = new Form_DeskImg();
            frm.Show();
        }

        public void threadPro()
        {
            MethodInvoker MethInvo = new MethodInvoker(ShowForm_Img);
            BeginInvoke(MethInvo);
        }
        private void skinRadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            systemvoid.CloseForm("Form_DeskImg");
            MyApp.Default.DeskStyle = "蒲公英";
            MyApp.Default.Save();
            threadPro();
        }

        private void skinRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            systemvoid.CloseForm("Form_DeskImg");
            MyApp.Default.DeskStyle = "snow";
            MyApp.Default.Save();
            threadPro();
        }

        private void skinRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            systemvoid.CloseForm("Form_DeskImg");
            MyApp.Default.DeskStyle = "paopao";
            MyApp.Default.Save();
            threadPro();
        }

        private void skinRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            systemvoid.CloseForm("Form_DeskImg");
            MyApp.Default.DeskStyle = "love";
            MyApp.Default.Save();
            threadPro();
        }

        private void cb_CloseTeskImg_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_prected_CheckedChanged(object sender, EventArgs e)
        {if (timer_userNoDo.Enabled == false) { timer_userNoDo.Enabled = true; return; }
            if (timer_userNoDo.Enabled == true) { timer_userNoDo.Enabled = false; return; }
        }

        private void tvList_AfterSelect(object sender, TreeViewEventArgs e)
        {   // for (int i = 0; i < e.Node.Nodes.Count; i++)
        //    {
        //        if (e.Node.Text == "女神降临"||e.Node.Text=="明星")
        //        {
        //            e.Node.Remove();
        //        }
        //    } 
            if (e.Node.Nodes.Count == 0)
            {
                if (e.Node.Tag != null)
                {
                    gifLoading.Visible = true;
                    imgList.Images.Clear();
                    lvList.Items.Clear();
                    GC.Collect();
                    Application.DoEvents();
                    Thread t = new Thread(new ThreadStart(() =>
                    {
                        List<starDataModel> bgitem = e.Node.Tag as List<starDataModel>;
                        if (bgitem != null)
                        {
                            #region
                            using (var countdown = new CountdownEvent(1))
                            {
                                foreach (var item in bgitem)
                                {

                                    ThreadPool.QueueUserWorkItem(delegate
                                    {
                                     
                                        string URLAddress = @"https://ss1.bdstatic.com/kvoZeXSm1A5BphGlnYG/skin_plus/" + item.dataindex + ".jpg";

                                        if (!File.Exists(receivePath + item.dataindex + ".jpg"))
                                        {
                                            try
                                            {
                                                using (WebClient client = new WebClient())
                                                {
                                                    client.DownloadFile(URLAddress, receivePath + Path.GetFileName(URLAddress));

                                                }
                                            }
                                            catch (Exception)
                                            {
                                            }
                                        }
                                        this.Invoke(new ThreadStart(() =>
                                        {
                                            imgList.Images.Add(item.dataindex.ToString(), Image.FromFile(receivePath + item.dataindex + ".jpg"));
                                        }));
                                        this.Invoke(new ThreadStart(() =>
                                        {
                                            lvList.Items.Add(new ListViewItem()
                                            {
                                                ImageKey = item.dataindex.ToString(),
                                                Name = string.Empty,
                                                Tag = item.dataindex
                                            });
                                        }));
                                        countdown.Signal();
                                    });
                                    countdown.AddCount();
                                }
                                countdown.Signal();
                                countdown.Wait();
                                this.Invoke(new ThreadStart(() => { gifLoading.Visible = false; }));

                            }
                            #endregion
                        }
                        else
                        {

                        }
                    }));
                    t.IsBackground = true;
                    t.Start();
                }
            }
        }
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern int SystemParametersInfo(
         int uAction,
         int uParam,
         string lpvParam,
         int fuWinIni
      );
        private void SetPic(int type)
        {
            if (lvList.SelectedItems.Count != 0)
            {
                Thread t = new Thread(new ThreadStart(() =>
                {
                    string id = string.Empty;
                    this.Invoke(new ThreadStart(() =>
                    {
                        id = lvList.SelectedItems[0].Tag.ToString();
                    }));

                    //下载大图
                    string URLAddress = @"https://ss3.bdstatic.com/iPoZeXSm1A5BphGlnYG/skin/" + id + ".jpg";
                    WebClient client = new WebClient();
                    try
                    {
                        client.DownloadFile(URLAddress, receivePath2 + System.IO.Path.GetFileName(URLAddress));
                    }
                    catch (Exception)
                    {
                        this.Invoke(new ThreadStart(() => { usermessagebox.Print("提示信息","主图下载失败，请检查您的网络或重试！"); }));

                    }
                    try
                    {
                        Image image = Image.FromFile(receivePath2 + id + ".jpg");
                        image.Save(receivePath2 + id + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        SystemParametersInfo(20, type, receivePath2 + id + ".bmp", type);
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new ThreadStart(() => { MessageBox.Show("设置失败:" + Environment.NewLine + ex.ToString()); }));
                        //MessageBox.Show("设置失败，请重试。");
                    }
                    this.Invoke(new ThreadStart(() => { usermessagebox.Print("提示信息", "设置成功！"); }));
                }));
                t.IsBackground = true;
                t.Start();

            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetPic(1);
        }

        private void 查看图片文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            lvList .Items.Clear();
            imgList.Images.Clear();

            DirectoryInfo TheFolder = new DirectoryInfo(@"img");//文件路径
            List<string> ImgNames = new List<string>();
            string allowImg = ".jpg.jpeg.png.bmp";
            FileInfo[] Files = TheFolder.GetFiles();
            imgList.ImageSize = new Size(100, 100);
            for (int i = 0; i < Files.Length; i++)//遍历文件夹
            {
                if (Files[i].Length > 0 && allowImg.IndexOf(Files[i].Extension.ToLower()) > -1)//或者jpg,png 文件大小要大于0且是图片文件
                {
                    Image image = Image.FromFile(Files[i].DirectoryName + "\\" + Files[i].Name);    //获取文件                 
                    ImgNames.Add(Files[i].Name);//添加文件名                    
                    imgList.Images.Add(image);//添加图片                   
                }
            }
            //初始化设置
            this.lvList .View = View.LargeIcon;
            this.lvList .LargeImageList = this.imgList;
            //开始绑定

            this.lvList .BeginUpdate();

            for (int i = 0; i < ImgNames.Count; i++)
            {
                // listView1.LargeImageList.Images.Add(list.Images.Keys[i], list.Images[i]);
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = ImgNames[i];
                this.lvList .Items.Add(lvi);
            }
            this.lvList .EndUpdate();


        }

        private void skinButton5_Click(object sender, EventArgs e)
        {
            web.GoBack();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            this.Show();
            systemvoid.ReturnFormSize("Form_Main");
        }

        private void skinButton6_Click(object sender, EventArgs e)
        {
            fileready.RemoveFile(path_music, path_desktop);
            fileready.RemoveFile(path_debug, path_desktop);
            fileready.RemoveFile(path_other, path_desktop);
        }

        private void skinRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            web.Url = new Uri(Path.GetFullPath(@"前端/弹幕特效.html"));
            panel_web.Controls.Add(web);
        }

        private void skinRadioButton13_CheckedChanged(object sender, EventArgs e)
        {
            web.Url = new Uri(Path.GetFullPath(@"前端/Canvas扩散.html"));
            panel_web.Controls.Add(web);
        }

        private void skinRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            web.Url = new Uri(Path.GetFullPath(@"前端/Rain.html"));
            panel_web.Controls.Add(web);
        }
    }
}

