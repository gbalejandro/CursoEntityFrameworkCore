using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Mod3.Models
{
    class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=EFCore_Mod3_Udemy;Integrated Security=True")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var estudiante1 = new Estudiante() { Id = 25, Nombre = "Data Seed", FechaNacimiento = new DateTime(1985, 3, 10) };
            var estudiante2 = new Estudiante() { Id = 26, Nombre = "Data Seed2", FechaNacimiento = new DateTime(1995, 3, 10) };
            modelBuilder.Entity<Estudiante>().HasData(new Estudiante[] { estudiante1, estudiante2 });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<EstudianteDetalle> EstudianteDetalles { get; set; }
        public DbSet<Contacto> Contactos { get; set; }

    }
}
