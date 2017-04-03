using System;
using System.Windows.Forms;
using CCWin;
using System.Drawing;

namespace 桌面特效小工具
{
    public partial class Form_SkinChang : CCSkinMain
    {
        public Form_SkinChang()
        {
            InitializeComponent();
        }
        SystemVoid systemvoid = new SystemVoid();
        
        private void skinButton1_Click(object sender, EventArgs e)
        {
          systemvoid.SetFormBackImage("Form_Main", "BackGround//6.png");
          systemvoid.SaveChang("BackGround//6.png");
        }
     
        private void skinButton5_Click(object sender, EventArgs e)
        {
            systemvoid.SetFormBackImage("Form_Main", "BackGround//1.png");
            systemvoid.SaveChang("BackGround//1.png");
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            systemvoid.SetFormBackImage("Form_Main", "BackGround//2.png");
            systemvoid.SaveChang("BackGround//2.png");
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            systemvoid.SetFormBackImage("Form_Main", "BackGround//3.png");
            systemvoid.SaveChang("BackGround//3.png");
        }

        private void skinButton6_Click(object sender, EventArgs e)
        {
            systemvoid.SetFormBackImage("Form_Main", "BackGround//4.png");
            systemvoid.SaveChang("BackGround//4.png");
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            systemvoid.SetFormBackImage("Form_Main", "BackGround//5.png");
            systemvoid.SaveChang("BackGround//5.png");
        }

        private void skinButton9_Click(object sender, EventArgs e)
        {
            systemvoid.SetFormBackImage("Form_Main", "BackGround//7.png");
            systemvoid.SaveChang("BackGround//7.png");
        }

        private void skinButton8_Click(object sender, EventArgs e)
        {
            systemvoid.SetFormBackImage("Form_Main", "BackGround//8.png");
            systemvoid.SaveChang("BackGround//8.png");
        }

        private void skinButton7_Click(object sender, EventArgs e)
        {
            systemvoid.SetFormBackImage("Form_Main", "BackGround//9.png");
            systemvoid.SaveChang("BackGround//9.png");
        }

        private void btn_skin_Click(object sender, EventArgs e)
        {
            string file = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择图片目录";
            fileDialog.Filter = "所有文件(*.jpg;*.gif;*.jpeg;*.bmp;*.png)|*.jpg;*.gif;*.jpeg;*.bmp;*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                file = fileDialog.FileName;
                systemvoid.SetFormBackImage("Form_Main",file);
                Application.UserAppDataRegistry.SetValue("file", file);
            }
            if (file != "") {
            MyApp.Default.Path_background = file;
            MyApp.Default.Save();
            }
        }

        private void Form_SkinChang_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
