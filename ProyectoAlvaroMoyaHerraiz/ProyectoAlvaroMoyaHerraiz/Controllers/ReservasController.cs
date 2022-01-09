using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAlvaroMoyaHerraiz.Controllers
{
    public class ReservasController : Controller
    {
        public IActionResult RealizarReserva()
        {
            return View();
        }

    }
}
