using MvcCoreMultiplesBBDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreMultiplesBBDD.Repositories
{
    public interface IRepositoryEmpleados
    {
        List<Empleado> GetEmpleados();
        Empleado FindEmpleado(int id);
        void DeleteEmpleado(int id);
        void UpdateSalarioEmpleado(int idempleado, int incremento);
    }
}
