using HospitalLinq.Data;
using HospitalLinq.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalLinq.Controllers
{
    public class PlantillasController : Controller
    {
        PlantillasContext context;

        public PlantillasController()
        {
            this.context = new PlantillasContext();
        }

        public IActionResult PlantillaHospital(int idhospital) 
        {
            ModelPlantillas model = this.context.GetPlantillaHospital(idhospital);
            return View(model);
        }
    }
}
