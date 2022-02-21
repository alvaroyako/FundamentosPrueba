using ExamenASPÁlvaroMoyaHerraiz.Data;
using ExamenASPÁlvaroMoyaHerraiz.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenASPÁlvaroMoyaHerraiz.Repositories
{
    public class RepositoryLibros
    {
        private LibrosContext context;
        public RepositoryLibros(LibrosContext context)
        {
            this.context = context;
        }

        public List<Libro> GetLibros()
        {
            var consulta = from datos in this.context.Libros
                           select datos;
            return consulta.ToList();
        }

        public List <Libro> BuscarLibros(List<int> id)
        {
            var consulta = from datos in this.context.Libros
                           where id.Contains(datos.IdLibro)
                           select datos;
            return consulta.ToList();
        }

        public Libro DetallesLibro(int idlibro)
        {
            var consulta = from datos in this.context.Libros
                           where datos.IdLibro == idlibro
                           select datos;
            return consulta.FirstOrDefault();
        }

        public List<Libro> LibrosGenero(int idgenero)
        {
            var consulta = from datos in this.context.Libros
                           where datos.IdGenero == idgenero
                           select datos;
            return consulta.ToList();
        }

        public Libro FindLibro(int idlibro)
        {
            return this.context.Libros.SingleOrDefault(z => z.IdLibro == idlibro);
        }

        public List<Genero> GetGeneros()
        {
            var consulta = from datos in this.context.Generos
                           select datos;
            return consulta.ToList();
        }

        public Usuario ExisteUsuario(string email, string password)
        {
            var consulta = from datos in this.context.Usuarios
                           where datos.Email == email 
                           && datos.Password==password
                           select datos;

            if (consulta == null)
            {
                return null;
            }
            else
            {
                Usuario usuario = consulta.FirstOrDefault();
                return usuario;
            }
        }

        public int GetMaxIdFactura()
        {
            if (this.context.Pedidos.Count() == 0)
            {
                return 1;
            }
            else
            {
                return this.context.Pedidos.Max(z => z.IdFactura) + 1;
            }
        }

        public int GetMaxIdPedido()
        {
            if (this.context.Pedidos.Count() == 0)
            {
                return 1;
            }
            else
            {
                return this.context.Pedidos.Max(z => z.IdPedido) + 1;
            }
        }

        public void CreateCompras(int idpedido,int idfactura, DateTime fecha,int idlibro, int idusuario)
        {
            Pedido pedido = new Pedido();
            pedido.IdPedido = idpedido;
            pedido.IdFactura = idfactura;
            pedido.Fecha = fecha;
            pedido.IdLibro = idlibro;
            pedido.IdUsuario = idusuario;
            pedido.Cantidad = 1;

            this.context.Add(pedido);
            this.context.SaveChanges();
        }

        public List<VistaPedido> VerPedidos(int idusuario)
        {
            List<VistaPedido> vistas = new List<VistaPedido>();
            var consulta = from datos in this.context.VistaPedidos
                           where datos.IdUsuario == idusuario
                           select datos;
            return consulta.ToList();
        }

        public Usuario FindUsuario(int idusuario)
        {
            return this.context.Usuarios.SingleOrDefault(z => z.IdUsuario == idusuario);
        }

        public int GetNumeroRegistros()
        {
            return this.context.VistaLibros.Count();
        }

        public List<VistaLibro> GetGrupoVistaLibro(int posicion)
        {
            var consulta = from datos in this.context.VistaLibros
                           where datos.Posicion >= posicion && datos.Posicion < (posicion + 4)
                           select datos;
            return consulta.ToList();
        }

    }
}
