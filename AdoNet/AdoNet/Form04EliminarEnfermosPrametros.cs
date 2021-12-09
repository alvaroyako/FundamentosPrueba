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
    public partial class Form04EliminarEnfermosPrametros : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form04EliminarEnfermosPrametros()
        {
            InitializeComponent();
            string cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.CargarEnfermos();
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string inscripcion = this.txtInscripcion.Text;
            string sql = "delete from enfermo where inscripcion=@INSCRIPCION";
            SqlParameter paramInscripcion = new SqlParameter();
            paramInscripcion.ParameterName = "@INSCRIPCION";
            paramInscripcion.Value = inscripcion;
            this.com.Parameters.Add(paramInscripcion);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarEnfermos();
        }

        private void CargarEnfermos()
        {
            this.lstEnfermos.Items.Clear();
            string sql = "select * from enfermo";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read())
            {
                string apellido = this.reader["apellido"].ToString();
                string inscripcion = this.reader["inscripcion"].ToString();
                this.lstEnfermos.Items.Add(apellido + " - " + inscripcion);
            }

            this.reader.Close();
            this.cn.Close();
        }
    }
}
