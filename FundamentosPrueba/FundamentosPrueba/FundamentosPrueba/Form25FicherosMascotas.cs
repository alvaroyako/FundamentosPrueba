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
    public partial class Form25FicherosMascotas : Form
    {
        HelperMascotas helper;
        public Form25FicherosMascotas()
        {
            InitializeComponent();
            this.helper = new HelperMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach(Mascota mascota in this.helper.Mascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            this.helper.Mascotas.Add(mascota);
            this.lstMascotas.Items.Add(mascota.Nombre);
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                this.helper.ReadFileMascotas(path);
                this.DibujarMascotas();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                String path = sfd.FileName;
                await this.helper.SaveFileMascotasAsync(path);
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstMascotas.SelectedIndex != -1){
                Mascota mascota = this.helper.Mascotas[this.lstMascotas.SelectedIndex];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text= mascota.Raza;
            }
        }
    }
}
