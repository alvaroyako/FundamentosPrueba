using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMatematicas.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
