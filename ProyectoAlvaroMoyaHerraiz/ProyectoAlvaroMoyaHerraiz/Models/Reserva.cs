using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAlvaroMoyaHerraiz.Models
{
    public class Reserva
    {
        public string Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Asistentes { get; set; }
        public DateTime Hora { get; set; }
    }
}
