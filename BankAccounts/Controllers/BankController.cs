using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BankAccounts.Context;
using BankAccounts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.Controllers
{

    [Route("account")]
    public class BankController : Controller
    {

        private HomeContext dbContext;
        public BankController(HomeContext context)
        {
            dbContext = context;
        }

        [HttpGet("{userId}")]
        public IActionResult Index()
        {
            User userIndb = LoggedIn();
            if(userIndb == null)
            {
                return RedirectToAction("LogOut", "Home"); // (action , controller)
            }
            ViewBag.User = userIndb;
            ViewBag.Balance = userIndb.MyTransactions.Sum( t => t.Amount ); 

            return View();
        }

        [HttpPost("proces")]
        public IActionResult Process(Transaction amount)
        {
            if(ModelState.IsValid)
            {
                double bal = userIndb.MyTransactions.Sum( t => t.Amount );
                if(bal + amount.Amount < 0)
                {
                    ModelState.AddModelError("Amount", "You don't have the funds.");
                    ViewBag.User = userIndb;
                    ViewBag.Balance = bal; //from line 46 
                }
            }
            else
            {
                ViewBag.User = userIndb;
                ViewBag.Balance = userIndb.MyTransactions.Sum( t => t.Amount ); 
                return View("Index");
            }
        }
    
    private User LoggedIn() 
        {
            User LogIn = dbContext.Users.Include( u => u.MyTransactions).FirstOrDefault( u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            
            return LogIn;
        }
    }
}