using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProyectoAlvaroMoyaHerraiz.Data;
using ProyectoAlvaroMoyaHerraiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAlvaroMoyaHerraiz.Repositories
{
    public class RepositoryUtopiaSqlServer
    {
        private UtopiaContext context;

        public RepositoryUtopiaSqlServer(UtopiaContext context)
        {
            this.context = context;
        }

        #region PROCEDURES
        //MOSTRAR LOS PLATOS
        //create procedure sp_all_platos
        //as
        //select* from PLATOS
        //go

        //MOSTRAR LOS JUEGOS
        //create procedure sp_all_juegos
        //as
        //select* from JUEGOS
        //go

        //FILTRAR JUEGOS POR CATEGORIA
        //create procedure sp_juegos_categoria(@categoria nvarchar(100))
        //as
        //select* from JUEGOS where categoria=@categoria
        //go

        //FILTRAR JUEGOS POR PRECIO
        //create procedure sp_juegos_precio(@precio int)
        //as
        //select* from JUEGOS where precio>=@precio
        //go

        //FILTRAR JUEGOS POR NOMBRE
        //create procedure sp_juegos_nombre(@nombre NVARCHAR(50))
        //as
        //select* from JUEGOS where nombre LIKE @nombre+'%'
        //go

        //CREAR RESERVA
        //create procedure sp_crear_reserva(@id int,@fecha nvarchar(50),@asistentes int,@hora nvarchar(50))
        //as
        //insert into RESERVAS values(@id,@fecha, @asistentes, @hora)
        //go

        //Autogenerar id
        //CREATE procedure SP_MAXID
        //(@COLUMNA NVARCHAR(50), @TABLA NVARCHAR(50))
        //as
        //DECLARE @SQL nvarchar(1000)
        //SET @SQL = 'SELECT MAX(' + @COLUMNA + ') + 1 AS MAXIMO FROM '
        //+ @TABLA
        //EXEC(@SQL)
        //go
        //exec SP_MAXID 'EMP_NO', 'EMP'
        //exec SP_MAXID 'DEPT_NO', 'DEPT'
        //exec SP_MAXID 'DOCTOR_NO', 'DOCTOR'
        #endregion

        #region Metodos Platos
        public List<Plato> GetPlatos()
        {
            string sql = "sp_all_platos";
            var consulta = this.context.Platos.FromSqlRaw(sql);
            return consulta.ToList();
        }
        #endregion

        #region Metodos Juegos
        public List<Juego> GetJuegos()
        {
            string sql = "sp_all_juegos";
            var consulta = this.context.Juegos.FromSqlRaw(sql);
            return consulta.ToList();
        }

        public List<string> GetCategorias()
        {
            var consulta = (from datos in this.context.Juegos
                            select datos.Categoria).Distinct();
            return consulta.ToList();
        }

        public List<Juego> GetJuegoCategoria(string categoria)
        {
            string sql = "sp_juegos_categoria @categoria";
            SqlParameter pamcategoria = new SqlParameter("@categoria", categoria);
            var consulta=this.context.Juegos.FromSqlRaw(sql, pamcategoria);
            return consulta.ToList();
        }

        public List<Juego> GetJuegoPrecio(int precio)
        {
            string sql = "sp_juegos_precio @precio";
            SqlParameter pamprecio = new SqlParameter("@precio", precio);
            var consulta = this.context.Juegos.FromSqlRaw(sql, pamprecio).AsEnumerable();
            if (consulta.Count() == 0)
            {
                return null;
            }
            return consulta.ToList();
        }

        public List<Juego> GetJuegoNombre(string nombre)
        {
            string sql = "sp_juegos_nombre @nombre";
            SqlParameter pamnombre = new SqlParameter("@nombre", nombre);
            var consulta = this.context.Juegos.FromSqlRaw(sql, pamnombre).AsEnumerable();
            if (consulta.Count() == 0)
            {
                return null;
            }
            return consulta.ToList();
        }
        #endregion

        #region Metodos Reservas
        public void CrearReserva(int id,string fecha,int asistentes,string hora)
        {
            string sql = "sp_crear_reserva @id,@fecha,@asistentes,@hora";
            SqlParameter pamid = new SqlParameter("@id", id);
            SqlParameter pamfecha = new SqlParameter("@fecha", fecha);
            SqlParameter pamasistentes = new SqlParameter("@asistentes", asistentes);
            SqlParameter pamhora = new SqlParameter("@hora", hora);
            this.context.Database.ExecuteSqlRaw(sql,pamid,pamfecha,pamasistentes,pamhora);
        }

        #endregion

    }
}
