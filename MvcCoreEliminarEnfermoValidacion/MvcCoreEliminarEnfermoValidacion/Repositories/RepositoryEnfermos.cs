using MvcCoreEliminarEnfermoValidacion.Data;
using MvcCoreEliminarEnfermoValidacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEliminarEnfermoValidacion.Repositories
{
    public class RepositoryEnfermos
    {
        private EnfermosContext context;

        public RepositoryEnfermos(EnfermosContext context)
        {
            this.context = context;
        }

        public List<Enfermo> GetEnfermos()
        {
            return this.context.Enfermos.ToList();
        }

        public Enfermo FindEnfermo(int inscripcion)
        {
            var consulta = from datos in this.context.Enfermos
                           where datos.Inscripcion == inscripcion
                           select datos;
            return consulta.FirstOrDefault();
        }

        public void DeleteEnfermo(int inscripcion)
        {
            Enfermo enfermo = this.FindEnfermo(inscripcion);
            this.context.Enfermos.Remove(enfermo);
            this.context.SaveChanges();
        }
    }
}
