using Microsoft.EntityFrameworkCore;
using OnSale.Web.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Neighborhood> Neighborhoods { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<Country>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<Department>()
            .HasIndex(t => t.Name)
            .IsUnique();

            modelBuilder.Entity<Neighborhood>()
            .HasIndex(t => t.Name)
            .IsUnique();

            modelBuilder.Entity<State>()
            .HasIndex(t => t.Name)
            .IsUnique();
        }

        public DbSet<OnSale.Web.Data.Entity.Neighborhood> Neighborhood { get; set; }

        public DbSet<OnSale.Web.Data.Entity.State> State { get; set; }

    }
}

