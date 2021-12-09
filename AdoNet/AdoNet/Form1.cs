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
    public partial class Form1 : Form
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
            this.cadenaconexion = "Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "Connection cambiando de " + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
            }
            this.lblMensaje.BackColor = Color.LightGreen;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.BackColor = Color.LightCoral;

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Declaramos cosulta
            string sql = "select * from emp";
            //Indicamos al comando su conexion
            this.com.Connection = this.cn;
            //Indicamos tipo consulta
            this.com.CommandType = CommandType.Text;
            //Indicamos consulta
            this.com.CommandText = sql;
            //Debemos tener la conexion abierta para los siguientes pasos
            //Ejecutamos consulta
            //Como es un select devuelve un cursor (SqlDataReader)
            this.reader = this.com.ExecuteReader();
            //Vamos a dibujar la primera columna de la consulta y su tipo de dato
            for(int i = 0; i < this.reader.FieldCount; i++)
            {
                string columna = this.reader.GetName(i);
                string tipo = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTiposDato.Items.Add(tipo);
            }


            //VAMOS A RECUPERAR UN APELLIDO
            //Para recuperar registros debemos leer
            //El cursor esta posicionado por defecto en la fila -1 cada vez que leemos,avanza una fila
            while (this.reader.Read())
            {
                string apellido = this.reader["Apellido"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }

            this.reader.Close();

        }
    }
}
