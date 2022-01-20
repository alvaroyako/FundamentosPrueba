using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcCoreMultiplesBBDD.Data;
using MvcCoreMultiplesBBDD.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreMultiplesBBDD.Repositories
{
    public class RepositoryEmpleadosOracle:IRepositoryEmpleados
    {
        private HospitalContext context;
        public RepositoryEmpleadosOracle(HospitalContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleados()
        {
            string sql = "BEGIN " + "sp_all_empleados(:p_empleados); " + "END;";
            OracleParameter pamempleados = new OracleParameter();
            pamempleados.ParameterName = "p_empleados";
            pamempleados.Value = null;
            pamempleados.Direction = ParameterDirection.Output;
            pamempleados.OracleDbType = OracleDbType.RefCursor;
            var consulta = this.context.Empleados.FromSqlRaw(sql, pamempleados);
            return consulta.ToList();
        }

        public Empleado FindEmpleado(int id)
        {
            return this.context.Empleados.SingleOrDefault(z => z.IdEmpleado == id);

        }

        public void DeleteEmpleado(int id)
        {
            string sql = "BEGIN "+"sp_delete_empleado(:p_idempleado); "+"END;";
            OracleParameter pamid = new OracleParameter("p_idempleado", id);
            this.context.Database.ExecuteSqlRaw(sql, pamid);
            
        }

        public void UpdateSalarioEmpleado(int idempleado, int incremento)
        {
            string sql = "BEGIN " + "sp_update_salario_emp(:p_idempleado,:p_incremento); " + "END;";
            OracleParameter pamid = new OracleParameter("p_idempleado", idempleado);
            OracleParameter pamincremento = new OracleParameter("p_incremento", incremento);
            this.context.Database.ExecuteSqlRaw(sql, pamid,pamincremento);
        }
    }
}
