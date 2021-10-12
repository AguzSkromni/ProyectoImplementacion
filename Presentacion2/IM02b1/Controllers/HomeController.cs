using System;
using Microsoft.AspNetCore.Mvc;

/*
http://localhost:5001/Home/Index
*/

namespace IM02a3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }

        public IActionResult Empleados(string nombre, int edad)
        {
            Empleado modelo = new Empleado();
            modelo.Nombre = nombre;
            modelo.Edad = edad;
           
            return View(model: modelo); 
        }

        public IActionResult Alumno(string nombre, int cuenta, double promedio)
        {
            Alumno modelo = new Alumno(nombre, cuenta, promedio);

            return View(model: modelo);
        }
    }
}