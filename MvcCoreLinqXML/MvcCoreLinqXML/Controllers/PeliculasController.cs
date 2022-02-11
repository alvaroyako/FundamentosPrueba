using Microsoft.AspNetCore.Mvc;
using MvcCoreLinqXML.Models;
using MvcCoreLinqXML.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreLinqXML.Controllers
{
    public class PeliculasController : Controller
    {
        public RepositoryPeliculas repo;
        public PeliculasController(RepositoryPeliculas repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Pelicula> listPeliculas = this.repo.GetClientes();
            return View(listPeliculas);
        }

        public IActionResult Escenas(int idpelicula)
        {
            List<Escena> escenas = this.repo.MostrarEscenas(idpelicula);
            return View(escenas);
        }
    }
}
