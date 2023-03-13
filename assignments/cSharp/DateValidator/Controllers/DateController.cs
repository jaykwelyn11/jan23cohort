using System.Diagnostics;
using DateValidator.Models;
using Microsoft.AspNetCore.Mvc;

namespace DateValidator.Controllers;

public class DateController : Controller
{
    [HttpGet("/form")]
    public IActionResult Form()
    {
        return View();
    }


    [HttpPost("/form/result")]
    public IActionResult Result(Form theForm)
    {
        if (ModelState.IsValid)
        {
            return View("result", theForm);
        }
        else
        {
            return View("index");
        }
    }
}
