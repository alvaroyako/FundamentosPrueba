using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrudDepartamentosEFCore2022.Models
{
    public class ResumenDoctores
    {
        public int MaximoSalario { get; set; }
        public double MediaSalarial { get; set; }
        public int SumaSalarial { get; set; }
        public List<Doctor> Doctores { get; set; }
    }
}
