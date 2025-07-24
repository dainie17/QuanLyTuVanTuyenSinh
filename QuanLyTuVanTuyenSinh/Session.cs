using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuVanTuyenSinh
{
    internal class Session
    {
        public static int UserID { get; set; }
        public static string UserName { get; set; }
        public static byte RoleID { get; set; }

        public static void Clear()
        {
            UserID = 0;
            UserName = null;
            RoleID = 0;
        }
    }
}
