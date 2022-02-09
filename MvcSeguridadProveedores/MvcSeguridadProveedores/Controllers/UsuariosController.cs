using Microsoft.AspNetCore.Mvc;
using MvcSeguridadProveedores.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSeguridadProveedores.Controllers
{
    public class UsuariosController : Controller
    {

        [AuthorizeUsers]
        public IActionResult Perfil()
        {
            return View();
        }
    }
}
