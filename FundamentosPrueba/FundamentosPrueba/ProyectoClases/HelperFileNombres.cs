using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class HelperFileNombres
    {
        public async Task<List<String>> ReadFileNombres(String path)
        {
            FileInfo file = new FileInfo(path);
            String contenido = "";
            using (TextReader reader = file.OpenText())
            {
                contenido = await reader.ReadToEndAsync();
                reader.Close();

            }
            return this.GetNombres(contenido);
        }

        public async Task WriteFileNombresAsync(string path, string data)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();
            }
        }


        private List<String> GetNombres(string data)
        {
            string[] nombres = data.Split(',');
            List<String> listanombres = new List<String>(nombres);
            return listanombres;
        }
    }
}
