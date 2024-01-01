using DataBasse.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasse.MyDBcontext
{
    internal class MyAppData : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ALEZZ;Database=Makeen;Integrated Security=true;TrustServerCertificate=true");
            
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         //   modelBuilder.Entity<Employee>()
         //       .HasOne(e => e.Department)
         //       .WithMany(d => d.Employees) 
         //       .HasForeignKey(e => e.depID)
         //       .OnDelete(DeleteBehavior.Restrict)
         //       .IsRequired(false);
         //   modelBuilder.Entity<Product>()
         //.HasMany(e => e.Employees)
         //.WithMany(e => e.Products)
         //;
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Product> Product { get; set; }
    }
  
}
