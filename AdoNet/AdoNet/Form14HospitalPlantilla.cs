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
    public partial class Form14HospitalPlantilla : Form
    {
        HospitalContext context;
        public Form14HospitalPlantilla()
        {
            InitializeComponent();
            this.context = new HospitalContext();
            List<String> hospitales = this.context.GetHospitales();
            int movimiento = 0;
            foreach (string hospital in hospitales)
            {
                RadioButton radioBoton = new RadioButton();
                CheckBox chequeaCaja = new CheckBox();

                radioBoton.Location = new Point(0, movimiento);
                chequeaCaja.Location = new Point(0, movimiento + 300);

                radioBoton.Text = hospital;
                chequeaCaja.Text = hospital;

                radioBoton.CheckedChanged += MostrarPlantilla;

                movimiento += 25;
                this.panelControles.Controls.Add(radioBoton);
                this.panelControles.Controls.Add(chequeaCaja);

            }

        }

        private void MostrarPlantilla(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton) sender;
            if (radio.Checked)
            {
                string nombre = radio.Text;
                List<Plantilla> empleados = this.context.GetPlantilla(nombre);
                this.lsvPlantilla.Items.Clear();
                foreach (Plantilla emp in empleados)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = emp.idEmpleado;
                    item.Text = emp.idEmpleado.ToString();
                    item.SubItems.Add(emp.Apellido);
                    item.SubItems.Add(emp.Funcion);
                    item.SubItems.Add(emp.Turno);
                    item.SubItems.Add(emp.Salario.ToString());
                    this.lsvPlantilla.Items.Add(item);
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.panelControles.Controls)
            {
                if(ctrl is CheckBox)
                {
                    CheckBox check = ctrl as CheckBox;
                    if (check.Checked)
                    {
                        string nombre = check.Text;
                        List<Plantilla> empleados = this.context.GetPlantilla(nombre);
                        foreach (Plantilla emp in empleados)
                        {
                            ListViewItem item = new ListViewItem();
                            item.Tag = emp.idEmpleado;
                            item.Text = emp.idEmpleado.ToString();
                            item.SubItems.Add(emp.Apellido);
                            item.SubItems.Add(emp.Funcion);
                            item.SubItems.Add(emp.Turno);
                            item.SubItems.Add(emp.Salario.ToString());
                            this.lsvPlantilla.Items.Add(item);
                        }
                    }
                }
            }
        }
    }
}
