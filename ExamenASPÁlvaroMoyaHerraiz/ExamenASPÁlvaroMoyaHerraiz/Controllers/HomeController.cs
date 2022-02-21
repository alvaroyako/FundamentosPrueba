using ExamenASPÁlvaroMoyaHerraiz.Models;
using ExamenASPÁlvaroMoyaHerraiz.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ExamenASPÁlvaroMoyaHerraiz.Filters;
using System.Security.Claims;

namespace ExamenASPÁlvaroMoyaHerraiz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private RepositoryLibros repo;

        public HomeController(ILogger<HomeController> logger, RepositoryLibros repo)
        {
            this.repo = repo;
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    List<Libro> libros = this.repo.GetLibros();
        //    return View(libros);
        //}

        [AuthorizeUsuarios]
        public IActionResult GoToHome()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult VerPedidos()
        {
            List<VistaPedido> vistas = this.repo.VerPedidos(int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value));
            return View(vistas);
        }

        public IActionResult Index(int? posicion)
        {
            if (posicion == null)
            {
                posicion = 1;
            }
            int numeroregistros = this.repo.GetNumeroRegistros();
            int numeropagina = 1;
            string html = "<div>";
            for (int i = 1; i <= numeroregistros; i += 4)
            {
                html += "<a href='PaginarGrupoVistaLibro?posicion=" + i + "'>Pagina " + numeropagina + "</a> | ";
                numeropagina += 1;
            }
            html += "</div>";
            ViewData["LINKS"] = html;

            ViewData["NUMEROREGISTROS"] = numeroregistros;
            List<VistaLibro> lista = this.repo.GetGrupoVistaLibro(posicion.Value);
            return View(lista);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
