using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMvcCoreEF.Models
{
    public class Deportivo: ICoche
    {
        public Deportivo(String marca, String modelo, String imagen, int velMax)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Imagen = imagen;
            this.VelocidadMaxima =velMax;
        }

        public Deportivo()
        {
            this.Marca = "Toyota";
            this.Modelo = "ae86";
            this.Imagen = "trueno.jpg";
            this.Velocidad = 0;
            this.VelocidadMaxima = 240;
        }

        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Imagen { get; set; }
        public int Velocidad { get; set; }
        public int VelocidadMaxima { get; set; }

        public int Acelerar()
        {
            this.Velocidad += 40;
            if (this.Velocidad > this.VelocidadMaxima)
            {
                this.Velocidad = this.VelocidadMaxima;
            }
            return this.Velocidad;
        }

        public int Frenar()
        {
            this.Velocidad -= 40;
            if (this.Velocidad < 0)
            {
                this.Velocidad = 0;
            }
            return this.Velocidad;
        }
    }
}
