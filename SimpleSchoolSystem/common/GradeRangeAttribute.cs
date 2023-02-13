using System.ComponentModel.DataAnnotations;

namespace SimpleSchoolSystem.common;

public class DegreeRangeAttribute : ValidationAttribute
{




    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        int degree = (int)value;

        if (degree <= 50 || degree >= 100)
        {
            // display the annotated error message
            var errorMessage = FormatErrorMessage(validationContext.DisplayName);
            return new ValidationResult(errorMessage);
        }

        return ValidationResult.Success;
    }
}

