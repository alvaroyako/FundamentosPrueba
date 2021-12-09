using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosPrueba
{
    public partial class Form21POO : Form
    {
        public Form21POO()
        {
            InitializeComponent();
        }

        private void btnInstanciarPersona_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.Nombre = "Alumno Net";
            person.Edad = 26;
            person.Nacionalidad = Paises.Alemania;
            person.Domicilio = new Direccion();
            person.Domicilio.Calle = "Calle pez";
            person.Genero = TipoGenero.Femenino;
            this.listBox1.Items.Add("GetNombreCompleto(): "+person.GetNombreCompleto(true));
            this.listBox1.Items.Add("Nombre: " + person.Nombre);
            this.listBox1.Items.Add("Edad: " + person.Edad);
            this.listBox1.Items.Add("Nacionalidad: " + person.Nacionalidad);
            this.listBox1.Items.Add("Genero: " + person.Genero);
            person.MetodoParametroOpcional(88);
            person.MetodoParametroOpcional(88,55);
            person.MetodoParametroOpcional(88,parametroopcional:77);

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            Empleado empleado = new Empleado();
            empleado.Nombre = "Empleado";
            empleado.Apellidos = "Net Core";
            this.listBox1.Items.Add("Empleado: " + empleado.GetNombreCompleto());
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            Director dire = new Director();
            dire.Nombre = "M.";
            dire.Apellidos = "Rajoy";
            this.listBox1.Items.Add("Director " + dire.GetNombreCompleto());
        }
    }
}
