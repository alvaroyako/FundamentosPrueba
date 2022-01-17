using Microsoft.AspNetCore.Mvc;
using MvcNetCoreEF2022.Models;
using MvcNetCoreEF2022.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreEF2022.Controllers
{
    public class DoctoresController : Controller
    {
        private RepositoryDoctores repo;

        public DoctoresController(RepositoryDoctores repo)
        {
            this.repo = repo;
        }

        public IActionResult DoctoresHospital(int idhospital)
        {
            List<Doctor> doctores = this.repo.GetDoctoresHospital(idhospital);
            return View(doctores);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DoctoresSalario()
        {
            List<Doctor> doctores = this.repo.GetDoctores();
            return View(doctores);
        }

        [HttpPost]
        public IActionResult DoctoresSalario(int salario)
        {
            List<Doctor> doctores = this.repo.GetDoctorSalario(salario);
            if (doctores == null)
            {
                ViewBag.Mensaje = "No se ha encontrado ningun doctor";
                return View();
            }
            else
            {
                return View(doctores);
            }
        }
    }
}
