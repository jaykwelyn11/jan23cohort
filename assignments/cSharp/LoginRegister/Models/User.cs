#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LoginRegister.Models;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    [MinLength(2)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [MinLength(2)]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    [UniqueEmail]
    public string Email { get; set; }

    [Required]
    [MinLength(8)]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [NotMapped]
    [Compare("Password", ErrorMessage = "Passwords do not match!")]
    public string Confirm { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}


public class UniqueEmailAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext valContext)
    {
        if (value == null) // if email input is empty
        {
            return new ValidationResult("Email is required");
        }
        MyContext _context = (MyContext)valContext.GetService(typeof(MyContext));
        if (_context.Users.Any(e => e.Email == value.ToString()))
        {
            return new ValidationResult("Email is in use"); // if email is in database
        }
        else
        {
            return ValidationResult.Success; // email not in database, good to go
        }
    }
}