using Microsoft.AspNetCore.Mvc;
using ProyectoAlvaroMoyaHerraiz.Models;
using ProyectoAlvaroMoyaHerraiz.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAlvaroMoyaHerraiz.Controllers
{
    public class JuegosController : Controller
    {
        private RepositoryUtopiaSqlServer repo;
        public JuegosController(RepositoryUtopiaSqlServer repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<string> categorias = this.repo.GetCategorias();
            ViewBag.Categorias = categorias;
            List<Juego> juegos = this.repo.GetJuegos();
            return View(juegos);
        }

        [HttpPost]
        public IActionResult Index(string categoria,int precio,string nombre,string accion)
        {
            List<Juego> resultado = new List<Juego>();
            List<string> categorias = this.repo.GetCategorias();
            ViewBag.Categorias = categorias;
            if (accion == "filtrocategorias")
            {
                resultado = this.repo.GetJuegoCategoria(categoria);
                
            }
            else if (accion == "filtroprecios")
            {
                resultado = this.repo.GetJuegoPrecio(precio);
                if (resultado == null)
                {
                    ViewBag.Error = "No se ha podido encontrar ningun juego con este precio";
                    return View();
                }
                
            }
            else if (accion == "filtronombres")
            {
                resultado = this.repo.GetJuegoNombre(nombre);
                if (resultado == null)
                {
                    ViewBag.Error = "No se ha podido encontrar ningun juego con este nombre o similiar";
                    return View();
                }
            }
            return View(resultado);

        }

    }
}
