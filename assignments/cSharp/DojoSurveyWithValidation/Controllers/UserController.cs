
using System.Diagnostics;
using DojoSurveyWithValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurveyWithValidation.Controllers;
public class UserController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }


    [HttpPost("regUser")]
    public IActionResult Result(User theUser)
    {
        if (ModelState.IsValid)
        {
            return View("Results", theUser);
        }
        else
        {
            return View("Index");
        }
    }

    [HttpGet("results")]
    public ViewResult Results()
    {
        return View();
    }
}
