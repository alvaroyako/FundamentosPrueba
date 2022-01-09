using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAlvaroMoyaHerraiz.Controllers
{
    public class JuegosController : Controller
    {
        public IActionResult ConsultarJuegos()
        {
            return View();
        }
    }
}
