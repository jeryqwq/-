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

namespace 桌面特效小工具
{
    public partial class Form_Setting :CCSkinMain
    {
        public Form_Setting()
        {
            InitializeComponent();
        }
        SystemVoid systemvoid = new SystemVoid();
        private void Form_Setting_Load(object sender, EventArgs e)
        {
            trabar_light.Value=  MyApp.Default.Light;
            this.BackgroundImage = Image.FromFile(MyApp.Default.Path_background);
        }

        private void cb_CloseTeskImg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_prected_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void skinCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void cb_CloseTeskImg_CheckedChanged_1(object sender, EventArgs e)
        {
            systemvoid.CloseForm("Form_DeskImg");
        }

        private void trabar_light_Scroll(object sender, EventArgs e)
        {
            LightControl.Light.SetGamma(trabar_light.Value);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            try
            {
                MyApp.Default.City = cb_city.Text;
                MyApp.Default.userNoDoThing = (int)num_usernodo.Value * 60;
                if (tb_pwd.Text != "") MyApp.Default.userPwd = tb_pwd.Text;
                MyApp.Default.DeskLoop = (int)num_loop.Value;
                MyApp.Default.Time_Locked = (int)num_LockedTime.Value;
                MyApp.Default.Save();
            }
            catch (Exception)
            {

            }
        }
    }
}
