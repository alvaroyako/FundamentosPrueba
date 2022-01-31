using Microsoft.AspNetCore.Mvc;
using MvcCoreVistasParciales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.Controllers
{
    public class CochesController : Controller
    {
        private List<Coche> Cars;

        public CochesController()
        {
            this.Cars = new List<Coche>
            {
                new Coche{IdCoche=1,Marca="Pontiac",Modelo="FireBird", VelocidadMaxima=320},
                new Coche{IdCoche=2,Marca="Chevrolet",Modelo="Camaro", VelocidadMaxima=120},
                new Coche{IdCoche=3,Marca="Ferrari",Modelo="X13", VelocidadMaxima=420},
                new Coche{IdCoche=4,Marca="Toyota",Modelo="Yaris", VelocidadMaxima=150}
            };
        }

        public IActionResult Index()
        {
            return View(this.Cars);
        }

        //Esta vista no tendra nada al cargar
        //En su interior, cargaremos vistas parciales
        //Con JQUERY
        //Tendremos una vista parcial con todos los coches
        public IActionResult PeticionAsincrona()
        {
            return View();
        }

        //Necesitamos un metodo que sea llamado mediante
        //load() de jquery
        //los metodos IACTIONRESULT siempre devuelven
        //PartialView
        public IActionResult _CochesPartial()
        {
            return PartialView("_CochesPartial", this.Cars);
        }

        public IActionResult _CochesDetailsPartial(int idcoche)
        {
            Coche car = this.Cars.SingleOrDefault(z => z.IdCoche == idcoche);
            return PartialView("_CochesDetailsPartial", car);
        }
    }
}
