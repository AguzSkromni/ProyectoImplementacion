using System;
using System.Collections.Generic; // importar el espacio de nombre
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
            /*List<Empleado> modelo = new List<Empleado>();
            modelo.Add(new Empleado { Edad=45, Nombre="Pedro" });
            modelo.Add(new Empleado { Edad=32, Nombre="Julio" });
            modelo.Add(new Empleado { Edad=65, Nombre="Juan" });
            modelo.Add(new Empleado { Edad=25, Nombre="Luis" });
            
            return View(model: modelo); */
            List<Alumnos> modelo = new List<Alumnos>();
            modelo.Add(new Alumnos("Agustin", 1252, 9));
            modelo.Add(new Alumnos("Pedro", 1253, 8));
            modelo.Add(new Alumnos("Jesus", 1254, 8));
            modelo.Add(new Alumnos("Carlos", 1255, 7));

            return View(model: modelo);
        }

        public IActionResult Suma(int a, int b)
        {
            string resultado = "Suma: " + (a + b); 
            return View(model: resultado);
        }

        public IActionResult Empleado(int edad, string nombre){
            Empleado modelo = new Empleado();
            modelo.Edad = edad;
            modelo.Nombre = nombre;

            return View(modelo);
        }
    }
}