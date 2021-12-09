using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum TipoGenero { Femenino, Masculino}
    public enum Paises { España, Italia, Alemania, Colombia}

    
    public class Persona
    {

        #region PROPIEDADES DE LA CLASE
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public Direccion Domicilio { get; set; }

        public TipoGenero Genero { get; set; }

        public Paises Nacionalidad { get; set; }
        private int _Edad;
        public int Edad
        {
            get 
            {
                return this._Edad;
            }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("El valor no puede ser negativo");
                }
                else
                {
                    this._Edad = value;
                }
                 
            }
        }

        #endregion

        #region METODOS DE CLASE

        public void MetodoParametroOpcional(int numero, int parametroopcional = 77)
        {

        }

        public string GetNombreCompleto()
        {
            return this.Nombre + "" + this.Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + "" + this.Nombre;
        }

        #endregion
    }
}
