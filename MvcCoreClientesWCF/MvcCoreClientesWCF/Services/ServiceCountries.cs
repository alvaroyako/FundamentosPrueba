﻿using ServicioCountries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreClientesWCF.Services
{
    public class ServiceCountries
    {
        ServicioCountries.CountryInfoServiceSoapTypeClient client;

        public ServiceCountries()
        {
            this.client = new CountryInfoServiceSoapTypeClient
                (CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap);
        }

        public async Task<tCountryCodeAndName[]> GetCountries()
        {
            ListOfCountryNamesByNameResponse response = await this.client.ListOfCountryNamesByNameAsync();
            tCountryCodeAndName[] objetos =
            response.Body.ListOfCountryNamesByNameResult;
            return objetos;
        }
    }
}
