using Microsoft.EntityFrameworkCore;
using ProyectoMvcCoreSeries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMvcCoreSeries.Data
{
    public class SeriesContext: DbContext
    {
        public SeriesContext
            (DbContextOptions<SeriesContext> options)
            : base(options) { }
        public DbSet<Serie> Series{ get; set; }
        public DbSet<Personaje> Personajes{ get; set; }
    }
}
