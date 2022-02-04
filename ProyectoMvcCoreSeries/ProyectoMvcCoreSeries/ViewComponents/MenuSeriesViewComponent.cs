using Microsoft.AspNetCore.Mvc;
using ProyectoMvcCoreSeries.Models;
using ProyectoMvcCoreSeries.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMvcCoreSeries.ViewComponents
{
    public class MenuSeriesViewComponent: ViewComponent
    {
        private RepositorySeries repo;
        public MenuSeriesViewComponent(RepositorySeries repo)
        {
            this.repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Serie> series = this.repo.GetSeries();
            return View(series);
        }
    }
}
