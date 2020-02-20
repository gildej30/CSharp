using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUDelicious.Models;
// using CRUDelicious.Contexts;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private HomeContext dbContext;
        
        public HomeController(HomeContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList();
            ViewBag.Dishes = AllDishes;
            return View();
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Display(int id)
        {
            Dish displayDish = dbContext.Dishes.FirstOrDefault(d=>d.DishID == id);
            return View("DishPage", displayDish);
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            Dish displayDish = dbContext.Dishes.FirstOrDefault(d=>d.DishID == id);
            return View("Edit", displayDish);
        }

        [HttpPost("editor/{id}")]
        public IActionResult Editor(int id, Dish edit)
        {
            if (ModelState.IsValid)
            {
                Dish eDish = dbContext.Dishes.FirstOrDefault(d => d.DishID == id);
                    eDish.Name = edit.Name;
                    eDish.Chef = edit.Chef;
                    eDish.Calories = edit.Calories;
                    eDish.Tastiness = edit.Tastiness;
                    eDish.Description = edit.Description;
                    eDish.UpdatedAt = DateTime.Now;
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
            }
            else
            {
                Dish displayDish = dbContext.Dishes.FirstOrDefault(d=>d.DishID == id);
                return View("DishPage", displayDish);
            }
        }

        [HttpPost("new")]
        public IActionResult Create(Dish createDish)
        {
        if (ModelState.IsValid)
            {
                dbContext.Dishes.Add(createDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("new");
            }
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            Dish killDish = dbContext.Dishes.FirstOrDefault(d=>d.DishID == id);
            dbContext.Dishes.Remove(killDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
