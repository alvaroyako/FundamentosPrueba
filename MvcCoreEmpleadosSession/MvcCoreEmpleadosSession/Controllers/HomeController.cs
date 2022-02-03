using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcCoreEmpleadosSession.Extensions;
using MvcCoreEmpleadosSession.Models;
using MvcCoreEmpleadosSession.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEmpleadosSession.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private RepositoryEmpleados repo;

        public HomeController(ILogger<HomeController> logger, RepositoryEmpleados repo)
        {
            _logger = logger;
            this.repo = repo;
        }

        [HttpPost]
        public IActionResult LogIn(string apellido)
        {
            var consulta = this.repo.FindEmpleadoApellido(apellido);
            if (consulta == null)
            {
                ViewData["FALLO"] = "No hay ningun usuario con ese apellido";
                return View();
            }
            else
            {
                HttpContext.Session.SetObject("USUARIO", consulta);
                return RedirectToAction("Index");
            }
            
        }

        public IActionResult LogIn()
        {

            return View();
        }

        public IActionResult CloseSession()
        {
            HttpContext.Session.Remove("USUARIO");
            return RedirectToAction("Index");
        }

        public IActionResult VaciarCarrito()
        {
            HttpContext.Session.Remove("IDSEMPLEADOS");
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
