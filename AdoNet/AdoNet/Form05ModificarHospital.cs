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
    public partial class Form05ModificarHospital : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form05ModificarHospital()
        {
            InitializeComponent();
            string cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.CargarSalas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string sala = this.txtInscripcion.Text;
            string elegido = this.lstSalas.SelectedItem.ToString();
            string sql = "update sala set nombre=@SALA where nombre=@ELEGIDO";
            SqlParameter paramSala = new SqlParameter();
            paramSala.ParameterName = "@SALA";
            paramSala.Value = sala;

            SqlParameter paramElegido = new SqlParameter();
            paramElegido.ParameterName = "@ELEGIDO";
            paramElegido.Value = elegido;

            this.com.Parameters.Add(paramSala);
            this.com.Parameters.Add(paramElegido);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int modificados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarSalas();
        }

        private void CargarSalas()
        {
            this.lstSalas.Items.Clear();
            string sql = "select Nombre from sala group by nombre";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read())
            {
                string nombre = this.reader["nombre"].ToString();
                this.lstSalas.Items.Add(nombre);
            }

            this.reader.Close();
            this.cn.Close();
        }
    }
}
