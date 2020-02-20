﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LoginReg.Context;
using LoginReg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LoginReg.Controllers {
    public class HomeController : Controller {
        private HomeContext dbContext;

        public HomeController(HomeContext context)
        {
            dbContext = context; 
        }
        public IActionResult Index () {
            return View ();
        }

        [HttpGet ("Login")]
        public IActionResult Login() 
        {
            return View ();
        }

        [HttpPost ("register")]
        public IActionResult Register (User register) {
            if (ModelState.IsValid) 
            {
                if(dbContext.Users.Any (u => u.Email == register.Email)) 
                {
                    ModelState.AddModelError ("Email", "Email is already taken.");
                    return View ("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                register.Password = Hasher.HashPassword(register, register.Password);

                dbContext.Users.Add (register);
                dbContext.SaveChanges ();
                HttpContext.Session.SetInt32 ("UserId", register.UserId);
                return RedirectToAction ("Success");
            } 
            else 
            {
                return View("Index");
            }
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            User userindb = LoggedIn();
            if(userindb == null)
            {
                return RedirectToAction("LogOut");
            }
            return View(userindb);
            }

        [HttpPost("signin")]
        public IActionResult SignIn(LoginUser login)
        {
            if(ModelState.IsValid)
            {
                User dbUser = dbContext.Users.FirstOrDefault(u => u.Email == login.LoginEmail);
                if(dbUser == null)
                {
                    ModelState.AddModelError("LoginEmail", "Email/Password is not a match.");
                    return View("Login");
                }
                PasswordHasher<LoginUser> Hash = new PasswordHasher<LoginUser>();
                var result = Hash.VerifyHashedPassword(login, dbUser.Password, login.LoginPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Email/Password is not a match.");
                    return View("Login");
                }

                HttpContext.Session.SetInt32("UserId", dbUser.UserId);
                return RedirectToAction("Success");
            }
            else
            {
                {
                    return View("Login");
                }
            }
        }


        [HttpGet("logout")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        private User LoggedIn() 
        {
            return dbContext.Users.FirstOrDefault (u => u.UserId == HttpContext.Session.GetInt32 ("UserId"));
        }
    }
}