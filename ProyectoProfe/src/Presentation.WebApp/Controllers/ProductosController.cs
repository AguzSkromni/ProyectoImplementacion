using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;

using Domain;
using Infrastructure;
using Application;

namespace Presentation.WebApp.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ProductosDbContext _productosDbContext;
        public ProductosController(IConfiguration configuration)
        {
            _productosDbContext = new ProductosDbContext(configuration.GetConnectionString("DefaultConnection"));
        }

        public IActionResult Index()
        {
            // ToDo
            return View("Error");
        }

        public IActionResult Details(Guid id)
        {
            // ToDo
            return View("Error");
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Producto data, IFormFile file)
        {
            // ToDo
            return View("Error");
        }

        public IActionResult Edit(Guid id)
        {
            // ToDo
            return View("Error");
        }
        [HttpPost]
        public IActionResult Edit(Producto data, IFormFile file)
        {
            // ToDo
            return View("Error");
        }

        public IActionResult Delete(Guid id)
        {
            // ToDo
            return View("Error");
        }
    }
}
