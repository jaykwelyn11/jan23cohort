using Microsoft.AspNetCore.Mvc;
namespace TimeDisplay.Controllers;


public class HomeController : Controller
{

    [HttpGet("")]

    public IActionResult Index()
    {
        ViewBag.CurrentTime = DateTime.Now;
        return View("Index");
    }
}

