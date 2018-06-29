using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ex_15_EfCore_DatabaseFirst.Models.DbModels
{
    public partial class db1007848_coffeeContext : DbContext
    {
        public db1007848_coffeeContext(DbContextOptions<db1007848_coffeeContext> options):base(options)
        {

        }
        public virtual DbSet<Coffee> Coffee { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeCoffee> EmployeeCoffee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coffee>(entity =>
            {
                entity.Property(e => e.CoffeeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<EmployeeCoffee>(entity =>
            {
                entity.Property(e => e.EmployeeCoffeeId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Coffee)
                    .WithMany(p => p.EmployeeCoffee)
                    .HasForeignKey(d => d.CoffeeId)
                    .HasConstraintName("FK_EmployeeCoffee_Coffee");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeCoffee)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EmployeeCoffee_Employee");
            });
        }
    }
}
