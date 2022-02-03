using Microsoft.EntityFrameworkCore;
using MvcCoreEmpleadosSession.Data;
using MvcCoreEmpleadosSession.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEmpleadosSession.Repositories
{
    public class RepositoryEmpleados
    {
        private EmpleadosContext context;
        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            string sql = "sp_all_empleados";
            var consulta = this.context.Empleados.FromSqlRaw(sql);
            empleados = consulta.ToList();
            return empleados;
        }

        public Empleado FindEmpleado(int id)
        {
            return
            this.context.Empleados.FirstOrDefault(z => z.IdEmpleado == id);
        }

        public Empleado FindEmpleadoApellido(string apellido)
        {
            return
            this.context.Empleados.FirstOrDefault(z => z.Apellido == apellido);
        }

        public List<Empleado> GetEmpleadosSession(List<int> idsEmpleados)
        {
            var consulta = from datos in this.context.Empleados where idsEmpleados.Contains(datos.IdEmpleado) select datos;
            if (consulta.Count() == 0)
            {
                return null;
            }
            return consulta.ToList();
        }
    }
}
