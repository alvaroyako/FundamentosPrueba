using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcCoreEmpleadosSession.Extensions;
using MvcCoreEmpleadosSession.Models;
using MvcCoreEmpleadosSession.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEmpleadosSession.Controllers
{
    public class EmpleadosController : Controller
    {
        private RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<Empleado> empleados = this.repo.GetEmpleados();
            return View(empleados);
        }

        public IActionResult SessionSalarios(int? salario) 
        {
            if (salario != null)
            {
                int sumasalarial = 0;
                if (HttpContext.Session.GetString("SUMASALARIAL") != null)
                {
                    sumasalarial = int.Parse(HttpContext.Session.GetString("SUMASALARIAL"));
                }
                sumasalarial += salario.Value;
                HttpContext.Session.SetString("SUMASALARIAL", sumasalarial.ToString());
                ViewData["Mensaje"] = "Salario almacenado: " + salario.Value;
            }
            return View(this.repo.GetEmpleados());
        }

        public IActionResult SumaSalarios()
        {
            return View();
        }

        public IActionResult SessionEmpleados(int? idempleado)
        {
            if (idempleado != null)
            {
                Empleado empleado = this.repo.FindEmpleado(idempleado.Value);
                List<Empleado> empleadossession;
                if (HttpContext.Session.GetObject<List<Empleado>>("EMPLEADOS") != null)
                {
                    empleadossession = HttpContext.Session.GetObject<List<Empleado>>("EMPLEADOS");

                }
                else
                {
                    empleadossession = new List<Empleado>();
                }
                empleadossession.Add(empleado);
                HttpContext.Session.SetObject("EMPLEADOS", empleadossession);
                ViewData["MENSAJE"] = "Empleado " + empleado.IdEmpleado + ", " + empleado.Apellido + " almacenado en Session";

            }
            return View(this.repo.GetEmpleados());
        }

        public IActionResult EmpleadosAlmacenados()
        {
            return View();
        }

        public IActionResult SessionEmpleadosCorrecto(int? idempleado)
        {
            if (idempleado != null)
            {
                List<int> listIdEmpleados;
                if (HttpContext.Session.GetString("IDSEMPLEADOS") == null)
                {
                    listIdEmpleados = new List<int>();
                }
                else
                {
                    listIdEmpleados = HttpContext.Session.GetObject<List<int>>("IDSEMPLEADOS");
                }

                listIdEmpleados.Add(idempleado.Value);
                
                HttpContext.Session.SetObject("IDSEMPLEADOS", listIdEmpleados);
                ViewData["MENSAJE"] = "Empleados almacenados: " + listIdEmpleados.Count;
            }
            return View(this.repo.GetEmpleados());
        }
        public IActionResult EmpleadosAlmacenadosCorrecto(int? ideliminar)
        {
            List<int> listIdEmpleados = HttpContext.Session.GetObject<List<int>>("IDSEMPLEADOS");
            if (listIdEmpleados == null)
            {
                ViewData["MENSAJE"] = "No existen empleados almacenados";
                return View();
            }
            else
            {
                if (ideliminar != null)
                {
                    listIdEmpleados.Remove(ideliminar.Value);
                    if (listIdEmpleados.Count == 0)
                    {
                        //HttpContext.Session.SetObject("IDSEMPLEADOS", null);
                        HttpContext.Session.Remove("IDSEMPLEADOS");
                    }
                    else
                    {
                        HttpContext.Session.SetObject("IDSEMPLEADOS", listIdEmpleados);
                    }

                    
                }
                List<Empleado> empleados = this.repo.GetEmpleadosSession(listIdEmpleados);
                return View(empleados);
            }
           
        }

        [HttpPost]
        public IActionResult EmpleadosAlmacenadosCorrecto(List<int> cantidad)
        {
            HttpContext.Session.SetObject("CANTIDAD", cantidad);
            return RedirectToAction("Compra");
        }

        public IActionResult Compra()
        {
            List<int> cantidad = HttpContext.Session.GetObject<List<int>>("CANTIDAD");
            List<int> listIdEmpleados = HttpContext.Session.GetObject<List<int>>("IDSEMPLEADOS");


            List<string> factura = new List<string>();
            for(int i = 0; i < cantidad.Count(); i++)
            {
                string compra=cantidad[i]+" unidades de "+ this.repo.FindEmpleado(listIdEmpleados[i]).Apellido+"\n";
                factura.Add(compra);
            }
            ViewData["FACTURA"] = factura;
            return View();
        }

        
    }
}
