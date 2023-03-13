#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DateValidator.Models;

public class Form
{
    [FutureDate]
    public DateTime Date { get; set; }
}

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        double time = (DateTime.Now - (DateTime)value).TotalDays;
        if (time < 0)
        {
            return new ValidationResult("You entered a future date/time");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}

