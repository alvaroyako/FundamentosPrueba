using Microsoft.AspNetCore.Mvc;
using MvcCoreEFProcedures.Models;
using MvcCoreEFProcedures.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEFProcedures.Controllers
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
            List<string> especialidades = this.repo.GetEspecialidad();
            List<Doctor> doctores = this.repo.GetDoctores();
            ViewBag.Especialidades = especialidades;
            return View(doctores);
        }

        [HttpPost]
        public IActionResult Index(string especialidad,int incremento)
        {
            List<string> especialidades = this.repo.GetEspecialidad();
            List<Doctor> doctores = this.repo.RealizarIncremento(especialidad,incremento);
            ViewBag.Especialidades = especialidades;
            return View(doctores);
        }
    }
}
