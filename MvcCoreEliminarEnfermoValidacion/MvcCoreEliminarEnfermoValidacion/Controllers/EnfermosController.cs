using Microsoft.AspNetCore.Mvc;
using MvcCoreEliminarEnfermoValidacion.Filters;
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

        

        [AuthorizeDoctores]
        public IActionResult ConfirmarDelete(string id)
        {
            return View(this.repo.FindEnfermo(id));
        }

         [HttpPost]
            public IActionResult Delete(string id, string accion)
        {

            this.repo.DeleteEnfermo(id);
            
            return RedirectToAction("ListaEnfermos");
        }
    }
}
