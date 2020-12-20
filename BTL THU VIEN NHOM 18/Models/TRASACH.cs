using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_THU_VIEN_NHOM_18.Models
{
    public class TRASACH
    { 
        [Key]
        public int  sophieumuonid { get; set; }
        public string mssach { get; set; }
        public SACH SACH { get; set; }
        public string msnhanvien { get; set; }
        public NHANVIEN NHANVIEN { get; set; }
        public string ngaytra { get; set; }


    }
}