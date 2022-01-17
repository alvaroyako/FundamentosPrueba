using Microsoft.AspNetCore.Mvc;
using MvcCrudDepartamentosEFCore2022.Models;
using MvcCrudDepartamentosEFCore2022.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrudDepartamentosEFCore2022.Controllers
{
    public class HospitalesController : Controller
    {
        private RepositoryHospitales repo;

        public HospitalesController(RepositoryHospitales repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();
            return View(hospitales);
        }

        public IActionResult Details(int id)
        {
            Hospital hospital = this.repo.FindHospital(id);
            return View(hospital);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Hospital hospital)
        {
            this.repo.InsertarHospital (hospital.Nombre, hospital.Direccion,hospital.Telefono,hospital.Num_Cama);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            this.repo.DeleteHospital(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Hospital hospital = this.repo.FindHospital(id);
            return View(hospital);
        }

        [HttpPost]
        public IActionResult Edit(Hospital hospital)
        {
            this.repo.UpdateHospital(hospital.IdHospital, hospital.Nombre, hospital.Direccion,hospital.Telefono,hospital.Num_Cama);
            return RedirectToAction("Index");
        }
    }
}
