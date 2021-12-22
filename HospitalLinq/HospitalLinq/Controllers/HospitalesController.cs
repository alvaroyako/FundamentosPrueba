using HospitalLinq.Data;
using HospitalLinq.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalLinq.Controllers
{
    public class HospitalesController : Controller
    {
        HospitalContext context;

        public HospitalesController()
        {
            this.context = new HospitalContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hospital()
        {
            List<Hospital> hospitales = this.context.GetHospitales();
            return View(hospitales);
        }

        public IActionResult InsertarHospital()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertarHospital(string cod, string nom, string dir, string tel, string num)
        {
            int resultado = this.context.InsertarHospitales(cod,nom,dir,tel,num);
             return RedirectToAction("Hospital");

        }

        public IActionResult BorrarHospital(string cod)
        {
            int resultado = this.context.BorrarHospital(cod);
            return RedirectToAction("Hospital");
        }

        public IActionResult ModificarHospital(string cod)
        {
            Hospital hospital = this.context.FindHospital(cod);
            
            return View(hospital);
        }

        [HttpPost]
        public IActionResult ModificarHospital(string cod, string nom, string dir, string tel, string num)
        {
            int resultado = this.context.ModificarHospital(cod,nom,dir,tel,num);
            return RedirectToAction("Hospital");
        }
    }
}
