using Microsoft.EntityFrameworkCore;
using MvcCrudDepartamentosEFCore2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrudDepartamentosEFCore2022.Data
{
    public class HospitalesContext:DbContext
    {
        public HospitalesContext(DbContextOptions<HospitalesContext> options) : base(options) { }
        public DbSet<Hospital> Hospitales { get; set; }
    }
}
