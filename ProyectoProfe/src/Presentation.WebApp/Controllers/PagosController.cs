using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using Domain;
using Infrastructure;
using Application;

namespace Presentation.WebApp.Controllers
{
    public class PagosController : Controller
    {

        private readonly PagosDbContext _PagosDbContext;
        public PagosController(IConfiguration configuration)
        {
            _PagosDbContext = new PagosDbContext(configuration.GetConnectionString("DefaultConnection"));
        }

        public IActionResult Index()
        {
            var data = _PagosDbContext.List();
            return View(data);
        }

        public IActionResult Details(Guid id)
        {
            var data = _PagosDbContext.Details(id);
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Pago data, IFormFile file)
        {
            if (file != null)
            {
                data.Foto = FileConverterService.ConvertToBase64(file.OpenReadStream());
            }
            _PagosDbContext.Create(data);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id)
        {
            var data = _PagosDbContext.Details(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Pago data, IFormFile file)
        {
            if (file != null)
            {
                data.Foto = FileConverterService.ConvertToBase64(file.OpenReadStream());
            }
            _PagosDbContext.Edit(data);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            _PagosDbContext.Delete(id);
            return RedirectToAction("Index");
        }
    }
}