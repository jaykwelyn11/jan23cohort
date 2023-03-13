using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers;

public class WeddingController : Controller
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)

    public WeddingController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid
    {
        get
        {
            return HttpContext.Session.GetInt32("uid");
        }
    }

    [SessionCheck]
    [HttpGet("/weddings")]
    public IActionResult All()
    {
        List<Wedding> allWeddings = db.Weddings
        .Include(w => w.Creator)
        .ThenInclude(w => w.AttendingWeddings)
        .OrderByDescending(w => w.EventDate)
        .ToList();
        return View(viewName: "All", allWeddings);

    }


    [SessionCheck]
    [HttpGet("/weddings/{weddingId}")]
    public IActionResult ViewWedding(int weddingId)
    {
        Wedding? item = db.Weddings
        .Include(item => item.Creator)
        .FirstOrDefault(item => item.WeddingId == weddingId);
        if (item == null)
        {
            return RedirectToAction("All");
        }
        else
        {
            return View("ViewWedding", item);
        }
    }

    [SessionCheck]
    [HttpGet("/weddings/new")]
    public IActionResult New()
    {
        return View("New");
    }

    [HttpPost("/weddings/createWedding")]
    public IActionResult CreateWedding(Wedding w)
    {
        w.UserId = (int)uid;
        if (ModelState.IsValid)
        {
            db.Weddings.Add(w);
            db.SaveChanges();
            return Redirect("ViewWedding");
        }
        return View("New");
    }

    [SessionCheck]
    [HttpGet("/weddings/edit/{weddingId}")]
    public IActionResult EditWedding(int weddingId)
    {
        Wedding? item = db.Weddings
        .Include(item => item.Creator)
        .FirstOrDefault(p => p.WeddingId == weddingId);

        if (item == null || item.UserId != HttpContext.Session.GetInt32("uid"))
        {
            return RedirectToAction("All");
        }
        else
        {
            return View("EditWedding", item);
        }
    }

    [SessionCheck]
    [HttpPost("/weddings/updateWedding/{weddingId}")]
    public IActionResult UpdateWedding(Wedding w, int weddingId)
    {
        if (!ModelState.IsValid)
        {
            return EditWedding(weddingId);
        }
        Wedding? item = db.Weddings.FirstOrDefault(item => item.WeddingId == weddingId);
        if (item == null || item.UserId != HttpContext.Session.GetInt32("uid"))
        {
            return RedirectToAction("All");
        }
        else
        {
            item.WedderOne = w.WedderOne;
            item.WedderTwo = w.WedderTwo;
            item.EventDate = w.EventDate;
            item.Address = w.Address;
            item.UpdatedAt = DateTime.Now;

            db.Weddings.Update(item);
            db.SaveChanges();

            return RedirectToAction("ViewWedding", new { weddingId = weddingId });
        }

    }



    [SessionCheck]
    [HttpGet("/weddings/delete/{weddingId}")]
    public IActionResult DeleteWedding(int weddingId)
    {
        Wedding? item = db.Weddings.FirstOrDefault(item => item.WeddingId == weddingId);
        if (item != null)
        {
            db.Weddings.Remove(item);
            db.SaveChanges();
        }
        return RedirectToAction("All");
    }

    [SessionCheck]
    [HttpPost("/weddings/{weddingId}/rsvp")]
    public IActionResult RSVP(int id)
    {
        Rsvp? existingSignup = db.Rsvps.FirstOrDefault(r => r.UserId == HttpContext.Session.GetInt32("uid") && r.WeddingId == id);

        if (existingSignup == null)
        {
            Rsvp newSignup = new Rsvp()
            {
                UserId = (int)HttpContext.Session.GetInt32("uid"),
                WeddingId = id
            };
            db.Rsvps.Add(newSignup);
        }
        else
        {
            db.Rsvps.Remove(existingSignup);
        }
        db.SaveChanges();
        return RedirectToAction("All");
    }
}