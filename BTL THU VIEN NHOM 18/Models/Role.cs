using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_THU_VIEN_NHOM_18.Models
{
    public class Role
    {
        [Key]
        [StringLength(20)]
        public string roleID { get; set; }
        public string rolename { get; set; }
    }
}