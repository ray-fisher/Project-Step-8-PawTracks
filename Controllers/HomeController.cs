using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_Step_8_PawTracks.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Step_8_PawTracks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            IActionResult signup = View(); 
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Registration sr)
        {
            if (ModelState.IsValid)
            {
                UserRepos.AddUser(sr);
                return View("Welcome", sr); 
            }
            else
            {
                return View();
            }
        }

        public IActionResult MyAccount()
        {
            return View();
        }

       
        
        // [HttpGet]
        // public IActionResult PassReset()
        // {
        //     IActionResult passreset = View();
        //     return View();
        // }
        // [HttpPost]
        // public IActionResult PassReset(ForgotPassword pw)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         UserRepos.AddUser(pw);
        //         return View("Error", pw)
        //     }
        //     else
        //     {
        //         return View();
        //     }
        // }


    }
}
