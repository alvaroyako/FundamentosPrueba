using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProyectoClases
{

    

    public class HelperCoches
    {
        public CochesCollection Coches; 
        XmlSerializer xmlSerial;

        public HelperCoches()
        {
            this.Coches = new CochesCollection();
            this.xmlSerial = new XmlSerializer(typeof(CochesCollection));
        }


        public void ReadFileCoches(string path)
        {
            FileInfo file = new FileInfo(path);
            using (TextReader reader = file.OpenText())
            {
                String data = reader.ReadToEnd();
                reader.Close();
                this.CreateCoches(data);
            }
        }


        public async Task SaveFileCochesAsync(string path)
        {
            StreamWriter writer = new StreamWriter("listacoches.xml");
            this.xmlSerial.Serialize(writer, this.Coches);
            await writer.FlushAsync();
            writer.Close();
        }

        private void CreateCoches(string data)
        {
            this.Coches.Clear();
            string[] datoscoches = data.Split('@');
            foreach (string d in datoscoches)
            {
                string[] propiedades = d.Split(',');
                Coche coche = new Coche();
                coche.Marca = propiedades[0];
                coche.Modelo = propiedades[1];
                //coche.Imagen = propiedades[2];
                this.Coches.Add(coche);
            }
        }

        public async void GuardarSerialize()
        {
            StreamWriter writer = new StreamWriter("listacoches.xml");
            this.xmlSerial.Serialize(writer, this.Coches);
            await writer.FlushAsync();
            writer.Close();
        }

        public void LeerSerialize()
        {
            StreamReader reader = new StreamReader("listacoches.xml");
            this.xmlSerial.Deserialize(reader);
            reader.Close();
        }
    }

}
