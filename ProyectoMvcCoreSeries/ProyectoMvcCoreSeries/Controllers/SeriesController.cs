using Microsoft.AspNetCore.Mvc;
using ProyectoMvcCoreSeries.Models;
using ProyectoMvcCoreSeries.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMvcCoreSeries.Controllers
{
    public class SeriesController : Controller
    {
        private RepositorySeries repo;

        public SeriesController(RepositorySeries repo)
        {
            this.repo = repo;
        }

        public IActionResult DetallesSerie(int id)
        {
            Serie serie = this.repo.FindSerie(id);
            return View(serie);
        }
    }
}
