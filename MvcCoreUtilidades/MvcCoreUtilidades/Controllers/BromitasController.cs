using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreUtilidades.Controllers
{
    public class BromitasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
