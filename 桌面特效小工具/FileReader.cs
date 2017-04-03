using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桌面特效小工具
{
    class FileReader

    { public void RemoveFile(string OldPath,string NewPath) {
            UserMessagebox usermessagebox = new UserMessagebox();
            DirectoryInfo TheFolder = new DirectoryInfo(OldPath);
        FileInfo[] Files = TheFolder.GetFiles();
            try
            {
                for (int i = 0; i<Files.Length; i++)
                {
                        Files[i].MoveTo(NewPath + Files[i].Name);
    }

}
            catch (Exception ex)
            {
                usermessagebox.Print("异常提示", ex.ToString());
            }
    }
    }
}
