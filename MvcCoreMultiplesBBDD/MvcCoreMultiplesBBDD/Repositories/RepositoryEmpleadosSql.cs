using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcCoreMultiplesBBDD.Data;
using MvcCoreMultiplesBBDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreMultiplesBBDD.Repositories
{
    public class RepositoryEmpleadosSql:IRepositoryEmpleados
    {
        private HospitalContext context;

        public RepositoryEmpleadosSql(HospitalContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleados()
        {
            string sql = "sp_all_empleados";
            var consulta = this.context.Empleados.FromSqlRaw(sql);
            return consulta.ToList();
        }

        public Empleado FindEmpleado(int id)
        {
            return this.context.Empleados.FirstOrDefault(z => z.IdEmpleado == id);

        }

        public void DeleteEmpleado(int id)
        {
            //Empleado empleado = this.FindEmpleado(id);
            //this.context.Empleados.Remove(empleado);
            //this.context.SaveChanges();
            string sql = "sp_delete_empleado @idempleado";
            SqlParameter pamid = new SqlParameter("@idempleado", id);
            this.context.Database.ExecuteSqlRaw(sql, pamid);
        }

        public void UpdateSalarioEmpleado(int idempleado,int incremento)
        {
            Empleado empleado = this.FindEmpleado(idempleado);
            empleado.Salario += incremento;
            this.context.SaveChanges();
        }


    }
}
