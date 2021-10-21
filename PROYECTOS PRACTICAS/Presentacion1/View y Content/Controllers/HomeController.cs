using Microsoft.AspNetCore.Mvc;

/*
http://localhost:5001/Home/Index
http://localhost:5001/Home/About
http://localhost:5001/Home/Contact 
*/

namespace IM01b1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(viewName: "Index2");
        }

        public IActionResult About()
        {
            return View(viewName: "About2");
        }

        public IActionResult Contact()
        {
            return Content("PerroAbout2");
        }
    }
}