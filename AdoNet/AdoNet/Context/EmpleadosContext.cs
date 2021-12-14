using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using AdoNet.Models;

namespace AdoNet.Context
{
    public class EmpleadosContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public EmpleadosContext()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .AddJsonFile("config.json");
            IConfigurationRoot config = builder.Build();
            string cadenaconexion = config["cadenaHospitalTajamar"];
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<String> GetOficios()
        {
            string sql = "select distinct oficio from emp";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader=this.com.ExecuteReader();

            List<string> oficios = new List<string>();
            while (this.reader.Read())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }

            this.reader.Close();
            this.cn.Close();
            return oficios;
        }

        public List<Empleado> GetEmpleadosOficio(string oficio)
        {
            string sql = "select * from emp where oficio=@OFICIO";
            this.com.Parameters.AddWithValue("@OFICIO", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Empleado> empleados = new List<Empleado>();
            while (this.reader.Read())
            {
                Empleado emp = new Empleado();
                emp.idEmpleado = int.Parse(this.reader["EMP_NO"].ToString());
                emp.Apellido = this.reader["Apellido"].ToString();
                emp.Oficio= this.reader["OFICIO"].ToString();
                emp.Salario = int.Parse(this.reader["Salario"].ToString());
                empleados.Add(emp);
            }

            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return empleados;
        }

        public int UpdateEmpleadosOficio(string oficio, int incremento)
        {
            string sql = "update emp set salario=salario+@Incremento " + " where oficio=@OFICIO";
            this.com.Parameters.AddWithValue("@INCREMENTO", incremento);
            this.com.Parameters.AddWithValue("@OFICIO", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int modificados = this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();
            return modificados;
        }

        public int DeleteEmpleado(int idempleado)
        {
            string sql = "delete from emp where emp_no=@EMPNO";
            this.com.Parameters.AddWithValue("EMPNO", idempleado);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int eliminados = this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();
            return eliminados;
        }
    }
}
