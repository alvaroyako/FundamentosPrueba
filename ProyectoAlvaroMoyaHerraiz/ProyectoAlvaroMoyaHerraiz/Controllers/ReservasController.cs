using Microsoft.AspNetCore.Mvc;
using ProyectoAlvaroMoyaHerraiz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAlvaroMoyaHerraiz.Controllers
{
    public class ReservasController : Controller
    {
        private RepositoryUtopiaSqlServer repo;
        public ReservasController(RepositoryUtopiaSqlServer repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string fecha,int asistentes,string hora)
        {
            this.repo.CrearReserva(fecha, asistentes, hora);
            return View();
        }
    }
}
