using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelRequestManagerNew
{
    static class Save
    {
        public static string sqlUsername { get; set; }
        public static string sqlPassword { get; set; }
        public static int LoginUserID { get; set; }
        public static string sqlIp { get; set; }
        public static string sqlDataBase { get; set; }
        public static string sqlPort { get; set; }
        public static string ftpIp { get; set; }
        public static string ftpPassword { get; set; }
        public static int maxRequestID { get; set; }
    }
}
