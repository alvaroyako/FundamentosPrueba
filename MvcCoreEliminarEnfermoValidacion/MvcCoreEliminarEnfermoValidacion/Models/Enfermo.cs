using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEliminarEnfermoValidacion.Models
{
    [Table("ENFERMO")]
    public class Enfermo
    {
        [Key]
        [Column("INSCRIPCION")]
        public string Inscripcion { get; set; }

        [Column("APELLIDO")]
        public string Apellido { get; set; }

        [Column("DIRECCION")]
        public string Direccion { get; set; }

        [Column("FECHA_NAC")]
        public DateTime Fecha { get; set; }

        [Column("S")]
        public string sexo { get; set; }

        [Column("NSS")]
        public string nss { get; set; }
    }
}
