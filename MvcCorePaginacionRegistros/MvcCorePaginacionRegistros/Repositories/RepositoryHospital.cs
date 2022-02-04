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

        //alter procedure sp_paginargrupo_empleados(@posicion int, @registros int out, @oficio nvarchar(50))
        //    as
        //select @registros = count(emp_no) from v_emp_individual where oficio = @oficio

        //select* from(SELECT CAST(row_number() OVER (ORDER BY emp_no) AS int) AS posicion, isnull(emp_no, 0) AS emp_no, apellido, oficio, salario
        //FROM emp where oficio = @oficio) AS QUERY
        //where query.posicion>=@posicion and query.posicion<(@posicion+3)
        //go
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

        public List<Empleado> GetGrupoEmpleados(int posicion, string oficio, ref int numeroRegistros)
        {
            string sql = "sp_paginargrupo_empleados @posicion,@oficio,@registros out";
            SqlParameter paramposicion = new SqlParameter("@posicion", posicion);
            SqlParameter paramoficio = new SqlParameter("@oficio", oficio);
            SqlParameter paramregistros = new SqlParameter("@registros", -1);
            paramregistros.Direction = ParameterDirection.Output;
            var consulta = this.context.Empleados.FromSqlRaw(sql, paramposicion, paramoficio, paramregistros);
            List<Empleado> empleados = consulta.ToList();
            numeroRegistros = (int)paramregistros.Value;
            return empleados;
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
