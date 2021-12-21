using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using NetCoreLinqSQL.Models;

#region
//create procedure incrementarsalariosoficioempleados
//(@oficio nvarchar(50),@incremento int)
//as
//update emp set salario=salario+@incremento where oficio=@oficio
//go

#endregion

namespace NetCoreLinqSQL.Data
{
    public class EmpleadosContext
    {
        private SqlDataAdapter ademp;
        private DataTable tablaemp;
        private SqlConnection cn;
        private SqlCommand com;


        public EmpleadosContext()
        {
            string cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.RefreshData();

        }

        public int IncrementarSalarioEmpleadosOficio(string oficio, int incremento)
        {
            string sql = "incrementarsalariosoficioempleados";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.StoredProcedure;
            this.cn.Open();
            int results = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.RefreshData();
            return results;
        }

        public List<string> GetOficios()
        {
            var consulta = (from datos in this.tablaemp.AsEnumerable()
                           select datos.Field<string>("OFICIO")).Distinct();
            List<string> oficios = new List<string>();
            foreach(var oficio in consulta)
            {
                oficios.Add(oficio);
            }
            return oficios;
        }

        public List<Empleado> GetEmpleadosOficio(string oficio)
        {
            var consulta = from datos in this.tablaemp.AsEnumerable()
                           where datos.Field<string>("OFICIO") == oficio
                           select datos;
            List<Empleado> empleados = new List<Empleado>();
            foreach(var row in consulta)
            {
                Empleado empleado = new Empleado();
                empleado.IdEmpleado = row.Field<int>("EMP_NO");
                empleado.Apellido = row.Field<string>("Apellido");
                empleado.Oficio = row.Field<string>("OFICIO");
                empleado.Salario = row.Field<int>("Salario");
                empleado.IdDepartamento = row.Field<int>("DEPT_NO");
                empleados.Add(empleado);
            }
            return empleados;
        }

        private void RefreshData()
        {
            string cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            string sql = "select * from emp";
            this.ademp = new SqlDataAdapter(sql, cadenaconexion);
            this.tablaemp = new DataTable();
            this.ademp.Fill(tablaemp);
        }

        public List<Empleado> GetEmpleados()
        {
            //Para recuperar datos con ling necesitamos hacerlo sobre la coleccion de filas de la tabla
            var consulta = from datos in this.tablaemp.AsEnumerable()
                                  select datos;

            List<Empleado> empleados = new List<Empleado>();

            foreach(var row in consulta)
            {
                Empleado emp = new Empleado();
                emp.IdEmpleado = row.Field<int>("EMP_NO");
                emp.Apellido = row.Field<string>("Apellido");
                emp.Oficio = row.Field<string>("Oficio");
                emp.Salario = row.Field<int>("Salario");
                emp.IdDepartamento = row.Field<int>("DEPT_NO");
                empleados.Add(emp);
            }

            return empleados;
        }

        public Empleado FindEmpleado(int idempleado)
        {
            var consulta = from datos in this.tablaemp.AsEnumerable()
                           where datos.Field<int>("EMP_NO") == idempleado
                           select datos;

            var row = consulta.First();
            Empleado emp = new Empleado();
            emp.IdEmpleado = row.Field<int>("EMP_NO");
            emp.Apellido = row.Field<string>("APELLIDO");
            emp.Oficio = row.Field<string>("OFICIO");
            emp.Salario = row.Field<int>("SALARIO");
            emp.IdDepartamento = row.Field<int>("DEPT_NO");
            return emp;
        }

        public List<Empleado> GetEmpleadosOficioSalario(string oficio,int salario)
        {
            var consulta = from datos in this.tablaemp.AsEnumerable()
                           where datos.Field<int>("Salario") >= salario
                           && datos.Field<string>("OFICIO") == oficio
                           select datos;

            if (consulta.Count() == 0)
            {
                return null;
            }
            else
            {
                List<Empleado> empleados = new List<Empleado>();
                foreach(var row in consulta)
                {
                    Empleado empleado = new Empleado();
                    empleado.IdEmpleado = row.Field<int>("EMP_NO");
                    empleado.Apellido = row.Field<string>("Apellido");
                    empleado.Oficio = row.Field<string>("Oficio");
                    empleado.Salario = row.Field<int>("Salario");
                    empleado.IdDepartamento = row.Field<int>("DEPT_NO");
                    empleados.Add(empleado);
                }
                return empleados;
            }

            }
        }
}
