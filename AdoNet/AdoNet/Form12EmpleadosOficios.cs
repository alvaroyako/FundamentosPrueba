using AdoNet.Context;
using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form12EmpleadosOficios : Form
    {
        EmpleadosContext context;
        public Form12EmpleadosOficios()
        {
            InitializeComponent();
            this.context = new EmpleadosContext();
            List<String> oficios = this.context.GetOficios();
            foreach(string oficio in oficios)
            {
                this.cmbOficio.Items.Add(oficio);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string oficio = this.cmbOficio.SelectedItem.ToString();
            List<Empleado> empleados = this.context.GetEmpleadosOficio(oficio);
            this.lsvEmpleados.Items.Clear();
            foreach(Empleado emp in empleados)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = emp.idEmpleado;
                item.Text = emp.Apellido;
                item.SubItems.Add(emp.Oficio);
                item.SubItems.Add(emp.Salario.ToString());
                this.lsvEmpleados.Items.Add(item);
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            string oficio = this.cmbOficio.SelectedItem.ToString();
            int incremento = int.Parse(this.txtIncremento.Text);
            int modificados = this.context.UpdateEmpleadosOficio(oficio, incremento);
            List<Empleado> empleados = this.context.GetEmpleadosOficio(oficio);
            this.lsvEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = emp.idEmpleado;
                item.Text = emp.Apellido;
                item.SubItems.Add(emp.Oficio);
                item.SubItems.Add(emp.Salario.ToString());
                this.lsvEmpleados.Items.Add(item);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lsvEmpleados.SelectedItems.Count != 0)
            {
                ListViewItem seleccionado = this.lsvEmpleados.SelectedItems[0];
                int idempleado =int.Parse( seleccionado.Tag.ToString());
                int eliminado = this.context.DeleteEmpleado(idempleado);
                string oficio = this.cmbOficio.SelectedItem.ToString();
                List<Empleado> empleados = this.context.GetEmpleadosOficio(oficio);
                this.lsvEmpleados.Items.Clear();
                foreach(Empleado emp in empleados)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = emp.idEmpleado;
                    item.Text = emp.Apellido;
                    item.SubItems.Add(emp.Oficio);
                    item.SubItems.Add(emp.Salario.ToString());
                    this.lsvEmpleados.Items.Add(item);
                }
            }

        }
    }
}
