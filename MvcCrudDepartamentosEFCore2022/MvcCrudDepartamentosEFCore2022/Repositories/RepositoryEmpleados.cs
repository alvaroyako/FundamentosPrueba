using MvcCrudDepartamentosEFCore2022.Data;
using MvcCrudDepartamentosEFCore2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrudDepartamentosEFCore2022.Repositories
{
    public class RepositoryEmpleados
    {
        private EmpleadosContext context;

        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }


        public Empleado FindEmpleado(int id)
        {
            return
            this.context.Empleados.FirstOrDefault(z => z.IdEmpleado == id);
        }

        public ResumenEmpleados GetResumenEmpleados(int iddepartamento)
        {
            //VOY A UTILIZAR LAMBDA PARA EL FILTRO
            List<Empleado> empleados =
                this.context.Empleados.Where
                (x => x.IdDepartamento == iddepartamento).ToList();
            if (empleados.Count() == 0)
            {
                return null;
            }
            else
            {
                ResumenEmpleados resumen = new ResumenEmpleados();
                resumen.MaximoSalario =
                    empleados.Max(z => z.Salario);
                resumen.MediaSalarial =
                    empleados.Average(z => z.Salario);
                resumen.SumaSalarial =
                    empleados.Sum(z => z.Salario);
                resumen.Empleados = empleados;
                return resumen;
            }
        }
    }
}
