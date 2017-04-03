using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCWin;
using System.Drawing;
using System.Windows.Forms;
using CCWin.SkinControl;

namespace 桌面特效小工具
{/// <summary>
/// 基于Skin插件绘制更美观的MessageBox界面
/// </summary>
    class UserMessagebox
    {
        /// <summary>
        /// 退出messagebox的重绘，含下次开机自启动按钮
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <returns></returns>
        /// 

        SystemVoid systemvoid = new SystemVoid();
        public bool Form_min(string title, string text, string text1, string text2)
        {
            CCSkinMain MessageboxForm = new CCSkinMain();
            MessageboxForm.MinimizeBox = false;
            MessageboxForm.MaximizeBox = false;
            MessageboxForm.ControlBox = true;
            MessageboxForm.Location = new Point(100, 200);
            MessageboxForm.Width = 550;
            MessageboxForm.Height = 150;
            MessageboxForm.BackgroundImage = Image.FromFile(MyApp.Default.Path_background);
            MessageboxForm.BackgroundImageLayout = ImageLayout.Stretch;
            MessageboxForm.Text = title;
            MessageboxForm.ControlBox = false;
            MessageboxForm.StartPosition = FormStartPosition.CenterParent;
            MessageboxForm.ShowDrawIcon = false;

            SkinPanel labbox = new SkinPanel();
            labbox.Width = 300;
            labbox.Height = 200;
            labbox.Left = 30;
            labbox.Top = 30;

            SkinLabel lbtitle = new SkinLabel();
            lbtitle.Text = text;
            lbtitle.Left = 20;
            lbtitle.Top = 25;
            lbtitle.Parent = MessageboxForm;
            lbtitle.Size = new Size(120, 21);
            lbtitle.AutoSize = true;

            SkinLabel tbtext = new SkinLabel();
            tbtext.Left = 30;
            tbtext.Top = 45;
            tbtext.Width = 210;
            tbtext.Height = 100;
            tbtext.Parent = labbox;
            tbtext.Parent = MessageboxForm;
            tbtext.Text = text1;
            tbtext.AutoSize = true;

            SkinLabel tbtext2 = new SkinLabel();
            tbtext2.Left = 30;
            tbtext2.Top = 65;
            tbtext2.Width = 200;
            tbtext2.Height = 100;
            tbtext2.Parent = labbox;
            tbtext2.Parent = MessageboxForm;
            tbtext2.Text = text2;
            tbtext2.AutoSize = true;

            Button btnok = new Button();
            btnok.Left = 140;
            btnok.Top = 120;
            btnok.Parent = MessageboxForm;
            btnok.Text = "确定";
            MessageboxForm.AcceptButton = btnok;
            btnok.DialogResult = DialogResult.OK;
            btnok.FlatStyle = FlatStyle.Flat;
            //btnok.ForeColor = Color();
            btnok.BackColor = Color.Transparent;
            btnok.FlatAppearance.BorderSize = 1;


            Button btcancel = new Button();
            btcancel.Left = 350;
            btcancel.Top = 120;
            btcancel.Parent = MessageboxForm;
            btcancel.Text = "取消";
            //  MessageboxForm.AcceptButton = btnok;

            btcancel.FlatStyle = FlatStyle.Flat;
            btcancel.BackColor = Color.Transparent;
            btcancel.FlatAppearance.BorderSize = 1;
            btcancel.Click += new System.EventHandler(this.btn_Click);

            SkinCheckBox ziqi = new SkinCheckBox();
            ziqi.Left = 10;
            ziqi.Top = 120;
            ziqi.Parent = MessageboxForm;
            ziqi.Text = "是否下次开机自启";
            ziqi.FlatStyle = FlatStyle.Flat;
            ziqi.BackColor = Color.Transparent;
            ziqi.CheckedChanged += new EventHandler(this.ziqi_CheckedChanged);

            try
            {
                if (MessageboxForm.ShowDialog() == DialogResult.OK)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Print("提示信息", ex.ToString());
                return false;

            }
            finally
            {
                MessageboxForm.Dispose();
            }

        }

     


