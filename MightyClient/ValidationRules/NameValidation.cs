using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace MightyClient.ValidationRules
{
    public class NameValidation : ValidationRule
    {
        public override ValidationResult Validate
          (object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value == null)
                return new ValidationResult(false, "Pole jest wymagane.");
            else
            {
                if (value.ToString().Length > 2)
                    return new ValidationResult
                    (false, "Imie Musi składać się przynajmniej z 2 liter");
            }
            return ValidationResult.ValidResult;
        }
    }
}
