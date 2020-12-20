using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_THU_VIEN_NHOM_18.Models
{
    public class SACH
    {

        [Key] 
        public int sachid { get; set; }
        [Required, MaxLength(30)]
        public string mssach { get; set; }
        public string tensach { get; set; }
        [Required, MinLength(8), MaxLength(15)]
        public string msnhaxuatban { get; set; }
        public string maloaisach { get; set; }
        public string chuyennganh { get; set; }
        public string tinhtrangsach { get; set; }
        public string khuvucdesach { get; set; }
        [Required,MinLength (1),MaxLength(2)]
        public LOAISACH LOAISACH { get; set; }
        public ICollection <CHITIETPHIEUMUON > cHITIETPHIEUMUONs { get; set; }
        public ICollection <PHAT> pHATs { get; set; }
        public ICollection <TRASACH> tRASACHes { get; set; }
        public NHAXUATBAN NHAXUATBAN { get; set;  }

    }
}