        /// <summary>
        /// 开机自启动方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ziqi_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 为确定按钮生成Click事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_Click(object sender, EventArgs e)
        {
            systemvoid.CloseForm("Form_Main");

        }
        /// <summary>
        /// 基于Skin插件重绘的用户可输入的Messagebox,返回为用户输入的内容
        /// </summary>
        /// <param name="Caption"></param>
        /// <param name="title"></param>
        /// <param name="text"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public string InputForm(string Caption, string title, string text, string type)
        {
            CCSkinMain MessageboxForm = new CCSkinMain();
            MessageboxForm.MinimizeBox = false;
            MessageboxForm.MaximizeBox = false;
            MessageboxForm.ControlBox = true;
            MessageboxForm.Location = new Point(100, 200);
            MessageboxForm.Width = 400;
            MessageboxForm.Height = 150;
            //  MessageboxForm.BackColor = this.BackColor;
            MessageboxForm.BackgroundImage = Image.FromFile(MyApp.Default.Path_background);
            MessageboxForm.BackgroundImageLayout = ImageLayout.Stretch;
            MessageboxForm.Text = Caption;
            MessageboxForm.ControlBox = false;
            MessageboxForm.StartPosition = FormStartPosition.CenterParent;
            MessageboxForm.ShowDrawIcon = false;

            SkinLabel lbtitle = new SkinLabel();
            lbtitle.Text = title;
            lbtitle.Left = 20;
            lbtitle.Top = 20;
            lbtitle.Parent = MessageboxForm;
            lbtitle.Size = new Size(120, 21);
            lbtitle.AutoSize = true;

            RichTextBox tbtext = new RichTextBox();
            // tbtext.BackColor = ColorTranslator.FromHtml(backcolor);
            tbtext.BorderStyle = BorderStyle.None;
            tbtext.Left = 30;
            tbtext.Top = 40;
            tbtext.Width = 300;
            tbtext.Height = 70;
            tbtext.Parent = MessageboxForm;


            Button btnok = new Button();
            btnok.Left = 110;
            btnok.Top = 120;
            btnok.Parent = MessageboxForm;
            btnok.Text = "确定";
            MessageboxForm.AcceptButton = btnok;
            btnok.DialogResult = DialogResult.OK;
            btnok.FlatStyle = FlatStyle.Flat;
            //btnok.ForeColor = Color();
            btnok.BackColor = Color.Transparent;
            btnok.FlatAppearance.BorderSize = 1;

            Button btncancel = new Button();
            btncancel.Left = 200;
            btncancel.Top = 120;
            btncancel.Parent = MessageboxForm;
            btncancel.Text = "取消";
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.BackColor = Color.Transparent;
            btncancel.DialogResult = DialogResult.Cancel;
            btncancel.FlatAppearance.BorderSize = 1;

            try
            {
                if (MessageboxForm.ShowDialog() == DialogResult.OK && tbtext.Text != "")
                {
                    return tbtext.Text;

                }
                else
                {
                    return null;
                }
               

            }
            catch (Exception ex)
            {
                Print("异常提示！", ex.Message);
                return null;
            }
            finally
            {
                MessageboxForm.Dispose();
            }
        }
        /// <summary>
        /// 绘制的仅有打印作用的的窗体，标题，内容
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        public void Print(string title, string text)
        {
            CCSkinMain MessageboxForm = new CCSkinMain();
            MessageboxForm.MinimizeBox = false;
            MessageboxForm.MaximizeBox = false;
            MessageboxForm.ControlBox = true;
            MessageboxForm.Location = new Point(100, 200);
            MessageboxForm.Width = 300;
            MessageboxForm.Height = 150;
            //  MessageboxForm.BackColor = pan_SysBtn.BackColor;
            MessageboxForm.BackgroundImage = Image.FromFile(MyApp.Default.Path_background);
            MessageboxForm.BackgroundImageLayout = ImageLayout.Stretch;
            MessageboxForm.Text = title;
            MessageboxForm.ControlBox = false;
            MessageboxForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            MessageboxForm.ShowDrawIcon = false;

            Label rt = new Label();
            rt.Text = text;
            rt.Left = 20;
            rt.Top = 30;
            rt.ForeColor = Color.White;
            rt.Parent = MessageboxForm;
            rt.Size = new Size(270, 80);
             rt.BackColor = Color.Transparent;
            rt.BorderStyle = BorderStyle.None;
            Button btnok = new Button();
            btnok.Left = 110;
            btnok.Top = 110;
            btnok.Parent = MessageboxForm;
            btnok.Text = "确定";
            MessageboxForm.AcceptButton = btnok;
            btnok.DialogResult = DialogResult.OK;
            btnok.FlatStyle = FlatStyle.Flat;
            //btnok.ForeColor = Color();
            btnok.BackColor = Color.Transparent;
            btnok.FlatAppearance.BorderSize = 1;


            try
            {
                if (MessageboxForm.ShowDialog() == DialogResult.OK)
                {

                    MessageboxForm.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        /// <summary>
        /// 消息提示框，返回值为bool型，true做什么，false做什么
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool Form_CloseView(string title, string text)
        {
            CCSkinMain MessageboxForm = new CCSkinMain();
            MessageboxForm.BackgroundImageLayout = ImageLayout.Stretch;
            MessageboxForm.AllowDrop = true;
            MessageboxForm.MinimizeBox = false;
            MessageboxForm.MaximizeBox = false;
            MessageboxForm.ControlBox = true;
            MessageboxForm.Location = new Point(100, 200);
            MessageboxForm.Width = 350;
            MessageboxForm.Height = 100;
             MessageboxForm.BackgroundImage = Image.FromFile(MyApp.Default.Path_background);
            MessageboxForm.Text = title;
            MessageboxForm.ControlBox = false;
            MessageboxForm.StartPosition = FormStartPosition.CenterParent;
            MessageboxForm.ShowDrawIcon = false;

            Label rt = new Label();
            rt.Text = text;
            rt.Left = 20;
            rt.Top = 30;
            rt.ForeColor = Color.Red;
            rt.Parent = MessageboxForm;
            rt.Size = new Size(300, 30);
            // rt.BackColor = pan_SysBtn.BackColor;
            rt.BorderStyle = BorderStyle.None;
            rt.BackColor = Color.Transparent;
            Button btnok = new Button();
            btnok.Left = 110;
            btnok.Top = 60;
            btnok.Parent = MessageboxForm;
            btnok.Text = "确定";
            btnok.DialogResult = DialogResult.Cancel;
           
           
            btnok.FlatStyle = FlatStyle.Flat;
            //btnok.ForeColor = Color();
            btnok.BackColor = Color.Transparent;
            btnok.FlatAppearance.BorderSize = 1;
            Button btcancel = new Button();
            btcancel.Left = 200;
            btcancel.Top = 60;
            btcancel.Parent = MessageboxForm;
            btcancel.Text = "取消";
            //  MessageboxForm.AcceptButton = btnok;
            btcancel.FlatStyle = FlatStyle.Flat;
            btcancel.BackColor = Color.Transparent;
            btcancel.FlatAppearance.BorderSize = 1;
            btcancel.DialogResult = DialogResult.OK;
            MessageboxForm.AcceptButton = btcancel;

            if (MessageboxForm.ShowDialog() == DialogResult.Cancel)
            {
                return false;
            }
            else { 
                return true;
            }
           



        }

    }

}