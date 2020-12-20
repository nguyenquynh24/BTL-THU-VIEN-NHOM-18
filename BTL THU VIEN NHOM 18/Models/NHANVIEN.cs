using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_THU_VIEN_NHOM_18.Models
{
    public class NHANVIEN
    {
        [Key] 
        public int idnhanvien { get; set; }
        [Required, MaxLength(30)]
        public string manv { get; set; }
        public string matmanv { get; set; }
        public string hotennv { get; set; }
        [Required, MinLength(8), MaxLength(15)]
        public string diachinv { get; set; }
        public string ngaysinhnv { get; set; }
        public string gioitinhnv { get; set; }
        public string sodienthoainv { get; set; }
        public string emailnv { get; set; }
        public string ngayvaolamnv { get; set; }
       public ICollection < NHANVIEN > nHANVIENs { get; set; }
        public ICollection <PHAT> pHATs { get; set; }
        public ICollection <TRASACH > tRASACHes { get; set; }
    }
}