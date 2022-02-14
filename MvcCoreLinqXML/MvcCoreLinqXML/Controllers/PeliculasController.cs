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

        public IActionResult EscenaPelicula(int idpelicula,int? posicion)
        {
            if (posicion == null)
            {
                posicion = 0;
            }
            int numeroregistros = 0;
            Escena escena = this.repo.MostrarEscena(1, posicion.Value, ref numeroregistros);
            ViewData["REGISTROS"] = "Escena "+(posicion+1)+" de "+ numeroregistros;
            int siguiente = posicion.Value + 1;
            if (siguiente >= numeroregistros)
            {
                siguiente = 0;
            }
            int anterior = posicion.Value - 1;
            if (anterior < 0)
            {
                anterior = numeroregistros - 1;
            }
            ViewData["SIGUIENTE"] = siguiente;
            ViewData["ANTERIOR"] = anterior;
            
            return View(escena);
        }

        public IActionResult DetallesPelicula (int idpelicula)
        {
            Pelicula peli = this.repo.FindPelicula(idpelicula);
            return View (peli);
        }
    }
}
