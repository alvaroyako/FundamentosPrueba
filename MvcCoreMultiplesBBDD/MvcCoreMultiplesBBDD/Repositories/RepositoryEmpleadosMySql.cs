using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcCoreMultiplesBBDD.Data;
using MvcCoreMultiplesBBDD.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreMultiplesBBDD.Repositories
{
    public class RepositoryEmpleadosMySql:IRepositoryEmpleados
    {
        private HospitalContext context;

        public RepositoryEmpleadosMySql(HospitalContext context)
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
            string sql = "call sp_find_empleados (idempleado)";
            MySqlParameter pamid = new MySqlParameter("idempleado", id);
            var consulta = this.context.Empleados.FromSqlRaw(sql,pamid);
            Empleado emp = consulta.AsEnumerable().FirstOrDefault();
            return emp;

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

        public void UpdateSalarioEmpleado(int idempleado, int incremento)
        {
            Empleado empleado = this.FindEmpleado(idempleado);
            empleado.Salario += incremento;
            this.context.SaveChanges();
        }
    }
}
