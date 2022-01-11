using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMvcCoreEF.Models
{
    public interface ICoche
    {
        //Solo declaracion de como sera el objeto
        //Prpiedades y metodos
        String Marca { get; set; }
        String Modelo { get; set; }
        String Imagen { get; set; }
        int Velocidad { get; set; }
        int VelocidadMaxima { get; set; }
        int Acelerar();
        int Frenar();

    }
}
