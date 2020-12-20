using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_THU_VIEN_NHOM_18.Models
{
    public class DOCGIA
    {
        [Key]
        public int docgiaid { get; set; }
        public string msdocgia { get; set; }
        public string tendocgia { get; set; }
        [Required,MinLength(8),MaxLength(15)]
        public string diachidocgia { get; set; }
        public string ngaysinhdocgia { get; set; }
        public string emaildocgia { get; set; }
        public string gioitinhdocgia { get; set; }
        public string sodienthoaidocgia { get; set; }
        public ICollection <CHITIETPHIEUMUON> cHITIETPHIEUMUONs { get; set; }
        public ICollection <DOCGIA> dOCGIAs { get; set; }
        public ICollection <PHAT> pHATs { get; set; }

    }
}