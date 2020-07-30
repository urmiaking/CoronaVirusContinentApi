using CoronaVirusContinentApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaVirusContinentApi.Data
{
    public static class Migrate
    {
        public static IHost MigrateDatabase<T>(this IHost host) where T : DbContext
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var db = services.GetRequiredService<T>();
                    db.Database.Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return host;
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Continent>()
                .HasData(new Continent()
                {
                    Id = 1,
                    Name = "آسیا"
                }, new Continent()
                {
                    Id = 2,
                    Name = "آمریکا"
                }, new Continent()
                {
                    Id = 3,
                    Name = "آفریقا"
                }, new Continent()
                {
                    Id = 4,
                    Name = "استرالیا"
                }, new Continent()
                {
                    Id = 5,
                    Name = "اروپا"
                });
        }
    }
}
