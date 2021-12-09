using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoClases;

namespace FundamentosPrueba
{
    public partial class Form23TrabajarFicheros : Form
    {
        HelperFileNombres helper;
        public Form23TrabajarFicheros()
        {
            InitializeComponent();
            this.helper = new HelperFileNombres();
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String path = ofd.FileName;
                List<String> nombres = await this.helper.ReadFileNombres(path);
                this.lstNombres.Items.Clear();
                foreach(String nombre in nombres)
                {
                    this.lstNombres.Items.Add(nombre);
                }
            }
            
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            if (s.ShowDialog() == DialogResult.OK)
            {
                string path = s.FileName;
                String contenido = this.GetStringNombres();
                await helper.WriteFileNombresAsync(path, contenido);
                MessageBox.Show("Archivo Guardado");
            }
        }

        public string GetStringNombres()
        {
            string datos = "";
            foreach (string nombre in this.lstNombres.Items)
            {
                datos += nombre + ",";
            }
            datos = datos.Trim(',');
            return datos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            String nombre = this.txtNombre.Text;
            this.lstNombres.Items.Add(nombre);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }
    }
}
