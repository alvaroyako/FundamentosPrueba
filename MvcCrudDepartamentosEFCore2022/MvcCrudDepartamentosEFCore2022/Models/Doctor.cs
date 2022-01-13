using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrudDepartamentosEFCore2022.Models
{
    public class Doctor
    {
        [Table("DOCTOR")]
        public class Empleado
        {
            [Key]
            [Column("HOSPITAL_COD")]
            public int IdHospital { get; set; }
            [Column("DOCTOR_NO")]
            public int IdDoctor { get; set; }
            [Column("APELLIDO")]
            public String Apellido{ get; set; }
            [Column("ESPECIALIDAD")]
            public DateTime FechaAlta { get; set; }
            [Column("SALARIO")]
            public int Salario { get; set; }
        }
    }
}
