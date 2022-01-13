using Microsoft.AspNetCore.Mvc;
using MvcCrudDepartamentosEFCore2022.Models;
using MvcCrudDepartamentosEFCore2022.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrudDepartamentosEFCore2022.Controllers
{
    public class DoctoresController : Controller
    {
        private RepositoryDoctores repo;

        public DoctoresController(RepositoryDoctores repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DoctoresResumen(int idhospital)
        {
            ResumenDoctores resumen =
                this.repo.GetResumenDoctores(idhospital);
            if (resumen == null)
            {
                ViewBag.Mensaje = "No existen doctores en el hospital";
                return View();
            }
            else
            {
                return View(resumen);
            }
        }
    }
}
