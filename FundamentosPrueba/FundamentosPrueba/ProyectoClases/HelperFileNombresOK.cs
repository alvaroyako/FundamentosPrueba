using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
     public class HelperFileNombresOK
    {
        private string path;

        public List<String> Nombres { get; set; }

        public HelperFileNombresOK(string path)
        {
            this.path = path;
            this.ReadFile();
        }

        public void ReadFile()
        {
            FileInfo file = new FileInfo(this.path);
            using (TextReader reader = file.OpenText())
            {
                String contenido = reader.ReadToEnd();
                string[] nombres = contenido.Split(',');
                this.Nombres = new List<String>(nombres);

            }
        }

        public void WriteFile()
        {
            String data = "";
            foreach(String name in this.Nombres)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            FileInfo file = new FileInfo(this.path);
            using (TextWriter writer = file.CreateText())
            {
                writer.Write(data);
                writer.Flush();
                writer.Close();
            }
        }


    }
}
