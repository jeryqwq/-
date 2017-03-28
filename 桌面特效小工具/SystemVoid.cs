using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 桌面特效小工具
{/// <summary>
/// 系统常用方法类
/// </summary>
    class SystemVoid
    {
        /// <summary>
        /// 根据窗体的Nmae属性得到窗体，实现不同窗体间的操作。
        /// </summary>
        /// <param name="FormName"></param>
        public void CloseForm(string FormName)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == FormName)
                {
                    Application.OpenForms[i].Close();

                }
            }

        }
        /// <summary>
        /// Show窗体
        /// </summary>
        /// <param name="FormName"></param>
        public void ShowForm(string FormName)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == FormName)
                {
                    Application.OpenForms[i].Show();

                }
            }

        }/// <summary>
         /// 保存用户配置，可持续添加
         /// </summary>
         /// <param name="value"></param>
        public void SaveChang(string value)
        {
            MyApp.Default.Path_background = value;
            MyApp.Default.Save();
        }
        public void SaveStyle(string value)
        {
            MyApp.Default.ClockStyle = value;
            MyApp.Default.Save();
        }
        public void SaveAlwaysAblove(bool type)
        {
            MyApp.Default.AlwaysAblove = type;
            MyApp.Default.Save();
        }
        /// <summary>
         /// 得到窗体，动态设置其背景
         /// </summary>
         /// <param name="formName"></param>
         /// <param name="ImgPath"></param>
        public void SetFormBackImage(string formName, string ImgPath)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == formName)
                {
                    Application.OpenForms[i].BackgroundImage = Image.FromFile(ImgPath);

                }
            }

        }
        public void ReturnFormSize(string FormName)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == FormName)
                {
                    Application.OpenForms[i].Size = new Size(713, 535);

                }
            }

        }

    }
}