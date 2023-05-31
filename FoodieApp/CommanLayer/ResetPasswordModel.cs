using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommanLayer
{
    public class ResetPasswordModel

    { 
        [Required(ErrorMessage ="New Password Required",AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage="New password and Confirm password does not match")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string ResetCode { get;set; }
    }
}
