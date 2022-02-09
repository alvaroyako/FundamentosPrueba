using Microsoft.AspNetCore.Mvc;
using MvcCoreEliminarEnfermoValidacion.Models;
using MvcCoreEliminarEnfermoValidacion.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEliminarEnfermoValidacion.Controllers
{
    public class EnfermosController : Controller
    {
        private RepositoryEnfermos repo;

        public EnfermosController(RepositoryEnfermos repo)
        {
            this.repo = repo;
        }
        public IActionResult ListaEnfermos()
        {
            List<Enfermo> enfermos = this.repo.GetEnfermos();
            return View(enfermos);
        }

        public IActionResult ConfirmarDelete(int inscripcion)
        {
            return View(this.repo.FindEnfermo(inscripcion));
        }

        public IActionResult Delete(int inscripcion)
        {
            this.repo.DeleteEnfermo(inscripcion);
            ViewData["CONFIRMACION"] = "Enfermo eliminado con exito";
            return RedirectToAction("ListaEnfermos");
        }
    }
}
