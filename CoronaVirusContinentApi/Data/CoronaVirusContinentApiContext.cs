using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoronaVirusContinentApi.Models;

namespace CoronaVirusContinentApi.Data
{
    public class CoronaVirusContinentApiContext : DbContext
    {
        public CoronaVirusContinentApiContext (DbContextOptions<CoronaVirusContinentApiContext> options)
            : base(options)
        {
        }

        public DbSet<Continent> Continent { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
