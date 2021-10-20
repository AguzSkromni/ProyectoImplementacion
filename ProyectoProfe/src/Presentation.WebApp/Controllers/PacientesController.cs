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
    public class PacientesController : Controller
    {
        private readonly PacientesDbContext _pacientesDbContext;
        public PacientesController(IConfiguration configuration)
        {
            _pacientesDbContext = new PacientesDbContext(configuration.GetConnectionString("DefaultConnection"));
        }

        public IActionResult Index()
        {
            var data = _pacientesDbContext.List();
            return View(data);
        }

        public IActionResult Details(Guid id)
        {
            var data = _pacientesDbContext.Details(id);
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Paciente data, IFormFile file)
        {
            _pacientesDbContext.Create(data);
            //return View("Error");
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id)
        {
            var data = _pacientesDbContext.Details(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Paciente data, IFormFile file)
        {
            _pacientesDbContext.Edit(data);
            return View("Index");
        }

        public IActionResult Delete(Guid id)
        {
            _pacientesDbContext.Delete(id);
            return View("Index");
        }
    }
}
