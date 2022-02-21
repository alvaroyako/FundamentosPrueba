using MvcCoreClientesWCF.Models;
using ReferenceCatastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MvcCoreClientesWCF.Services
{
    public class ServiceCatastro
    {
        ReferenceCatastro.CallejerodelasedeelectrónicadelcatastroSoapClient client;

        public ServiceCatastro()
        {
            this.client = new CallejerodelasedeelectrónicadelcatastroSoapClient
                (CallejerodelasedeelectrónicadelcatastroSoapClient.EndpointConfiguration.Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap);
        }

        public async Task<List<Provincia>> GetProvincias()
        {
           ConsultaProvincia1 response= await this.client.ObtenerProvinciasAsync();
            XmlNode nodo = response.Provincias;
            string dataXml = nodo.OuterXml;
            XDocument document = XDocument.Parse(dataXml);
            XNamespace ns = "http://www.catastro.meh.es/";
            List<Provincia> provincias = new List<Provincia>();
            var consulta = from datos in document.Descendants(ns+"prov")
                           select datos;
            foreach(XElement dato in consulta)
            {
                string cp = dato.Element(ns + "cpine").Value;
                string nombreProvincia = dato.Element(ns+"np").Value;
                Provincia p = new Provincia { IdProvincia = cp, Nombre = nombreProvincia };
                provincias.Add(p);
            }
            return provincias;
        }

        public async Task <List<string>> GetMunicipios(string idprovincia)
        {
            ConsultaMunicipio1 response = await this.client.ObtenerMunicipiosAsync(idprovincia, null);
            XmlNode nodo = response.Municipios;
            string dataXml = nodo.OuterXml;
            XDocument document = XDocument.Parse(dataXml);
            XNamespace ns = "http://www.catastro.meh.es/";
            List<string> municipios = new List<string>();
            var consulta = from datos in document.Descendants(ns + "muni")
                           select datos;
            foreach (XElement dato in consulta)
            {
                string nombre = dato.Element(ns + "nm").Value;
                municipios.Add(nombre);
            }
            return municipios;
        }
    }
}
