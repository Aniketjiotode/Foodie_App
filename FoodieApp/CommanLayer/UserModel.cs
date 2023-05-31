using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommanLayer
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your mobile number.")]
        public long MobileNo { get; set; }
        public string ResetPasswordCode { get; set; }
    }

}
