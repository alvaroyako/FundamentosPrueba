using Microsoft.AspNetCore.Mvc;
using MvcCrudDepartamentosEFCore2022.Models;
using MvcCrudDepartamentosEFCore2022.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrudDepartamentosEFCore2022.Controllers
{
    public class EmpleadosController : Controller
    {
        private RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmpleadosResumen(int iddepartamento)
        {
            ResumenEmpleados resumen =
                this.repo.GetResumenEmpleados(iddepartamento);
            if (resumen == null)
            {
                ViewBag.Mensaje = "No existen empleados en el departamento";
                return View();
            }
            else
            {
                return View(resumen);
            }
        }

    }
}
