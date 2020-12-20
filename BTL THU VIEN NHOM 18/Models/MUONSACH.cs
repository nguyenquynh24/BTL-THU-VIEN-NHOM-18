using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_THU_VIEN_NHOM_18.Models
{
    public class MUONSACH
    {    
        [Key]
        public int sophieumuonid { get; set; }
        [Required, MaxLength(30)]
        public string sophieumuon { get; set;  }
        public string msdocgia { get; set; }
        public DOCGIA DOCGIA { get; set; }
        public string msnhanvien { get; set; }
        public NHANVIEN NHANVIEN { get; set; }
        public string ngaymuon { get; set; }
        public string ngaytra { get; set; }
    }
}