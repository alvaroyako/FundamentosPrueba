using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrudDepartamentosEFCore2022.Models
{
    [Table("HOSPITAL")]
    public class Hospital
    {
        [Key]
        [Column("HOSPITAL_COD")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdHospital { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("DIRECCION")]
        public string Direccion { get; set; }

        [Column("TELEFONO")]
        public string Telefono { get; set; }

        [Column("NUM_CAMA")]
        public string Num_Cama { get; set; }
    }
}
