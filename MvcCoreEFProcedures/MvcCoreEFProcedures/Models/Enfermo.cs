using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEFProcedures.Models
{
    [Table("ENFERMO")]
    public class Enfermo
    {
        [Key]
        [Column("INSCRIPCION")]
        public int Inscripcion { get; set; }

        [Column("APELLIDO")]
        public string Apellido { get; set; }

        [Column("DIRECCION")]
        public string Direccion { get; set; }

        [Column("FECHA_NAC")]
        public DateTime Fecha_Nac { get; set; }

        [Column("S")]
        public string Sexo { get; set; }
    }
}
