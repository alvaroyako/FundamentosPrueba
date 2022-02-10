using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MvcCoreEliminarEnfermoValidacion.Models;
using MvcCoreEliminarEnfermoValidacion.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MvcCoreEliminarEnfermoValidacion.Controllers
{
    public class ManageController : Controller
    {
        private RepositoryEnfermos repo;

        public ManageController(RepositoryEnfermos repo)
        {
            this.repo = repo;
        }
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(string username, string password)
        {
            Doctor doctor = this.repo.ExisteDoctor(username, int.Parse(password));
            if (doctor != null)
            {
                ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                Claim claimName = new Claim(ClaimTypes.Name, doctor.Apellido);
                identity.AddClaim(claimName);
                Claim claimId = new Claim(ClaimTypes.NameIdentifier, doctor.IdDoctor.ToString());
                Claim claimRole = new Claim(ClaimTypes.Role, doctor.Especialidad);
                Claim claimSalario = new Claim("Salario", doctor.Salario.ToString());
                identity.AddClaim(claimId);
                identity.AddClaim(claimRole);
                identity.AddClaim(claimSalario);
                ClaimsPrincipal userPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal);
                string controller = TempData["controller"].ToString();
                string action = TempData["action"].ToString();
                string id = TempData["id"].ToString();
                return RedirectToAction(action, controller,new { id=id});

            }
            else
            {
                ViewData["MENSAJE"] = "Usuario/Password incorrectos";
            }
            return View();
        }

        public IActionResult ErrorAcceso()
        {
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
