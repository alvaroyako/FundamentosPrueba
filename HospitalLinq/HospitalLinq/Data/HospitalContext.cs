using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using HospitalLinq.Models;

namespace HospitalLinq.Data
{
    
    public class HospitalContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        private SqlDataAdapter adhospital;
        private DataTable tablahospital;

        public HospitalContext()
        {
            string cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            RefreshData();

            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        private void RefreshData()
        {
            string cadenaconexion = "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            string sql = "select * from hospital";
            this.adhospital = new SqlDataAdapter(sql, cadenaconexion);
            this.tablahospital = new DataTable();
            this.adhospital.Fill(tablahospital);

        }

        public List<Hospital> GetHospitales()
        {
            var consulta = from datos in this.tablahospital.AsEnumerable()
                           select datos;

            List<Hospital> hospitales = new List<Hospital>();
            foreach(var row in consulta)
            {
                Hospital hos = new Hospital();
                hos.Hospital_Cod = row.Field<string>("HOSPITAL_COD");
                hos.Nombre = row.Field<string>("NOMBRE");
                hos.Direccion = row.Field<string>("DIRECCION");
                hos.Telefono = row.Field<string>("TELEFONO");
                hos.Num_Cama = row.Field<string>("NUM_CAMA");
                hospitales.Add(hos);
            }
            return hospitales;
        }

        public int InsertarHospitales(string cod,string nom,string dir,string tel,string num)
        {
            string sql = "insert into hospital values(@codigo,@nombre,@direccion,@telefono,@cama)";
            this.com.Parameters.AddWithValue("@codigo", cod);
            this.com.Parameters.AddWithValue("@nombre", nom);
            this.com.Parameters.AddWithValue("@direccion", dir);
            this.com.Parameters.AddWithValue("@telefono", tel);
            this.com.Parameters.AddWithValue("@cama", num);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int insertados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return insertados;
        }

        public int BorrarHospital(string codigo)
        {
            string sql = "Delete from hospital where HOSPITAL_COD=@codigo";
            this.com.Parameters.AddWithValue("@codigo", codigo);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return eliminados;
        }

        public int ModificarHospital(string cod, string nom, string dir, string tel, string num)
        {
            string sql = "Update hospital set NOMBRE=@NOM,DIRECCION=@DIR,TELEFONO=@TEL,NUM_CAMA=@NUM WHERE HOSPITAL_COD=@COD";
            this.com.Parameters.AddWithValue("@cod", cod);
            this.com.Parameters.AddWithValue("@nom", nom);
            this.com.Parameters.AddWithValue("@dir", dir);
            this.com.Parameters.AddWithValue("@tel", tel);
            this.com.Parameters.AddWithValue("@num", num);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int modificados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return modificados;
        }

        public Hospital FindHospital(string cod)
        {
            var consulta = from datos in this.tablahospital.AsEnumerable()
                           where datos.Field<string>("HOSPITAL_COD") == cod
                           select datos;

            Hospital hos = new Hospital();
            foreach (var row in consulta)
            {
                hos.Hospital_Cod = row.Field<string>("HOSPITAL_COD");
                hos.Nombre = row.Field<string>("NOMBRE");
                hos.Direccion = row.Field<string>("DIRECCION");
                hos.Telefono = row.Field<string>("TELEFONO");
                hos.Num_Cama = row.Field<string>("NUM_CAMA");
            }
            return hos;
            
        }



    }
}
