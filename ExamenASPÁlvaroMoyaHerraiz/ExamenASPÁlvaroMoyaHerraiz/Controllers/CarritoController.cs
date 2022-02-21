using ExamenASPÁlvaroMoyaHerraiz.Extensions;
using ExamenASPÁlvaroMoyaHerraiz.Filters;
using ExamenASPÁlvaroMoyaHerraiz.Models;
using ExamenASPÁlvaroMoyaHerraiz.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ExamenASPÁlvaroMoyaHerraiz.Controllers
{
    public class CarritoController : Controller
    {
        private RepositoryLibros repo;
        public CarritoController(RepositoryLibros repo)
        {
            this.repo = repo;
        }

        public IActionResult AñadirCarrito(int? id)
        {
            if (id != null)
            {
                List<int> carrito;
                if (HttpContext.Session.GetObject<List<int>>("CARRITO") == null)
                {
                    carrito = new List<int>();
                }
                else
                {
                    carrito = HttpContext.Session.GetObject<List<int>>("CARRITO");
                }
                if (carrito.Contains(id.Value) == false)
                {
                    carrito.Add(id.Value);
                    HttpContext.Session.SetObject("CARRITO", carrito);
                }
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Carrito(int? id)
        {
            List<int> carrito = HttpContext.Session.GetObject<List<int>>("CARRITO");
            if (carrito == null)
            {
                return View();
            }
            else
            {
                if (id != null)
                {
                    carrito.Remove(id.Value);
                    HttpContext.Session.SetObject("CARRITO", carrito);
                }

                List<Libro> libros = this.repo.BuscarLibros(carrito);
                return View(libros);
            }
        }

        [AuthorizeUsuarios]
        public IActionResult CompraCarrito()
        {
            List<int> idslibros = HttpContext.Session.GetObject<List<int>>("CARRITO");
            int idusuario = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            int idfactura = this.repo.GetMaxIdFactura();
            DateTime fecha = DateTime.Now;
            foreach (int id in idslibros)
            {
                Libro libro = this.repo.FindLibro(id);
                int idpedido = this.repo.GetMaxIdPedido();
                this.repo.CreateCompras(idpedido,idfactura,fecha,id, idusuario);
            }
            HttpContext.Session.Remove("CARRITO");
            return RedirectToAction("VerPedidos", "Home");
        }
    }
}
