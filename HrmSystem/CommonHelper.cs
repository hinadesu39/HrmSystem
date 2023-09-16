using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmSystem
{
    class CommonHelper
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

        public static void ShowSuccessMsg(string msg)
        {
            MessageBox.Show(msg, "操作成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowErrorMsg(string msg)
        {
            MessageBox.Show(msg, "操作失败提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        public static DialogResult ShowYesNoMsg(string msg)
        {
            return MessageBox.Show(msg, "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
