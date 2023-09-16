using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HrmSystem
{
    class UseMD5
    {
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            byte[] md5Bytes = md5.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in md5Bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

    }
}
