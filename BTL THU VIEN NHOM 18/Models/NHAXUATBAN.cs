using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_THU_VIEN_NHOM_18.Models
{
    public class NHAXUATBAN
    {
        [Key] 
        public int nhaxuatbanid { get; set; }
        [Required, MaxLength(30)]
        public string msnhaxuatban { get; set; }
        public string tennhaxuatban { get; set; }
        [Required, MinLength(8), MaxLength(15)]
        public string diachinhaxuatban { get; set; }
        public string websitenhaxuatban { get; set; }
        public string thongtinkhacnhaxuatban { get; set; }  
        public ICollection < SACH> sACHes { get; set; }

    }
}