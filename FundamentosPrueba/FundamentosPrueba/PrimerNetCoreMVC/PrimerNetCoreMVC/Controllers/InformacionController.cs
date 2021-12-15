using Microsoft.AspNetCore.Mvc;
using PrimerNetCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerNetCoreMVC.Controllers
{
    public class InformacionController : Controller
    {
        //Se puede poner o no aqui [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ControladorVista()
        {
            ViewData["Nombre"] = "Alumno";
            ViewData["Edad"] = 28;

            Persona persona = new Persona();
            persona.Nombre = "Persona Model";
            persona.Edad = 44;
            persona.Email = "personamodel@gmail.com";

            return View(persona);
        }

        public IActionResult VistaControllerGet(string app,int version)
        {
            ViewData["Datos"] = app + ", Version: " + version;
            return View();
        }

        //Metodo Get
        public IActionResult VistaPost()
        {
            return View();
        }

        //Metodo POST
        [HttpPost]
        public IActionResult VistaPost(Persona persona)
        {
            
            return View(persona);
        }

        //GET VistaNumeroDoble
        public IActionResult VistaNumeroDoble(int? numero, string dato)
        {
            if (dato == null)
            {

            }

            if (numero == null)
            {
                ViewBag.Doble = "No hemos recibido ningun numero";
            }
            else
            {
                int doble = numero.Value * 2;
                ViewBag.Doble = "El doble del numero es: " + doble;
            }

            
            return View();
        }
    }
}
