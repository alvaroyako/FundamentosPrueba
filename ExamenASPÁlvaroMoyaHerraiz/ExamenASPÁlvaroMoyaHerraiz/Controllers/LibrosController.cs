using ExamenASPÁlvaroMoyaHerraiz.Models;
using ExamenASPÁlvaroMoyaHerraiz.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenASPÁlvaroMoyaHerraiz.Controllers
{
    public class LibrosController : Controller
    {
        private RepositoryLibros repo;

        public LibrosController(RepositoryLibros repo)
        {
            this.repo = repo;
        }
        public IActionResult DetallesLibro(int idlibro)
        {
            Libro libro = this.repo.DetallesLibro(idlibro);
            return View(libro);
        }
    }
}
