using Microsoft.AspNetCore.Mvc;
namespace Portfolio2.Controllers;

public class ContactController : Controller
{


    [HttpGet("contact/")]
    public ViewResult Contact()
    {
        return View();
    }

}

