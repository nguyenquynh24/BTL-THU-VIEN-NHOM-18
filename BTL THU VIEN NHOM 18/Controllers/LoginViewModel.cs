﻿using System.ComponentModel.DataAnnotations;

namespace BTL_THU_VIEN_NHOM_18.Controllers
{
    public class LoginViewModel
    {

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    } 

}