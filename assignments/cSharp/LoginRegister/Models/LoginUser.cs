#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LoginRegister.Models;



[NotMapped]
public class LoginUser
{

    public int LoginUserId { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string LoginEmail { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string LoginPassword { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}