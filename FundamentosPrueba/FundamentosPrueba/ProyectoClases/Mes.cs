using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Mes
    {
        public string Nombre { get; set; }

        public int Maxima { get; set; }

        public int Minima { get; set; }

        public Mes(string nombre, int maxima, int minima)
        {
            this.Nombre = nombre;
            this.Maxima = maxima;
            this.Minima = minima;
        }


        public int Media(int minima,int maxima)
        {
            int media = (minima + maxima) / 2;
            return media;
        }
    }
}
