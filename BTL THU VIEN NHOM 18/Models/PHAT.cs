using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_THU_VIEN_NHOM_18.Models
{
    public class PHAT
    {
       
        [Key]
        public int id { get; set; }
        public string mssach { get; set; }
        public SACH SACH { get; set; }
        public string msdocgia { get; set; }
        public DOCGIA DOCGIA { get; set; }
        public string msnhanvien { get; set; }
        public NHANVIEN nHANVIEN { get; set; }
        public string lydophat { get; set; }


    }
}