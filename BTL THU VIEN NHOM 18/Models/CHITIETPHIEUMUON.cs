using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_THU_VIEN_NHOM_18.Models
{
    public class CHITIETPHIEUMUON
    {
        [Key]
        public int sophieumuonid { get; set; }
        [Required, MaxLength(30)]
        public string msdocgia { get; set; }
        public DOCGIA DOCGIA { get; set; }

        public string sophieumuon { get; set; }
        public string mssach { get; set; }
        public SACH SACH { get; set; }
        public string hantra { get; set; }
        public ICollection<TRASACH> tRASACHes { get; set; }
    }
}

         