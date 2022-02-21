using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenASPÁlvaroMoyaHerraiz.Models
{
    [Table("VISTALIBROS")]
    public class VistaLibro
    {
        [Key]
        [Column("IDLIBRO")]
        public int IdLibro { get; set; }

        [Column("TITULO")]
        public string Titulo { get; set; }

        [Column("AUTOR")]
        public string Autor { get; set; }

        [Column("PORTADA")]
        public string Portada { get; set; }

        [Column("POSICION")]
        public int Posicion { get; set; }
    }
}
