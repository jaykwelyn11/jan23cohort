using Microsoft.AspNetCore.Mvc;
namespace Portfolio2.Controllers;

public class ProjectsController : Controller
{

    [HttpGet("projects/")]
    public ViewResult Projects()
    {
        return View();
    }


}

