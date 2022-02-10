using Microsoft.AspNetCore.Mvc;
using MvcCoreEliminarEnfermoValidacion.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEliminarEnfermoValidacion.Controllers
{
    public class DoctoresController : Controller
    {
        [AuthorizeDoctores]
        public IActionResult PerfilDoctor()
        {
            return View();
        }
    }
}
