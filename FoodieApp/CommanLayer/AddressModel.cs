using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommanLayer
{
    public class AddressModel
    {
        public int AddressId { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [StringLength(255, ErrorMessage = "Full name cannot be longer than 255 characters")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^[1-9]\d{9}$", ErrorMessage = "Invalid mobile number")]
        public long MobileNo { get; set; }

        [Required(ErrorMessage = "Pin code is required")]
        [Range(100000, 999999, ErrorMessage = "Invalid pin code")]
        public int pinCode { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(550, ErrorMessage = "Address cannot be longer than 550 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(255, ErrorMessage = "City name cannot be longer than 255 characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(255, ErrorMessage = "State name cannot be longer than 255 characters")]
        public string State { get; set; }

        [Required(ErrorMessage = "User ID is required")]
        public int UserId { get; set; }
    }

}

