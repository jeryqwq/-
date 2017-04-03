using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 桌面特效小工具
{
    class Weather
    {
        public static string GetweatherInfo(string CityName)
        {
            cn.com.webxml.www.WeatherWebService w = new cn.com.webxml.www.WeatherWebService();
            //把webservice当做一个类来操作  
            string[] s = new string[23];//声明string数组存放返回结果  
            string city = CityName;//获得文本框录入的查询城市  
            s = w.getWeatherbyCityName(city);
            //以文本框内容为变量实现方法getWeatherbyCityName  
            if (s[8] =="")
            {

                return MyApp.Default.City_Info; //"请输入正确的城市，例:福州/三明/莆田，不需加后缀,应免费API需要，查询次数系统有限制，请见谅！";
            }
            else
            {
                MyApp.Default.City_Info = (s[1] + " " + s[6] + "/t" + s[10]).ToString();
                MyApp.Default.Save();
                return (s[1] + " " + s[6] + "/t" + s[10]).ToString();
               
            }
        }
    }
}
