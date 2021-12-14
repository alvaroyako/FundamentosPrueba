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
using Microsoft.Extensions.Configuration;

namespace AdoNet
{
    public partial class Form11Vistas : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form11Vistas()
        {
            InitializeComponent();
            IConfigurationBuilder builder = new ConfigurationBuilder()
               .AddJsonFile("config.json", true, true);
            IConfigurationRoot config = builder.Build();
            String cadenaconexion = config["CadenaHospitalTajamar"];

            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            string sql = "select * from hospital";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.cmbHospitales.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbHospitales.SelectedItem.ToString();
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@SUMA";
            pamSuma.Value = 0;
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@MEDIA";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@PERSONAS";
            pamPersonas.Value = 0;
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "HOSPITALES_OUTPUT";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["Apellido"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }

            this.reader.Close();
            this.lblMedia.Text = "Media: " + pamMedia.Value;
            this.lblPersonas.Text = "Personas: " + pamPersonas.Value;
            this.lblSuma.Text = "Suma: " + pamSuma.Value;
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
