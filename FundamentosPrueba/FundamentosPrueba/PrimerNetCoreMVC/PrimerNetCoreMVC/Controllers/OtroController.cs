using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerNetCoreMVC.Controllers
{
    public class OtroController : Controller
    {
        public IActionResult Otro()
        {
            return View();
        }
    }
}
