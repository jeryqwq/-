/**
 * 1，本程序界面主要采用 CSkin 界面库。
 * 2，壁纸主要来源于百度个性首页自定义换肤的数据。
 * 3，本程序纯属技术交流，如有侵犯您任何权益，请联系QQ：1286999890 或 i@cloud1024.com
 * 4，本程序仅限于技术交流，您可以任意修改本程序，但不可用于任何商业活动。
 * 5，由本程序引起的任何计算机故障或损失本人不承担任何责任。
 * 6，您使用本程序即表示遵循以上约定。
 * **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Setting.Model
{

    public class starDataModel
    {
        public string type { get; set; }
        public string name { get; set; }
        public int dataindex { get; set; }
        public List<ListModel> list { get; set; }
    }

    public class DataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public List<starDataModel> bgitem { get; set; }
        public List<starDataModel> starData { get; set; }

    }

    public class ListModel
    {
        public int dataindex { get; set; }
    }


    public class BsResult
    {
        /// <summary>
        /// 
        /// </summary>
        public List<DataItem> data { get; set; }


    }



    public class Root
    {

        /// <summary>
        /// 
        /// </summary>
        public BsResult bsResult { get; set; }

    }
}
