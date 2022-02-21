using ExamenASPÁlvaroMoyaHerraiz.Models;
using ExamenASPÁlvaroMoyaHerraiz.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ExamenASPÁlvaroMoyaHerraiz.Controllers
{
    public class ManageController : Controller
    {
        private RepositoryLibros repo;

        public ManageController(RepositoryLibros repo)
        {
            this.repo = repo;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login
            (string email, string password)
        {
            Usuario usuario =
                this.repo.ExisteUsuario(email, password);
            if (usuario != null)
            {
                ClaimsIdentity identity =
                    new ClaimsIdentity
                    (CookieAuthenticationDefaults.AuthenticationScheme
                    , ClaimTypes.Name, ClaimTypes.Role);

                identity.AddClaim
                    (new Claim(ClaimTypes.Name, usuario.Nombre));

                identity.AddClaim
                    (new Claim(ClaimTypes.NameIdentifier, usuario.IdUsuario.ToString()));

                identity.AddClaim(new Claim("Apellidos", usuario.Apellidos));

                identity.AddClaim(new Claim("Email", usuario.Email));

                identity.AddClaim(new Claim("Foto", usuario.Foto));

                ClaimsPrincipal user = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync
                    (CookieAuthenticationDefaults.AuthenticationScheme
                    , user);
                string controller =
                    TempData["controller"].ToString();
                string action = TempData["action"].ToString();
                string id = TempData["id"].ToString();
                return RedirectToAction(action, controller
                    , new { id = id });
            }
            else
            {
                ViewData["MENSAJE"] = "Email/Password incorrectos";
                return View();
            }
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("CARRITO");
            return RedirectToAction("Index", "Home");
        }
    }
}
