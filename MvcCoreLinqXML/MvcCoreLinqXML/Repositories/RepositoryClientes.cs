using MvcCoreLinqXML.Models;
using MvcCoreLinqXML.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MvcCoreLinqXML.Repositories
{
    public class RepositoryClientes
    {
        private XDocument document;
        private string path;

        public RepositoryClientes(PathProvider pathProvider)
        {
            this.path = pathProvider.MapPath("ClientesID.xml", Folders.Documents);
            this.document = XDocument.Load(path);
        }

        public List<Cliente> GetClientes()
        {
            var consulta = from datos in this.document.Descendants("CLIENTE")
                           select datos;
            List<Cliente> listClientes = new List<Cliente>();
            foreach(XElement dato in consulta)
            {
                Cliente cliente = new Cliente();
                cliente.IdCliente = int.Parse(dato.Element("IDCLIENTE").Value);
                cliente.Nombre = dato.Element("NOMBRE").Value;
                cliente.Email = dato.Element("EMAIL").Value;
                cliente.Direccion = dato.Element("DIRECCION").Value;
                cliente.Imagen = dato.Element("IMAGENCLIENTE").Value;
                listClientes.Add(cliente);
            }
            return listClientes;
        }

        public Cliente FindCliente(int id)
        {
            var consulta = from datos in this.document.Descendants("CLIENTE")
                           where datos.Element("IDCLIENTE").Value == id.ToString()
                           select datos;
            XElement dato = consulta.FirstOrDefault();
            Cliente cliente = new Cliente
            {
                IdCliente = int.Parse(dato.Element("IDCLIENTE").Value),
                Nombre = dato.Element("NOMBRE").Value,
                Email = dato.Element("EMAIL").Value,
                Direccion = dato.Element("DIRECCION").Value,
                Imagen = dato.Element("IMAGENCLIENTE").Value
            };
            return cliente;
        }

        private XElement FindXElementCliente(string idcliente)
        {
            var consulta = from datos in this.document.Descendants("CLIENTE")
                           where datos.Element("IDCLIENTE").Value == idcliente
                           select datos;
            return consulta.FirstOrDefault();
        }

        public void DeleteCliente(int id)
        {
            XElement XElement = this.FindXElementCliente(id.ToString());
            XElement.Remove();
            this.document.Save(this.path);
        }

        public void UpdateCliente(int id,string nombre,string direccion, string email,string imagen)
        {
            XElement XElement = this.FindXElementCliente(id.ToString());
            XElement.Element("NOMBRE").Value = nombre;
            XElement.Element("DIRECCION").Value = direccion;
            XElement.Element("EMAIL").Value = email;
            XElement.Element("IMAGENCLIENTE").Value = imagen;
            this.document.Save(this.path);
        }

        public void AddClient(int idcliente, string nombre, string direccion, string email, string imagen)
        {
            XElement rootCliente = new XElement("CLIENTE");
            rootCliente.Add(new XElement("IDCLIENTE", idcliente));
            rootCliente.Add(new XElement("NOMBRE", nombre));
            rootCliente.Add(new XElement("DIRECCION", direccion));
            rootCliente.Add(new XElement("EMAIL", email));
            rootCliente.Add(new XElement("IMAGENCLIENTE",imagen));
            this.document.Element("CLIENTES").Add(rootCliente);
            this.document.Save(this.path);
            
        }
    }
}
