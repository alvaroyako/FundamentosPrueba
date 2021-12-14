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
    public class DepartamentosContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public DepartamentosContext()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .AddJsonFile("config.json");
            IConfigurationRoot config = builder.Build();
            string cadenaconexion = config["cadenaHospitalTajamar"];
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<Departamento> GetDepartamentos()
        {
            string sql = "select * from dept";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Departamento> departamentos = new List<Departamento>();
            while (this.reader.Read())
            {
                Departamento dept = new Departamento();
                dept.deptNum = int.Parse(this.reader["DEPT_NO"].ToString());
                dept.Nombre = this.reader["DNOMBRE"].ToString();
                dept.Localidad = this.reader["LOC"].ToString();
                departamentos.Add(dept);
            }

            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return departamentos;
        }

        public int InsertDepartamentos(int id,string nombre,string localidad)
        {
            string sql = "Insert into dept values (@DEPTNO,@NOMBRE,@LOCALIDAD)";
            this.com.Parameters.AddWithValue("DEPTNO", id);
            this.com.Parameters.AddWithValue("NOMBRE", nombre);
            this.com.Parameters.AddWithValue("LOCALIDAD", localidad);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int insertados = this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();
            return insertados;
        }

        public int UpdateDepartamento(int id,string nombre, string localidad)
        {
            string sql = "update dept set DNOMBRE=@NOMBRE, LOC=@LOCALIDAD  where DEPT_NO=@DEPTNO";
            this.com.Parameters.AddWithValue("DEPTNO", id);
            this.com.Parameters.AddWithValue("NOMBRE", nombre);
            this.com.Parameters.AddWithValue("LOCALIDAD", localidad);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int modificados = this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();
            return modificados;
        }
        public int DeleteDepartamento(int iddepartamento)
        {
            string sql = "delete from dept where DEPT_NO=@DEPTNO";
            this.com.Parameters.AddWithValue("DEPTNO", iddepartamento);
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
