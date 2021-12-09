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
    public partial class Form24FilesNombres : Form
    {
        HelperFileNombresOK helper;
        public Form24FilesNombres()
        {
            InitializeComponent();
        }

        private void DibujarNombres()
        {
            this.lstNombres.Items.Clear();
            foreach(String nombre in this.helper.Nombres)
            {
                this.lstNombres.Items.Add(nombre);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            String name = this.txtNombre.Text;
            this.helper.Nombres.Add(name);
            this.DibujarNombres();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                this.helper = new HelperFileNombresOK(path);
                this.DibujarNombres();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.helper.WriteFile();
            MessageBox.Show("Datos guardados");
        }
    }
}
