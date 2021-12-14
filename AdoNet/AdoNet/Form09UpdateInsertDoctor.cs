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
    public partial class Form09UpdateInsertDoctor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form09UpdateInsertDoctor()
        {
            InitializeComponent();
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .AddJsonFile("config.json", true,true);
            IConfigurationRoot config = builder.Build();
            String cadenaconexion = config["CadenaHospitalTajamar"];

            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.cn.InfoMessage += Cn_InfoMessage;
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensaje.Text = e.Message;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.lblMensaje.Text = "";
            int salario = int.Parse(this.txtSalario.Text);
            string id = this.txtId.Text;
            string hospital = this.txtHospital.Text;
            string apellido = this.txtApellido.Text;
            string especialidad = this.txtEspecialidad.Text;
            SqlParameter paramApellido = new SqlParameter("@apellido", apellido);
            this.com.Parameters.Add(paramApellido);
            SqlParameter paramId = new SqlParameter("@id", id);
            this.com.Parameters.Add(paramId);
            SqlParameter paramEspecialidad = new SqlParameter("@especialidad", especialidad);
            this.com.Parameters.Add(paramEspecialidad);
            SqlParameter paramSalario = new SqlParameter("@salario", salario);
            this.com.Parameters.Add(paramSalario);
            SqlParameter paramHospital = new SqlParameter("@hospital", hospital);
            this.com.Parameters.Add(paramHospital);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "actualizar";
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
