using Microsoft.EntityFrameworkCore;
using MvcNetCoreEF2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreEF2022.Data
{
    public class HospitalesContext:DbContext
    {
        public HospitalesContext(DbContextOptions<HospitalesContext> context) : base(context){}
        public DbSet<Hospital> Hospitales { get; set; }
    }
}
