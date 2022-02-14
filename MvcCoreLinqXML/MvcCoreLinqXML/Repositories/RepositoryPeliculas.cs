using MvcCoreLinqXML.Models;
using MvcCoreLinqXML.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MvcCoreLinqXML.Repositories
{
    public class RepositoryPeliculas
    {
        private XDocument documentpeliculas;
        private XDocument documentescenas;

        private string pathpeliculas;
        private string pathescenas;

        public RepositoryPeliculas(PathProvider pathProvider)
        {
            this.pathpeliculas = pathProvider.MapPath("peliculas.xml", Folders.Documents);
            this.pathescenas = pathProvider.MapPath("escenaspeliculas.xml", Folders.Documents);

            this.documentpeliculas = XDocument.Load(pathpeliculas);
            this.documentescenas = XDocument.Load(pathescenas);
        }

        public List<Pelicula> GetClientes()
        {
            var consulta = from datos in this.documentpeliculas.Descendants("pelicula")
                           select datos;
            List<Pelicula> listPeliculas = new List<Pelicula>();
            foreach (XElement dato in consulta)
            {
                Pelicula peli = new Pelicula();
                peli.IdPelicula = int.Parse(dato.Attribute("idpelicula").Value);
                peli.Nombre = dato.Element("titulo").Value;
                peli.NombreOriginal = dato.Element("titulooriginal").Value;
                peli.Descripcion = dato.Element("descripcion").Value;
                peli.Poster = dato.Element("poster").Value;
                listPeliculas.Add(peli);
            }
            return listPeliculas;
        }

        public Pelicula FindPelicula(int id)
        {
            var consulta = from datos in this.documentpeliculas.Descendants("pelicula")
                           where datos.Attribute("idpelicula").Value == id.ToString()
                           select datos;
            XElement dato = consulta.FirstOrDefault();
            Pelicula pelicula= new Pelicula
            {
                IdPelicula = int.Parse(dato.Attribute("idpelicula").Value),
                Nombre = dato.Element("titulo").Value,
                NombreOriginal = dato.Element("titulooriginal").Value,
                Descripcion = dato.Element("descripcion").Value,
                Poster = dato.Element("poster").Value,
            };
            return pelicula;
        }

        public List <Escena> MostrarEscenas(int idpelicula)
        {
            var consulta = from datos in this.documentescenas.Descendants("escena")
                           where datos.Attribute("idpelicula").Value == idpelicula.ToString()
                           select datos;
            List<Escena> escenas = new List<Escena>();
            foreach (XElement dato in consulta)
            {
                Escena escena = new Escena();
                escena.IdPelicula = int.Parse(dato.Attribute("idpelicula").Value);
                escena.Nombre = dato.Element("tituloescena").Value;
                escena.Descripcion = dato.Element("descripcion").Value;
                escena.Imagen = dato.Element("imagen").Value;
                escenas.Add(escena);
            }
            
            return escenas;
        }

        public Escena MostrarEscena(int idpelicula, int posicion, ref int numeroescenas)
        {
            var consulta = from datos in this.documentescenas.Descendants("escena")
                           where datos.Attribute("idpelicula").Value == idpelicula.ToString()
                           select datos;
            List<Escena> escenas = new List<Escena>();
            foreach (XElement dato in consulta)
            {
                Escena escena = new Escena();
                escena.IdPelicula = int.Parse(dato.Attribute("idpelicula").Value);
                escena.Nombre = dato.Element("tituloescena").Value;
                escena.Descripcion = dato.Element("descripcion").Value;
                escena.Imagen = dato.Element("imagen").Value;
                escenas.Add(escena);
            }
            numeroescenas = escenas.Count();
            Escena escena1 = escenas.Skip(posicion).Take(1).FirstOrDefault();
            return escena1;
        }



    }
}
