using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlHelpersApp.Validations;

namespace HtmlHelpersApp.Models
{
    public class UserRegistration
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Range(18, 35, ErrorMessage = "Invalid Age")]
        public int Age { get; set; }

        [Range(15000, Double.MaxValue, ErrorMessage = "Invalid Salary")]
        public double Salary { get; set; }
    }
}