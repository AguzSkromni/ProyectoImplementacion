using System;
using Microsoft.AspNetCore.Mvc;

/*
http://localhost:5001/Home/Index
*/

namespace IM02a2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Empleado modelo = new Empleado();
            modelo.Nombre = "Pedro";
            modelo.Edad = 45;
            
            return View(model: modelo); 
        }
    }
}