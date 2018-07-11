using Ex_Ad_14_1_EfCoreLazyLoading.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Ex_Ad_14_1_EfCoreLazyLoading.Data
{
    public class CoffeeDbContext : DbContext
    {
        public CoffeeDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Coffee> Coffee { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeCoffee> EmployeeCoffee { get; set; }
        public DbQuery<DrinkCoffeesCountView> VDrinkCoffees { get; set; }

        //public Q<DrinkCoffeesCountView> DrinkCoffeesView { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Query<DrinkCoffeesCountView>().ToView("View_DrinkCoffeesCount");

            //It is possible to create an alternate key as well as a composite alternate key
            modelBuilder.Entity<Coffee>().HasAlternateKey(x => x.CoffeeCode).HasName("APK_CoffeeCode");

            //It is possible to create multiple indices using modelbuilder
            modelBuilder.Entity<Coffee>().HasIndex(x => new { x.CoffeeId, x.CoffeeCode });


            //Data seeding for coffee entity
            modelBuilder.Entity<Coffee>().HasData(
                new Coffee
                {
                    CoffeeId = 1,
                    CoffeeCode = "ANTIS",
                    Name = "Antuka",
                    Origin = "Slovakia",
                },
                new Coffee
                {
                    CoffeeId = 2,
                    CoffeeCode = "AZET",
                    Name = "Azera",
                    Origin = "Turkmenistan",
                }, new Coffee
                {
                    CoffeeId = 3,
                    CoffeeCode = "PERBI",
                    Name = "PeruBio",
                    Origin = "Peru"
                }
                );

            //Data seeding for Employee entity
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    Name = "Vlado",
                    Workplace = "Unknown"
                },
                new Employee
                {
                    EmployeeId = 2,
                    Name = "Janči",
                    Workplace = "KE"
                }
                );

            //Data seeding for EmployeeCoffee entity
            modelBuilder.Entity<EmployeeCoffee>().HasData(
                new EmployeeCoffee
                {
                    EmployeeCoffeeId = 1,
                    CoffeeId = 1,
                    EmployeeId = 1
                },
                new EmployeeCoffee
                {
                    EmployeeCoffeeId = 2,
                    CoffeeId = 3,
                    EmployeeId = 1
                },
                new EmployeeCoffee
                {
                    EmployeeCoffeeId = 3,
                    CoffeeId = 2,
                    EmployeeId = 2
                }
                );
        }
    }
}
