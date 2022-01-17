using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcCoreEFProcedures.Data;
using MvcCoreEFProcedures.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEFProcedures.Repositories
{
    public class RepositoryTrabajadores
    {
        private EnfermosContext context;
        public RepositoryTrabajadores(EnfermosContext context)
        {
            this.context = context;
        }

        public List<string> GetOficios()
        {
            var consulta = (from datos in this.context.Trabajadores
                            select datos.Oficio).Distinct();
            return consulta.ToList();
        }

        public ResumenTrabajadores GetResumenTrabajadores(string oficio)
        {
            string sql = "SP_TRABAJADORES_OFICIO @OFICIO,@MEDIA out,@SUMA out";
            SqlParameter paramofi = new SqlParameter("@OFICIO", oficio);
            SqlParameter parammedia = new SqlParameter("@MEDIA", -1);
            parammedia.Direction = ParameterDirection.Output;
            SqlParameter paramsuma = new SqlParameter("@SUMA", -1);
            paramsuma.Direction = ParameterDirection.Output;
            var consulta = this.context.Trabajadores.FromSqlRaw(sql, paramofi, parammedia, paramsuma);
            ResumenTrabajadores resumen = new ResumenTrabajadores();
            resumen.Trabajadores = consulta.ToList();
            resumen.SumaSalarial = int.Parse(paramsuma.Value.ToString());
            resumen.MediaSalarial = int.Parse(parammedia.Value.ToString());
            return resumen;
        }
    }
}
