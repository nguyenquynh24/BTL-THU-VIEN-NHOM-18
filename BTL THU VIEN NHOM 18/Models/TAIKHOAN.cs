﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BTL_THU_VIEN_NHOM_18.Models
{

    public class TAIKHOAN
    {
        [Key]
        public int taikhoan { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }

        [Required]     
        public string Password { get; set; }

       

        public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public string roleID { get; set; }


        internal static Task FindByNameAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
