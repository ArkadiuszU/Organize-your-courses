using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourCourses.Models
{
    public class OrganizeYourCoursesDbContext : DbContext
    {
        private string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=OrganizeYourCoursesDb;Trusted_Connection=True;";
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<Category>()
                .Property(c => c.Description)
                .HasMaxLength(25);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);

        }
    }
}
