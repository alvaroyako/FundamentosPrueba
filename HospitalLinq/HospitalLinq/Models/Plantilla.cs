using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalLinq.Models
{
    public class Plantilla
    {
        public int IdPlantilla { get; set; }
        public string Apellido { get; set; }
        public string Funcion { get; set; }
        public string Turno { get; set; }
        public int Salario { get; set; }
        public int IdHospital { get; set; }
        
    }
}
