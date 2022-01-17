using MvcCrudDepartamentosEFCore2022.Data;
using MvcCrudDepartamentosEFCore2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrudDepartamentosEFCore2022.Repositories
{
    public class RepositoryDoctores
    {
        private HospitalesContext context;

        public RepositoryDoctores(HospitalesContext context)
        {
            this.context = context;
        }


        public Doctor FindEmpleado(int id)
        {
            return
            this.context.Doctores.FirstOrDefault(z => z.IdDoctor == id);
        }

        public ResumenDoctores GetResumenDoctores(int idhospital)
        {
            List<Doctor> doctores =
                this.context.Doctores.Where
                (x => x.IdHospital == idhospital).ToList();
            if (doctores.Count() == 0)
            {
                return null;
            }
            else
            {
                ResumenDoctores resumen = new ResumenDoctores();
                resumen.MaximoSalario =
                    doctores.Max(z => z.Salario);
                resumen.MediaSalarial =
                    doctores.Average(z => z.Salario);
                resumen.SumaSalarial =
                    doctores.Sum(z => z.Salario);
                resumen.Doctores = doctores;
                return resumen;
            }
        }
    }
}
