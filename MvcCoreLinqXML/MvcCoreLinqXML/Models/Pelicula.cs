using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreLinqXML.Models
{
    public class Pelicula
    {
        public int IdPelicula { get; set; }
        public string Nombre { get; set; }
        public string NombreOriginal { get; set; }
        public string Descripcion { get; set; }
        public string Poster { get; set; }
    }
}
