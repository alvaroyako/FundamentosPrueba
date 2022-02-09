﻿using MvcSeguridadEmpleados.Data;
using MvcSeguridadEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSeguridadEmpleados.Repositories
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
            return this.context.Empleados.ToList();
        }

        public Empleado ExisteEmpleado(string apellido, int idempleado)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.Apellido == apellido
                           && datos.IdEmpleado == idempleado
                           select datos;
            return consulta.SingleOrDefault();
        }

        public List <Empleado> GetEmpleadosDepartamento(int iddepartamento)
        {
            var consulta = from datos in this.context.Empleados
                           where datos.Departamento == iddepartamento
                           select datos;
            return consulta.ToList();
        }
    }
}
