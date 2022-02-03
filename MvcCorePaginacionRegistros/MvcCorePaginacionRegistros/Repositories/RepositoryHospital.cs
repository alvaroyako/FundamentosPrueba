using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcCorePaginacionRegistros.Data;
using MvcCorePaginacionRegistros.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCorePaginacionRegistros.Repositories
{
    public class RepositoryHospital
    {

        #region Vistas Sql server
        //alter view v_dept_individual
        //as
        //select CAST(row_number() over(order by dept_no) as int) as posicion, isnull(dept_no,0) as dept_no,dnombre,loc from dept
        //go

     //   create procedure sp_paginargrupo_departamentos(@posicion int)
     //   as
	    //select dept_no, dnombre, loc from v_dept_individual

     //   where posicion>=@posicion and posicion<(@posicion+2)
     //   go
        #endregion
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetGrupoDepartamentos(int posicion, ref int numeroregistros)
        {
            string sql = "sp_paginargrupo_departamentos @posicion, @registros OUT";
            SqlParameter paramposicion = new SqlParameter("@posicion", posicion);
            SqlParameter paramregistros = new SqlParameter("@registros", -1);
            paramregistros.Direction = ParameterDirection.Output;
            var consulta = this.context.Departamentos.FromSqlRaw(sql, paramposicion,paramregistros);
            List<Departamento> departamentos = consulta.ToList();
            numeroregistros = (int)paramregistros.Value;
            return departamentos; 
        }

        public int GetNumeroRegistros()
        {
            return this.context.VistaDepartamentos.Count();
        }

        public VistaDepartamento GetVistaDepartamento(int posicion)
        {
            var consulta = from datos in this.context.VistaDepartamentos
                           where datos.Posicion == posicion
                           select datos;
            return consulta.FirstOrDefault();
        }

        public List<VistaDepartamento> GetGrupoVistaDepartamento(int posicion)
        {
            var consulta = from datos in this.context.VistaDepartamentos
                           where datos.Posicion >= posicion && datos.Posicion < (posicion + 2)
                           select datos;
            return consulta.ToList();
        }
    }
}
