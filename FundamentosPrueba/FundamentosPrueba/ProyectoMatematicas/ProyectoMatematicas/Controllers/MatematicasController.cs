using Microsoft.AspNetCore.Mvc;
using ProyectoMatematicas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMatematicas.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SumarNumeros()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumeros(int num1, int num2)
        {
            int total = num1 + num2;
            ViewBag.Total = total;
            return View();
        }

        public IActionResult Collatz(int numero)
        {
            List<int> cadena = new List<int>();
            
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                    cadena.Add(numero);
                }
                else
                {
                    numero = (numero * 3) + 1;
                    cadena.Add(numero);
                }

            }
            return View(cadena);
        }

        public IActionResult TablaMultiplicar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicar(int num)
        {
            List <Multiplicacion> tabla= new List<Multiplicacion>();
            for(int i = 0; i <= 10; i++)
            {
                Multiplicacion mult = new Multiplicacion();
                mult.Operacion = num + "*" + i;
                mult.Resultado = num * i;
                tabla.Add(mult);
            }
            return View(tabla);
        }
    }
}
