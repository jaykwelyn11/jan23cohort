#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlanner.Models;

public class User
{
    [Key]
    public int UserId { get; set; }


    [Required]
    [Display(Name = "Name")]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    [UniqueEmail] // Set the type of email
    public string Email { get; set; }


    [Required]
    [DataType(DataType.Password)] // auto fills input type of password (specifically when using asp)
    [MinLength(8)]
    public string Password { get; set; }

    [NotMapped] // please don't add me to the database
    [Required]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Oops! Passwords don't match, try again please!")]
    public string Confirm { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public string FullName()
    {
        return FirstName + " " + LastName;
    }

    public List<Rsvp> AttendingWeddings { get; set; } = new List<Rsvp>();

    public List<Wedding> ScheduledWeddings { get; set; } = new List<Wedding>();



}

public class UniqueEmailAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext valContext)
    {
        if (value == null)
        { // if email input is empty
            return new ValidationResult("Email is required");
        }
        MyContext _context = (MyContext)valContext.GetService(typeof(MyContext));
        if (_context.Users.Any(e => e.Email == value.ToString()))
        {
            return new ValidationResult("Email is in use"); // if email is in database
        }
        else
        {
            return ValidationResult.Success; // email not in database good to go
        }
    }
}