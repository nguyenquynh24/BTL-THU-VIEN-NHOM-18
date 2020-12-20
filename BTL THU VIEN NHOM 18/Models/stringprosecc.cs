using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_THU_VIEN_NHOM_18.Models
{
    public class stringprosecc
    {
        public string GetMDS(string strInput)
        {
            string str_mds = "";
            byte[] arrOut = System.Text.Encoding.UTF8.GetBytes(strInput);
            MDSCryptoServiceProvider my_mds = new MDSCryptoServiceProvider();
            arrOut = my_mds.ComputeHash(arrOut);
                foreach (byte b in arrOut)
            {
                str_mds += b.ToString("X2)");
            }
            return str_mds;
        }
    }
}