using NetCoreLinqSQL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreLinqSQL.Data
{
    public class EnfermosContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        private SqlDataAdapter adenf;
        private DataTable tablaenf;

        public EnfermosContext()
        {
            string cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            RefreshData();

            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;


        }

        public List<Enfermo> GetEnfermos()
        {
            //Para recuperar datos con ling necesitamos hacerlo sobre la coleccion de filas de la tabla
            var consulta = from datos in this.tablaenf.AsEnumerable()
                           select datos;

            List<Enfermo> enfermos = new List<Enfermo>();

            foreach (var row in consulta)
            {
                Enfermo enf = new Enfermo();
                enf.inscripcion = row.Field<string>("INSCRIPCION");
                enf.Apellido = row.Field<string>("Apellido");
                enf.Direccion = row.Field<string>("DIRECCION");
                enf.Fecha = row.Field<DateTime>("FECHA_NAC").ToString();
                enf.S = row.Field<string>("S");
                enf.NSS = row.Field<string>("NSS");
                enfermos.Add(enf);
            }

            return enfermos;
        }

        public int EliminarEnfermo(int inscripcion)
        {
            string sql = "delete from enfermo where inscripcion=@inscripcion";
            this.com.Parameters.AddWithValue("@inscripcion", inscripcion);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int eliminados = this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();
            RefreshData();
            return eliminados;
        }

        private void RefreshData()
        {
            string cadenaconexion = "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
             string sql = "select * from enfermo";
            this.adenf = new SqlDataAdapter(sql, cadenaconexion);
            this.tablaenf = new DataTable();
            this.adenf.Fill(tablaenf);


        }

    }
}
