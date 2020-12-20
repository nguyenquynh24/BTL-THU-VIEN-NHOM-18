using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_THU_VIEN_NHOM_18.Models
{
    public class LOAISACH
    {
        [Key]
        public int id { get; set; }
        [Required, MaxLength(30)]
        public string tensach { get; set; }
        [Required, MinLength(8), MaxLength(15)]
        public string maloaisach { get; set; }
        public ICollection <SACH> sACHes { get; set; }
        
    }
}