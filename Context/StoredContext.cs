using EfCoreTasks1.Classes;
using EfCoreTasks1.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTasks1.Context
{
    public class StoredContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-U1C378C\SQLEXPRESS;Database=MovieEFCore;Trusted_Connection=true;TrustServerCertificate=true;");
        }


        public DbSet<Directors> Directors { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<MoviesImdbDetail> MoviesImdbDetails { get; set; }
        public DbSet<Subtitles> Subtitles { get; set; }
        public DbSet<MovieSubtitle> MovieSubtitle { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly
            (Assembly.GetExecutingAssembly());
        }

       
    }

    
}
