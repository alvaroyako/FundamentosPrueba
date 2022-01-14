using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcCoreEFProcedures.Data;
using MvcCoreEFProcedures.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEFProcedures.Repositories
{
    public class RepositoryEnfermos
    {
        private EnfermosContext context;
        public RepositoryEnfermos(EnfermosContext context)
        {
            this.context = context;
        }

        public List<Enfermo> GetEnfermos()
        {
            using (DbCommand com = this.context.Database.GetDbConnection().CreateCommand())
            {
                string sql = "SP_ALLENFERMOS";
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = sql;
                com.Connection.Open();
                DbDataReader reader = com.ExecuteReader();
                List<Enfermo> enfermos = new List<Enfermo>();
                while (reader.Read())
                {
                    Enfermo enfermo = new Enfermo();
                    enfermo.Inscripcion =int.Parse(reader["INSCRIPCION"].ToString());
                    enfermo.Apellido = reader["Apellido"].ToString();
                    enfermo.Direccion = reader["Direccion"].ToString();
                    enfermo.Fecha_Nac =DateTime.Parse( reader["Fecha_NAC"].ToString());
                    enfermo.Sexo = reader["S"].ToString();
                    enfermos.Add(enfermo);
                }
                reader.Close();
                com.Connection.Close();
                return enfermos;
            }

        }

        public Enfermo FindEnfermo(int inscripcion)
        {
            string sql = "SP_FINDENFERMO @INSCRIPCION";
            SqlParameter paminscripcion = new SqlParameter("@INSCRIPCION", inscripcion);
            var consulta = this.context.Enfermos.FromSqlRaw(sql, paminscripcion);
            Enfermo enfermo = consulta.AsEnumerable().FirstOrDefault();
            return enfermo;
        }

        public void DeleteEnfermo(int inscripcion)
        {
            string sql = "SP_DELETEENFERMO @INSCRIPCION";
            SqlParameter paminscripcion= new SqlParameter("@INSCRIPCION", inscripcion);
            this.context.Database.ExecuteSqlRaw(sql, paminscripcion);
        }
    }
}
