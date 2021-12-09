using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        public Direccion()
        {
            Debug.WriteLine("Constructor Direccion sin parametros");
        }

        public Direccion(string calle,string direccion)
        {
            this.Calle = calle;
            this.Ciudad = Ciudad;
        }

        public Direccion(string calle,string ciudad,int cp)
        {
            this.Calle = calle;
            this.Ciudad = Ciudad;
            this.CodigoPostal = cp;
        }

        public String Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }
    }
}
