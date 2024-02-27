using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
            //return RedirectToAction("index");
        }
    }
}
