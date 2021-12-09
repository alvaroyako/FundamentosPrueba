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
    public partial class Form03EliminarEnfermos : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form03EliminarEnfermos()
        {
            InitializeComponent();
            string cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            //Tambien indicar conexion que utiliza nuestro comando
            this.com.Connection = this.cn;

            this.cargarEnfermos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string dato = this.txtInscripcion.Text;
            string sql = "Delete from enfermo where inscripcion=" + dato;

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();

            MessageBox.Show("Enfermos eliminados: " + eliminados);
            this.cargarEnfermos();
        }

        private void cargarEnfermos()
        {
            string sql = "select * from enfermo";
            this.lstEnfermos.Items.Clear();

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read())
            {
                string apellido = this.reader["apellido"].ToString();
                string ins = this.reader["inscripcion"].ToString();
                this.lstEnfermos.Items.Add(apellido + " - " + ins);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
