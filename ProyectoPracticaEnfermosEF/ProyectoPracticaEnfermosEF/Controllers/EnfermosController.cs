using Microsoft.AspNetCore.Mvc;
using ProyectoPracticaEnfermosEF.Models;
using ProyectoPracticaEnfermosEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoPracticaEnfermosEF.Controllers
{
    public class EnfermosController : Controller
    {
        private RepositoryEnfermo repo;

        public EnfermosController(RepositoryEnfermo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MostrarEnfermos()
        {
            List<Enfermo> enfermos = this.repo.GetEnfermos();
            return View(enfermos);
        }
    }
}
