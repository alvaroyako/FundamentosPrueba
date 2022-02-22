using ExamenASPÁlvaroMoyaHerraiz.Models;
using ExamenASPÁlvaroMoyaHerraiz.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenASPÁlvaroMoyaHerraiz.Controllers
{
    public class GenerosController : Controller
    {
        private RepositoryLibros repo;

        public GenerosController(RepositoryLibros repo)
        {
            this.repo = repo;
        }

        public IActionResult LibrosGenero(int idgenero)
        {
            List<Libro> libros = this.repo.LibrosGenero(idgenero);
            return View(libros);
        }
    }
}
