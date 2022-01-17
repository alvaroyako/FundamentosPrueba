using MvcNetCoreEF2022.Data;
using MvcNetCoreEF2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreEF2022.Repositories
{
    public class RepositoryHospital
    {
        private HospitalesContext context;
        public RepositoryHospital(HospitalesContext context)
        {
            this.context = context;
        }

        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.context.Hospitales
                                  select datos;
            return consulta.ToList();
        }

        public Hospital FindHospital(int idhospital)
        {
            var consulta = from datos in this.context.Hospitales
                           where datos.IdHospital == idhospital
                           select datos;
            if (consulta.Count() == 0)
            {
                return null;
            }
            else
            {
                return consulta.First();
            }
        }


    }
}
