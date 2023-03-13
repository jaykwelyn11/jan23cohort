using System.Diagnostics;
using LoginRegister.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LoginRegister.Controllers;

public class UserController : Controller
{
    private MyContext db;
    public UserController(MyContext context)
    {
        db = context;
    }


    [HttpGet("")]
    public IActionResult Index()
    {
        if (HttpContext.Session.GetInt32("uid") != null)
        {
            return RedirectToAction("Success"); // Where to redirect/What Views Folder
        }
        else
        {
            return View("Index");
        }
    }

    [HttpGet("/success")]
    public IActionResult Success()
    {
        if (HttpContext.Session.GetInt32("uid") == null)
        {
            return RedirectToAction("Index");
        }
        return View("Success");
    }



    [HttpPost("/register")]
    public IActionResult Register(User newUser)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }
        else
        {
            PasswordHasher<User> hash = new PasswordHasher<User>();
            newUser.Password = hash.HashPassword(newUser, newUser.Password);
            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("uid", newUser.UserId);
            HttpContext.Session.SetString("FirstName", newUser.FirstName);
            return RedirectToAction("Index", "User");
        }
    }


    [HttpPost("/login")]

    public IActionResult Login(LoginUser getUser)
    {
        if (!ModelState.IsValid)
        {
            return View("Index");
        }
        else
        {
            User? userInDb = db.Users.FirstOrDefault(u => u.Email == getUser.LoginEmail);

            if (userInDb == null)
            {
                ModelState.AddModelError("LoginEmail", "Invalid Email");
                return View("Index");
            }
            else
            {
                PasswordHasher<LoginUser> hash = new PasswordHasher<LoginUser>();
                var result = hash.VerifyHashedPassword(getUser, userInDb.Password, getUser.LoginPassword);

                if (result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Invalid Password");
                    return View("Index");
                }
                else
                {
                    HttpContext.Session.SetInt32("uid", userInDb.UserId);
                    HttpContext.Session.SetString("FirstName", userInDb.FirstName);
                    return RedirectToAction("Index", "User");
                }
            }
        }
        return View("Index");
    }

    [HttpGet("/logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
}

