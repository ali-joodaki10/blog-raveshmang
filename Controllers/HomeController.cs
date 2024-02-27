using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        public ILogger<HomeController> _logger;
        //public DataBaseContext _dataBaseContext;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_dataBaseContext = dataBaseContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //DataBaseContext context = new DataBaseContext();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
