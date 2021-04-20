using ConstructoraUC.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConstructoraUC.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities{ get; set; }
        public DbSet<Project> Projects{ get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Property> Properties{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>()
              .HasIndex(t => t.Name)
              .IsUnique();

            modelBuilder.Entity<City>()
              .HasIndex(t => t.Name)
              .IsUnique();

            modelBuilder.Entity<Project>()
              .HasIndex(t => t.Name)
              .IsUnique();

            modelBuilder.Entity<Block>()
              .HasIndex(t => t.Name)
              .IsUnique();

            modelBuilder.Entity<Property>()
              .HasIndex(t => t.Identificador)
              .IsUnique();

        }

    }
}
