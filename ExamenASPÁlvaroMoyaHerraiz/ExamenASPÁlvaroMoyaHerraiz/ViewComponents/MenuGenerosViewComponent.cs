using ExamenASPÁlvaroMoyaHerraiz.Models;
using ExamenASPÁlvaroMoyaHerraiz.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenASPÁlvaroMoyaHerraiz.ViewComponents
{
    public class MenuGenerosViewComponent: ViewComponent
    {
        private RepositoryLibros repo;
        public MenuGenerosViewComponent(RepositoryLibros repo)
        {
            this.repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Genero> generos = this.repo.GetGeneros();
            return View(generos);
        }
    }
}
