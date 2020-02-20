using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdsNCats.Context;
using ProdsNCats.Models;

namespace ProdsNCats.Controllers
{
    public class HomeController : Controller
    {

        //////////////DATABASE//////////////////////////
        private HomeContext dbContext;

        public HomeController(HomeContext context)
        {
            dbContext = context;
        }
        

        /////////////ROUTES//////////////////////////////
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Products = dbContext.Products.ToList();
            return View("Index");
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            ViewBag.Categories = dbContext.Categories.ToList();
            return View("Categories");
        }

        [HttpGet("product/{prodId}")]
        public IActionResult ShowProduct(int prodId)
        {
            ViewBag.Product = dbContext.Products.Include(p=>p.Cats)
            .ThenInclude( a => a.Cat)
            .FirstOrDefault( p=>p.ProductId == prodId);

            ViewBag.NotOnProduct = dbContext.Categories.Include(c=>c.Products)
            .Where(c => c.Products.All( a => a.ProductId != prodId ))
            .ToList();

            return View();
        }

        [HttpGet("category/{categoryId}")]
        public IActionResult ShowCategory(int categoryId)
        {
            ViewBag.Category = dbContext.Categories.Include( c => c.Products)
            .ThenInclude( a => a.Prod)
            .FirstOrDefault( c=>c.CategoryId == categoryId);

            ViewBag.NotOnCategory = dbContext.Products.Include( p => p.Cats)
            .Where(p=>p.Cats.All( a=>a.CategoryId != categoryId))
            .ToList();

            return View("ShowCategories");
        }

        /////////////METHODS//////////////////////////////
        [HttpPost("add/product")]
        public IActionResult AddProduct(Product newProd)
        {
            if(ModelState.IsValid)
            {
                dbContext.Products.Add(newProd);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Products = dbContext.Products.ToList();
                return View("Index");
            }
        }

        [HttpPost("add/category")]
        public IActionResult AddCategory(Category newCat)
        {
            if(ModelState.IsValid)
            {
                dbContext.Categories.Add(newCat);
                dbContext.SaveChanges();
                return RedirectToAction("Categories");
            }
            else
            {
                ViewBag.Categories = dbContext.Categories.ToList();
                return View("Categories");
            }
        }

        [HttpPost("process/{status}")]
        public IActionResult Process(string status, Association newAssoc)
        {
            dbContext.Associations.Add(newAssoc);
            dbContext.SaveChanges();

            if(status == "product")
            {
                return Redirect($"/product/{newAssoc.ProductId}");
            }
            else{
                return Redirect($"/category/{newAssoc.CategoryId}");
            }
        }


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public IActionResult Privacy()
        {
            ViewBag.Categories = dbContext.Categories.ToList();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
