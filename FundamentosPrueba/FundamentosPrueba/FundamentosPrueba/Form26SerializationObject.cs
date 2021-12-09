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
    public partial class Form26SerializationObject : Form
    {
        XmlSerializer xmlserial;
        public Form26SerializationObject()
        {
            InitializeComponent();
            this.xmlserial = new XmlSerializer(typeof(Mascota));
            
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Anios = int.Parse(this.txtAnios.Text);
            StreamWriter writer = new StreamWriter("mascota.xml");
            this.xmlserial.Serialize(writer, mascota);
            await writer.FlushAsync();
            writer.Close();
            this.txtAnios.Text = "";
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("mascota.xml");
            Mascota mascota =(Mascota)this.xmlserial.Deserialize(reader);
            reader.Close();
            this.txtNombre.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
            this.txtAnios.Text = mascota.Anios.ToString();
        }
    }
}
