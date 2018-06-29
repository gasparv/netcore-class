using Ex_14_EfCore_CodeFirst.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_14_EfCore_CodeFirst.Data
{
    public class CoffeeDbContext:DbContext
    {
        public CoffeeDbContext(DbContextOptions<CoffeeDbContext> options):base(options)
        {

        }
        public DbSet<Coffee> Coffee { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeCoffee> EmployeeCoffee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            PopulateDbIfEmpty(ref modelBuilder);
            
        }
        private void PopulateDbIfEmpty(ref ModelBuilder modelBuilder)
        {
            Guid coffeeAntuka = Guid.NewGuid();
            Guid coffeeSanbox = Guid.NewGuid();
            Guid employeeMauni = Guid.NewGuid();
            Guid employeeIstvan = Guid.NewGuid();
            modelBuilder.Entity<Coffee>().HasData(
                new Coffee{
                    CoffeeId = coffeeAntuka,
                    Name ="AntukaCoffee",
                    Brand="Robusta"
                },
                new Coffee
                {
                    CoffeeId = coffeeSanbox,
                    Name = "Sandbox",
                    Brand = "Robusta"
                }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = employeeMauni,
                    Name = "Mauni Wakanatihiko",
                    Workplace = "Honolulu"
                },
                new Employee
                {
                    EmployeeId = employeeIstvan,
                    Name = "István Bača",
                    Workplace = "Pohronská polhora"
                }
                );

            modelBuilder.Entity<EmployeeCoffee>().HasData(
                new EmployeeCoffee
                {
                    CoffeeId = coffeeAntuka,
                    EmployeeId = employeeIstvan
                },
                new EmployeeCoffee
                {
                    CoffeeId = coffeeSanbox,
                    EmployeeId = employeeMauni
                }
                );
        }
    }
}
