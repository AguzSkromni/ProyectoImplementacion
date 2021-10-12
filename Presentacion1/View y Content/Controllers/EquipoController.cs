using Microsoft.AspNetCore.Mvc;

/*
http://localhost:5001/Equipo/Index
http://localhost:5001/Equipo/About
http://localhost:5001/Equipo/Contact 
*/

namespace IM01b1.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult Index()
        {
            return View(viewName: "About");
        }

        public IActionResult About()
        {
            return Content("Contact3");
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}