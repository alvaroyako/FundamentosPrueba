using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcCoreCifradoBDD.Helpers;
using MvcCoreCifradoBDD.Models;
using MvcCoreCifradoBDD.Providers;
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
        private HelperUploadFiles helperUpload;
        public UsuariosController(RepositoryUsuarios repo, HelperUploadFiles helperUpload)
        {
            this.repo = repo;
            this.helperUpload = helperUpload;
        }

        

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Register(string nombre, string email, string password, IFormFile imagen)
        {
            string filename = imagen.FileName;
            int idusuario=this.repo.RegistrarUsuario(nombre, email, password, filename);
            filename = idusuario + "_" + filename;
            await this.helperUpload.UploadFileAsync(imagen, Folders.Images,filename);


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
