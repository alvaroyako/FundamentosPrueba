using ProyectoMvcCoreSeries.Data;
using ProyectoMvcCoreSeries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMvcCoreSeries.Repositories
{
    public class RepositorySeries
    {
        private SeriesContext context;
        public RepositorySeries(SeriesContext context)
        {
            this.context = context;
        }

        public List<Serie> GetSeries()
        {
            var consulta = from datos in this.context.Series
                           select datos;
            return consulta.ToList();
            
        }

        public Serie FindSerie(int id)
        {
            var consulta = from datos in this.context.Series
                           where datos.IdSerie == id
                           select datos;
            return consulta.FirstOrDefault();
        }


    }
}
