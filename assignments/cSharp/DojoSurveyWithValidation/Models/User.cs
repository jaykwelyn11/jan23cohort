#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyWithValidation.Models;


public class User
{
    [Required]
    [MinLength(2)]
    public string Name { get; set; }


    [Required]
    public string Location { get; set; }


    [Required]
    public string FavLang { get; set; }


    [MinLength(20)]
    public string? Comment { get; set; }
}
