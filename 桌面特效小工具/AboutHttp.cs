using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 桌面特效小工具
{
    class AboutHttp
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(int Description, int ReservedValue);
        public static bool IsConnectInt()
        {
            int Description = 0;
            return InternetGetConnectedState(Description, 0);
        }
        }
    }

