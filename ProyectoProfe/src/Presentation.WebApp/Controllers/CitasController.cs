using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

using Domain;
using Infrastructure;
using Application;

namespace Presentation.WebApp.Controllers
{
    public class CitasController : Controller
    {
        private readonly CitasDbContext _citasDbContext;
        private readonly PacientesDbContext _pacientesDbContext;
        private readonly SmtpClientEmailService _email;
        public CitasController(IConfiguration configuration)
        {
            _citasDbContext = new CitasDbContext(configuration.GetConnectionString("DefaultConnection"));
            _pacientesDbContext = new PacientesDbContext(configuration.GetConnectionString("DefaultConnection"));
            var config = configuration.GetSection("Smtp");
            _email = new SmtpClientEmailService(config["Displayname"], config["Address"], config["Host"], int.Parse(config["Port"]), config["Username"], config["Password"]);
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

        public IActionResult Create(Guid id)
        {
            // ToDo
            return View("Error");
        }
        [HttpPost]
        public async Task<IActionResult> Create(Cita data)
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
        public IActionResult Edit(Cita data)
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
