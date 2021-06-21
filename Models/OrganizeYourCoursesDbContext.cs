using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizeYourCourses.Models
{
    public class OrganizeYourCoursesDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public OrganizeYourCoursesDbContext(DbContextOptions options) : base(options) { }
       
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
    }
}
