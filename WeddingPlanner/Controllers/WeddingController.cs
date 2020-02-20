using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WeddingPlanner.Context;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers
{
    public class WeddingController : Controller
    {
        private HomeContext dbContext;

        public WeddingController(HomeContext context)
        {
            dbContext = context; 
        }

        [HttpGet("dashboard")]
        public IActionResult Index()
        {
            User userInDb = LoggedIn();
            if(userInDb == null)
            {
                return RedirectToAction("LogOut", "Home");
            }
            List<Wedding> AllWeddings = dbContext.Weddings.Include( w => w.GuestList).ThenInclude(r => r.Guest).Include(w =>w.Planner).ToList();
            ViewBag.User = userInDb;
            return View(AllWeddings);
        }

        [HttpGet("wedding/new")]
        public IActionResult NewWedding()
        {
            User userInDb = LoggedIn();
            if(userInDb == null)
            {
                return RedirectToAction("LogOut", "Home");
            }
            ViewBag.User = userInDb;
            return View();
        }

        [HttpGet("wedding/{weddingId}")]
        public IActionResult ShowWedding(int weddingId)
        {
            User userInDb = LoggedIn();
            if(userInDb == null)
            {
                return RedirectToAction("LogOut", "Home");
            }
            ViewBag.User = userInDb;

            Wedding show = dbContext.Weddings.Include(w => w.Planner)
                                            .Include(w => w.GuestList)
                                            .ThenInclude(r => r.Guest)
                                            .FirstOrDefault( w => w.WeddingId == weddingId);
            return View(show);
        }

        [HttpPost("wedding/create")]

        public IActionResult CreateWedding(Wedding newWed)
        {
            if(ModelState.IsValid)
            {
                dbContext.Weddings.Add(newWed);
                dbContext.SaveChanges();
                return Redirect($"/wedding/{newWed.WeddingId}");
            }
            else
            {
                ViewBag.User = LoggedIn();
                return View("NewWedding");
            }
        }

        [HttpGet("destory/{weddingId}")]
        public IActionResult DestroyWedding(int weddingId)
        {
            Wedding destory = dbContext.Weddings.FirstOrDefault( w => w.WeddingId == weddingId);
            dbContext.Weddings.Remove(destory);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("rsvp/{weddingId}/{userId}/{status}")]
        public IActionResult Respond(int weddingId, int userId, string status)
        {
            if(status == "rsvp")
            {
                RSVP response = new RSVP();
                response.WeddingId = weddingId;
                response.UserId = userId;
                dbContext.Rsvps.Add(response);
                dbContext.SaveChanges();
            }
            if(status == "cancel")
            {
                RSVP cancel = dbContext.Rsvps.FirstOrDefault( r => r.UserId == userId && r.WeddingId == weddingId);
                dbContext.Rsvps.Remove(cancel);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    private User LoggedIn() 
        {
            return dbContext.Users.FirstOrDefault (u => u.UserId == HttpContext.Session.GetInt32 ("UserId"));

        }
    }
}
