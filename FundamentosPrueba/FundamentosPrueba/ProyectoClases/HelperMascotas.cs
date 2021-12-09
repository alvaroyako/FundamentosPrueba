using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
        }

        public async Task SaveFileMascotasAsync(string path)
        {
            string data = this.GetMascotasString();
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();
            }
        }

        public void ReadFileMascotas(string path)
        {
            FileInfo file = new FileInfo(path);
            using (TextReader reader = file.OpenText())
            {
                String data = reader.ReadToEnd();
                reader.Close();
                this.CreateMascotas(data);
            }
        }
        private String GetMascotasString()
        {
            //nombre,raza@nombre,raza
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                String temp = mascota.Nombre + "," + mascota.Raza;
                data += temp + "@";

            }
            data = data.Trim('@');
            return data;
        }

        private void CreateMascotas(string data)
        {
            this.Mascotas.Clear();
            string[] datosmascotas = data.Split('@');
            foreach(string d in datosmascotas)
            {
                string[] propiedades = d.Split(',');
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }
    }
}
