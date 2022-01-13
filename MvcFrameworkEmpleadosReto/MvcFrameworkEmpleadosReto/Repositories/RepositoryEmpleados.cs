﻿using MvcFrameworkEmpleadosReto.Data;
using MvcFrameworkEmpleadosReto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcFrameworkEmpleadosReto.Repositories
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
            var consulta = from datos in this.context.Empleados select datos;
            return consulta.ToList();
        }
    }
}