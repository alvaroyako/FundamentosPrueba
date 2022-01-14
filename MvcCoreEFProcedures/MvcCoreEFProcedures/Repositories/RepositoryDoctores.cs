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
    public class RepositoryDoctores
    {
        private EnfermosContext context;
        public RepositoryDoctores(EnfermosContext context)
        {
            this.context = context;
        }

        public List<string> GetEspecialidad()
        {
            using (DbCommand com = this.context.Database.GetDbConnection().CreateCommand())
            {
                string sql = "SP_ESPECIALIDAD";
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = sql;
                com.Connection.Open();
                DbDataReader reader = com.ExecuteReader();
                List<string> especialidades = new List<string>();
                while (reader.Read())
                {
                    especialidades.Add(reader["ESPECIALIDAD"].ToString());
                }
                reader.Close();
                com.Connection.Close();
                return especialidades;
            }

        }

        public List<Doctor> GetDoctores()
        {
            List<Doctor> doctores = new List<Doctor>();
            string sql = "SP_DOCTORES";
            var consulta = this.context.Doctores.FromSqlRaw(sql);
            doctores = consulta.ToList();
            return doctores;
        }

        public List<Doctor> RealizarIncremento(string especialidad,int incremento)
        {
            string sql1 = "SP_INCREMENTARSALARIO @INCREMENTO,@ESPECIALIDAD";
            SqlParameter pamincremento = new SqlParameter("@INCREMENTO", incremento);
            SqlParameter pamespecialidad1 = new SqlParameter("@ESPECIALIDAD", especialidad);
            this.context.Database.ExecuteSqlRaw(sql1, pamincremento,pamespecialidad1);

            List<Doctor> doctores = new List<Doctor>();
            string sql2 = "SP_DOCTORESESPECIALIDAD @ESPECIALIDAD";
            SqlParameter pamespecialidad2 = new SqlParameter("@ESPECIALIDAD", especialidad);
            var consulta = this.context.Doctores.FromSqlRaw(sql2,pamespecialidad2);
            doctores = consulta.ToList();
            return doctores;
        }

    }
}
