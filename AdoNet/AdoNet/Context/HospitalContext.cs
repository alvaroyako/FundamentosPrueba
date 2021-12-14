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
    public class HospitalContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public HospitalContext()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .AddJsonFile("config.json");
            IConfigurationRoot config = builder.Build();
            string cadenaconexion = config["cadenaHospitalTajamar"];
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<String> GetHospitales()
        {
            string sql = "select nombre from hospital";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<string> hospitales = new List<string>();
            while (this.reader.Read())
            {
                string hospital = this.reader["NOMBRE"].ToString();
                hospitales.Add(hospital);
            }

            this.reader.Close();
            this.cn.Close();
            return hospitales;
        }

        public List<Plantilla> GetPlantilla(string nombre)
        {
            string sql = "select plantilla.Empleado_no,plantilla.Apellido,plantilla.Funcion,plantilla.T,plantilla.Salario from plantilla inner join hospital on plantilla.HOSPITAL_COD=hospital.HOSPITAL_COD where hospital.nombre=@NOMBRE";
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Plantilla> empleados = new List<Plantilla>();
            while (this.reader.Read())
            {
                Plantilla emp = new Plantilla();
                emp.idEmpleado = int.Parse(this.reader["EMPLEADO_NO"].ToString());
                emp.Apellido = this.reader["Apellido"].ToString();
                emp.Funcion = this.reader["FUNCION"].ToString();
                emp.Turno = this.reader["T"].ToString();
                emp.Salario = int.Parse(this.reader["Salario"].ToString());
                empleados.Add(emp);
            }

            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return empleados;
        }
    }
}
