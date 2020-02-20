using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private HomeContext dbContext;
        public HomeController(HomeContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Chef> AllChefs = dbContext.Chefs.ToList();
            ViewBag.Chefs = AllChefs;

            List<Dish> AllDishes = dbContext.Dishes.Include(dbContext=>dbContext.Creator).ToList();
            ViewBag.Dishes = AllDishes;

            return View("Index", AllChefs);
        }

        public IActionResult ShowChef(int id)
        {
            Chef sChef = dbContext.Chefs.FirstOrDefault(c=>c.ChefId == id);
            return View("Index", sChef);
        }

        [HttpGet("new")]
        public IActionResult NewChef()
        {
            return View("CreateChef");
        }

        [HttpPost("create/chef")]
        public IActionResult MakeChef(Chef makeChef)
        {
            if (ModelState.IsValid)
            {
                dbContext.Chefs.Add(makeChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("CreateChef");
            }
        }

        [HttpGet("dishes")]
        public IActionResult ShowDish()
        {
            List<Dish> AllDishes = dbContext.Dishes
            .Include(d => d.Creator)
            .ToList();

            return View("Dishes", AllDishes);
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            List<Chef> AllChefs = dbContext.Chefs.ToList();
            ViewBag.Chefs = AllChefs;
            return View("CreateDish");
        }

        [HttpPost("dishes/create")]
        public IActionResult CreateDish(Dish makeDish)
        {
            if (ModelState.IsValid)
            {
                
                dbContext.Dishes.Add(makeDish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes", makeDish);
            }
            else
            {
                List<Dish> AllDishes = dbContext.Dishes.ToList();
                ViewBag.Dishes = AllDishes;
                return View("CreateDish");
            }
        }




//////////////////////////////////////////////////////////////////
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
