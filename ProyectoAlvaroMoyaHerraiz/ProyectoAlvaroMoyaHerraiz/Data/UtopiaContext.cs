using Microsoft.EntityFrameworkCore;
using ProyectoAlvaroMoyaHerraiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAlvaroMoyaHerraiz.Data
{
    public class UtopiaContext: DbContext
    {
        public UtopiaContext(DbContextOptions<UtopiaContext> options) : base(options) { }
        public DbSet<Juego> Juegos { get; set; }
        public DbSet<Plato> Platos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
