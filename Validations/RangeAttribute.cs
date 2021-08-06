using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HtmlHelpersApp.Validations
{
    public class RangeAttribute:ValidationAttribute
    {
        private readonly double _lowerBound;
        private readonly double _upperBound;
        public RangeAttribute(double a, double b)
        {
            _lowerBound = a;
            _upperBound = b;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Required field");
            }
            var textValue1 = value.ToString();
            var textValue = Convert.ToDouble(textValue1);
            if (textValue >= _lowerBound && textValue <= _upperBound)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Value is not in specified range");
        }
    }
}