using Microsoft.AspNetCore.Mvc;
using MvcCoreCifradoBDD.Models;
using MvcCoreCifradoBDD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreCifradoBDD.Controllers
{
    public class UsuariosController : Controller
    {
        private RepositoryUsuarios repo;
        public UsuariosController(RepositoryUsuarios repo)
        {
            this.repo = repo;
        }

        [HttpPost]
        public IActionResult Register(string nombre, string email, string password, string imagen)
        {
            this.repo.RegistrarUsuario(nombre, email, password, imagen);
            ViewData["MENSAJE"] = "Usuario registrado correctamente";
            return View();
        }

       
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(string email,string password)
        {
            Usuario usuario = this.repo.LogInUsuario(email, password);
            if (usuario == null)
            {
                ViewData["MENSAJE"] = "No tienes creenciales correctas";
                return View();
            }
            else
            {
                return View(usuario);
            }
        }
    }
}
