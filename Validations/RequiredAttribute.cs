using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HtmlHelpersApp.Validations
{
    public class RequiredAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Required field");
            }
            var textValue = value.ToString();

            if (textValue.Length < 0)
            {
                return new ValidationResult("Required field");
            }

            return ValidationResult.Success;
        }
    }
}