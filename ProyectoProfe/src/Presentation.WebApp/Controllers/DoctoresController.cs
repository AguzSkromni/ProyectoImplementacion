using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using Domain;
using Infrastructure;
using Application;

namespace Presentation.WebApp.Controllers
{
    public class DoctoresController : Controller
    {

        private readonly DoctoresDbContext _DoctoresDbContext;
        public DoctoresController(IConfiguration configuration)
        {
            _DoctoresDbContext = new DoctoresDbContext(configuration.GetConnectionString("DefaultConnection"));
        }

        public IActionResult Index()
        {
            var data = _DoctoresDbContext.List();
            return View(data);
        }

        public IActionResult Details(Guid id)
        {
            var data = _DoctoresDbContext.Details(id);
            return View(data);
        }

        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Doctor data, IFormFile file)
        {
            if (file != null)
            {
                data.Foto = FileConverterService.ConvertToBase64(file.OpenReadStream());
            }

            _DoctoresDbContext.Create(data);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id)
        {
            var data = _DoctoresDbContext.Details(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Doctor data, IFormFile file)
        {
            if (file != null)
            {
                data.Foto = FileConverterService.ConvertToBase64(file.OpenReadStream());
            }
            _DoctoresDbContext.Edit(data);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            _DoctoresDbContext.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
