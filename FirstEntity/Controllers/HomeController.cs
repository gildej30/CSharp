using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstEntity.Models;

namespace FirstEntity.Controllers
{
    public class HomeController : Controller
    {
        private HomeContext dbContext;

        public HomeController(HomeContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<User> AllUsers = dbContext.Users.ToList();

            return View();
        }
    }
}
