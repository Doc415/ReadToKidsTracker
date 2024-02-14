using System.ComponentModel.DataAnnotations;

namespace ReadToKidsTracker.Validations;

public class DateValidationAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value == null || !(value is DateTime dateValue))
        {
            return true; // Let the Required attribute handle null values
        }

        return dateValue <= DateTime.Now;
    }
}