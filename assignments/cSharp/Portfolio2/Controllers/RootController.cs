using Microsoft.AspNetCore.Mvc;
namespace Portfolio2.Controllers;

public class RootController : Controller
{

    [HttpGet]
    [Route("/")]
    public ViewResult Index()
    {
        return View("index");
    }

}

