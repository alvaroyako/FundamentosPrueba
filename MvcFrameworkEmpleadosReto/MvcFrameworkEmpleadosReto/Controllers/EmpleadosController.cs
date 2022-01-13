using MvcFrameworkEmpleadosReto.Models;
using MvcFrameworkEmpleadosReto.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFrameworkEmpleadosReto.Controllers
{
    public class EmpleadosController : Controller
    {
        public RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        // GET: Empleados
        public ActionResult Index()
        {
            List<Empleado> empleados = this.repo.GetEmpleados();
            return View(empleados);
        }
    }
}