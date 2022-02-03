using Microsoft.AspNetCore.Mvc;
using MvcCorePaginacionRegistros.Models;
using MvcCorePaginacionRegistros.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCorePaginacionRegistros.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryHospital repo;

        public DepartamentosController(RepositoryHospital repo)
        {
            this.repo = repo;
        }

        public IActionResult PaginarGrupoVistaDepartamento(int? posicion)
        {
            if (posicion == null)
            {
                posicion = 1;
            }
            int numeroregistros = this.repo.GetNumeroRegistros();
            int numeropagina = 1;
            string html = "<div>";
            for(int i = 1; i <= numeroregistros; i += 2)
            {
                html += "<a href='PaginarGrupoVistaDepartamento?posicion="+i+"'>Pagina "+numeropagina+"</a> | ";
                numeropagina += 1;
            }
            html += "</div>";
            ViewData["LINKS"] = html;

            ViewData["NUMEROREGISTROS"] = numeroregistros;
            List<VistaDepartamento> lista = this.repo.GetGrupoVistaDepartamento(posicion.Value);
            return View(lista);
        }

        public IActionResult PaginarGrupoDepartamentos(int? posicion)
        {
            if (posicion == null)
            {
                posicion = 1;
            }

            int numeroregistros = 0;
            List<Departamento> departamentos = this.repo.GetGrupoDepartamentos(posicion.Value,ref numeroregistros);
            ViewData["NUMEROREGISTROS"] = numeroregistros;
           
            return View(departamentos);
        }

        public IActionResult PaginarRegistroVistaDepartamento(int? posicion)
        {
            if (posicion == null)
            {
                posicion = 1;
            }
            int numregistros = this.repo.GetNumeroRegistros();
            int siguiente = posicion.Value + 1;
            if (siguiente > numregistros)
            {
                siguiente = numregistros;
            }
            int anterior = posicion.Value - 1;
            if (anterior < 1)
            {
                anterior = 1;
            }
            VistaDepartamento vistaDept = this.repo.GetVistaDepartamento(posicion.Value);
            ViewData["ULTIMO"] = numregistros;
            ViewData["SIGUIENTE"] = siguiente;
            ViewData["ANTERIOR"] = anterior;
            return View(vistaDept);
        }
    }
}
