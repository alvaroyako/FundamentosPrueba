using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdoNet
{
    public partial class Form02BuscadorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;


        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            string cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            //Tambien indicar conexion que utiliza nuestro comando
            this.com.Connection = this.cn;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = this.txtSalario.Text;
            string sql = "select * from emp where salario>" + dato;
            this.lstEmpleados.Items.Clear();

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read())
            {
                string apellido = this.reader["apellido"].ToString();
                string sal = this.reader["salario"].ToString();
                this.lstEmpleados.Items.Add(apellido + " - " + sal);
            }
            this.reader.Close();
            this.cn.Close();


        }

        private void btnOficio_Click(object sender, EventArgs e)
        {
            string oficio = this.txtOficio.Text;
            string sql = "select * from emp where oficio='" + oficio+"'";
            this.lstEmpleados.Items.Clear();
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read())
            {
                string apellido = this.reader["apellido"].ToString();
                string ofi = this.reader["oficio"].ToString();
                this.lstEmpleados.Items.Add(apellido + " - " + ofi);
            }

            this.reader.Close();
            this.cn.Close();
        }
    }
}
