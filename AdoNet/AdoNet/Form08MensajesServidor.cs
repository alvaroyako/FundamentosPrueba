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
    public partial class Form08MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form08MensajesServidor()
        {
            InitializeComponent();
            string cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(cadenaconexion);
            this.cn.InfoMessage += Cn_InfoMessage;
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            cargarDepartamentos();
            
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensajes.Text = e.Message;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lblMensajes.Text = "";
            int numero = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            SqlParameter paramNombre = new SqlParameter("@nombre", nombre);
            this.com.Parameters.Add(paramNombre);
            SqlParameter paramNumero = new SqlParameter("@numero", numero);
            this.com.Parameters.Add(paramNumero);
            SqlParameter paramLocalidad = new SqlParameter("@localidad", localidad);
            this.com.Parameters.Add(paramLocalidad);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "insertardepartamento";
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            cargarDepartamentos();
            
        }

        private void cargarDepartamentos()
        {
            this.lstDepartamentos.Items.Clear();
            string sql = "select * from dept";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                string numero = this.reader["DEPT_NO"].ToString();
                string localidad = this.reader["LOC"].ToString();
                string cadena = numero + " - " + nombre + " - " + localidad;
                this.lstDepartamentos.Items.Add(cadena);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
