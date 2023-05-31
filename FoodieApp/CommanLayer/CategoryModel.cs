using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommanLayer
{
    public class CategoryModel
    {  
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category name is required.")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Category image is required.")]
        public string CategoryImage { get; set; }

        [Required(ErrorMessage = "Category description is required.")]
        public string CategoryDescription { get; set; }
    }

}

