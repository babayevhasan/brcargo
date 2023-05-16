using BrcargoSulu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BrcargoSulu.Controllers
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

        public IActionResult Xidmetler()
        {
            return View();
        }

        public IActionResult Rates()
        {
            return View();
        }

        public IActionResult Magazine()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Sifariset()
        {
            return View();
        }
        public IActionResult Baglamalar()
        {
            return View();
        }

        public IActionResult Balance()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }
        public IActionResult Notifications()
        {
            return View();
        }

        public IActionResult Adminpanel()
        {
            return View();
        }

        public IActionResult Adminidare()
        {
            return View();
        }

        public IActionResult Admintesdiq()
        {
            return View();
        }

        public IActionResult Readmore()
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
