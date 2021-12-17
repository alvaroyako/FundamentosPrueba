using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Examen_AlvaroMoyaHerraiz.Models;

#region
//ALTER PROCEDURE CARGARCLIENTES
//AS
//SELECT EMPRESA FROM CLIENTES
//GO

//EXEC CARGARCLIENTES


//ALTER PROCEDURE CARGARDATOSCLIENTES (@EMPRESA NVARCHAR(50))
//AS
//	SELECT * FROM CLIENTES WHERE EMPRESA=@EMPRESA
//GO

//EXEC CARGARDATOSCLIENTES 'Bloter'
#endregion

namespace Examen_AlvaroMoyaHerraiz.Context
{
    public class ExamenContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public ExamenContext()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .AddJsonFile("config.json");
            IConfigurationRoot config = builder.Build();
            string cadenaconexion = config["CadenaExamen"];
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<String> GetClientes()
        {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "CARGARCLIENTES";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<string> empresas = new List<string>();
            while (this.reader.Read())
            {
                string empresa = this.reader["EMPRESA"].ToString();
                empresas.Add(empresa);
            }

            this.reader.Close();
            this.cn.Close();
            return empresas;
        }

       public List<Cliente> GetDatosCliente(string empresa)
        {
            this.com.Parameters.AddWithValue("Empresa", empresa);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "CARGARDATOSCLIENTES";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Cliente> datos = new List<Cliente>();
            while (this.reader.Read())
            {
                Cliente cli = new Cliente();
                cli.CodigoCliente = this.reader["CodigoCliente"].ToString();
                cli.Empresa = this.reader["Empresa"].ToString();
                cli.Contacto = this.reader["Contacto"].ToString();
                cli.Cargo = this.reader["Cargo"].ToString();
                cli.Ciudad = this.reader["Ciudad"].ToString();
                cli.Telefono = int.Parse(this.reader["Telefono"].ToString());
                datos.Add(cli);
            }

            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return datos;
        }

        public string GetCodigoCliente(string empresa)
        {
            string sql = "select CodigoCliente from clientes where empresa=@EMPRESA ";
            this.com.Parameters.AddWithValue("@EMPRESA", empresa);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            string codigo=this.reader["CodigoCliente"].ToString();
               

            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return codigo;
        }

        public List<Pedido> GetPedidosCliente(string codigo)
        {
            string sql = "select * from pedidos where CodigoCliente=@CODIGO";
            this.com.Parameters.AddWithValue("@CODIGO", codigo);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Pedido> pedidos = new List<Pedido>();
            while (this.reader.Read())
            {
                Pedido ped = new Pedido();
                ped.CodigoPedido = this.reader["CodigoPedido"].ToString();
                ped.CodigoCliente = this.reader["CodigoCliente"].ToString();
                ped.FechaEntrega = this.reader["CodigoPedido"].ToString();
                ped.FormaEnvio = this.reader["FormaEnvio"].ToString();
                ped.Importe = int.Parse(this.reader["Importe"].ToString());
                
                pedidos.Add(ped);
            }

            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return pedidos;
        }

        public List<Pedido> GetDatosPedido(string codigopedido)
        {
            string sql = "select * from pedidos where CodigoPedido=@CODIGOPEDIDO";
            this.com.Parameters.AddWithValue("@CODIGOPEDIDO", codigopedido);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Pedido> pedidos = new List<Pedido>();
            while (this.reader.Read())
            {
                Pedido ped = new Pedido();
                ped.CodigoPedido = this.reader["CodigoPedido"].ToString();
                ped.CodigoCliente = this.reader["CodigoCliente"].ToString();
                ped.FechaEntrega = this.reader["FechaEntrega"].ToString();
                ped.FormaEnvio = this.reader["FormaEnvio"].ToString();
                ped.Importe = int.Parse(this.reader["Importe"].ToString());

                pedidos.Add(ped);
            }

            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return pedidos;
        }

        public int  InsertarPedido(string codigopedido,string codigocliente, string fecha, string forma, int importe)
        {
            string sql = "insert into pedidos values(@CodigoPedido,@CodigoCliente,@FechaEntrega,@FormaEnvio,@Importe)";
            this.com.Parameters.AddWithValue("@CodigoPedido", codigopedido);
            this.com.Parameters.AddWithValue("@CodigoCliente", codigocliente);
            this.com.Parameters.AddWithValue("@FechaEntrega", fecha);
            this.com.Parameters.AddWithValue("@FormaEnvio", forma);
            this.com.Parameters.AddWithValue("@Importe", importe);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int insertados = this.com.ExecuteNonQuery();

            this.cn.Close();
            this.com.Parameters.Clear();
            return insertados;
        }


    }
}
