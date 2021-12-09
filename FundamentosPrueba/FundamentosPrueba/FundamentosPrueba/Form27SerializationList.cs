using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using ProyectoClases;

namespace FundamentosPrueba
{
    public partial class Form27SerializationList : Form
    {
        XmlSerializer xmlSerial;
        MascotasCollection mascotas;
        public Form27SerializationList()
        {
            InitializeComponent();
            this.xmlSerial = new XmlSerializer(typeof(MascotasCollection));
            this.mascotas = new MascotasCollection();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Anios =int.Parse(this.txtAnios.Text);
            this.mascotas.Add(mascota);
            PintarMascotas();
        }

        private void PintarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach(Mascota mascota in this.mascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("listamascotas.xml");
            this.xmlSerial.Serialize(writer, this.mascotas);
            await writer.FlushAsync();
            writer.Close();
            this.lstMascotas.Items.Clear();
            this.mascotas.Clear();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listamascotas.xml");
            this.mascotas = (MascotasCollection)
                this.xmlSerial.Deserialize(reader);
            reader.Close();
            this.PintarMascotas();
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstMascotas.SelectedIndex;
            if (indice != -1)
            {
                Mascota mascota = this.mascotas[indice];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtAnios.Text = mascota.Anios.ToString();
            }
        }
    }
}
