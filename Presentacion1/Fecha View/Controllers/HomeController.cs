using System;
using Microsoft.AspNetCore.Mvc;

/*
http://localhost:5001/Home/Index
http://localhost:5001/Home/Privacy
http://localhost:5001/Home/Fecha
*/

namespace IM01b2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DateTime fecha = DateTime.Now;        
            return View(model: fecha);
        }
        
        public IActionResult Privacy()
        {
            int n = 5;        
            return View(model: n);
        }
        
        public IActionResult Fecha()
        {
            DateTime f = DateTime.Now;
            return View(model: f); 
        }
    }
}