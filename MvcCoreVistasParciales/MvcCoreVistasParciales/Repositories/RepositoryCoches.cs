using MvcCoreVistasParciales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.Repositories
{
    public class RepositoryCoches
    {
        private List<Coche> Cars;
        public RepositoryCoches() 
        {
            this.Cars = new List<Coche>
            {
                new Coche{IdCoche=1,Marca="Pontiac",Modelo="FireBird", VelocidadMaxima=320},
                new Coche{IdCoche=2,Marca="Chevrolet",Modelo="Camaro", VelocidadMaxima=120},
                new Coche{IdCoche=3,Marca="Ferrari",Modelo="X13", VelocidadMaxima=420},
                new Coche{IdCoche=4,Marca="Toyota",Modelo="Yaris", VelocidadMaxima=150}
            };
        }

        public List<Coche> GetCoches()
        {
            return this.Cars;
        }

        public Coche FindCoche(int id)
        {
            Coche car = this.Cars.SingleOrDefault(z => z.IdCoche == id);
            return car;
        }
    }
}
