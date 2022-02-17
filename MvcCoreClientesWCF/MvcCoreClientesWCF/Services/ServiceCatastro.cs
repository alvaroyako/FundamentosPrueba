using ReferenceCatastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

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

        public async Task <XmlNode> GetProvincias()
        {
           ConsultaProvincia1 response= await this.client.ObtenerProvinciasAsync();
            XmlNode provincias=response.Provincias.InnerXml;
        }
    }
}
