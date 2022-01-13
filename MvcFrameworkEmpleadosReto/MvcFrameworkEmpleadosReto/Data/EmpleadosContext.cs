using MvcFrameworkEmpleadosReto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcFrameworkEmpleadosReto.Data
{
    public class EmpleadosContext : DbContext
    {
        public EmpleadosContext()
        : base(@"Data Source=sqltajamaralvaro.database.windows.net;Initial Catalog=AZUREALVARO;Persist Security Info=True;User ID=adminsql;Password=Admin123") { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}