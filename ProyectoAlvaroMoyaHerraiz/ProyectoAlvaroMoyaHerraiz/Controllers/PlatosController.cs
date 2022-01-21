using Microsoft.AspNetCore.Mvc;
using ProyectoAlvaroMoyaHerraiz.Models;
using ProyectoAlvaroMoyaHerraiz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAlvaroMoyaHerraiz.Controllers
{
    public class PlatosController : Controller
    {

        private RepositoryUtopiaSqlServer repo;
        public PlatosController(RepositoryUtopiaSqlServer repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<Plato> platos = this.repo.GetPlatos();
            return View(platos);
        }
    }
}
