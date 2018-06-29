﻿// <auto-generated />
using System;
using Ex_14_EfCore_CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ex_14_EfCore_CodeFirst.Migrations.SQLite
{
    [DbContext(typeof(CoffeeDbContextLite))]
    [Migration("20180629190337_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799");

            modelBuilder.Entity("Ex_14_EfCore_CodeFirst.Models.DbModels.Coffee", b =>
                {
                    b.Property<Guid>("CoffeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("CoffeeId");

                    b.ToTable("Coffee");

                    b.HasData(
                        new { CoffeeId = new Guid("f1da593a-2ff2-4099-b2dc-79ab97607aea"), Brand = "Robusta", Name = "AntukaCoffee" },
                        new { CoffeeId = new Guid("bfe3d302-f8cb-413b-9a87-09d2664e23fc"), Brand = "Robusta", Name = "Sandbox" }
                    );
                });

            modelBuilder.Entity("Ex_14_EfCore_CodeFirst.Models.DbModels.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Workplace");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");

                    b.HasData(
                        new { EmployeeId = new Guid("590033cf-6b52-4422-9a50-e00cd386a74a"), Name = "Mauni Wakanatihiko", Workplace = "Honolulu" },
                        new { EmployeeId = new Guid("d02e5db9-0710-484e-ab96-b3f5676c4a3a"), Name = "István Bača", Workplace = "Pohronská polhora" }
                    );
                });

            modelBuilder.Entity("Ex_14_EfCore_CodeFirst.Models.DbModels.EmployeeCoffee", b =>
                {
                    b.Property<Guid>("EmployeeCoffeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CoffeeId");

                    b.Property<Guid>("EmployeeId");

                    b.HasKey("EmployeeCoffeeId");

                    b.HasIndex("CoffeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeCoffee");

                    b.HasData(
                        new { EmployeeCoffeeId = new Guid("2bdc6280-79a2-4e94-b2a5-834849215e8c"), CoffeeId = new Guid("f1da593a-2ff2-4099-b2dc-79ab97607aea"), EmployeeId = new Guid("d02e5db9-0710-484e-ab96-b3f5676c4a3a") },
                        new { EmployeeCoffeeId = new Guid("ba0e6705-3a35-4592-abed-3b82da1da47a"), CoffeeId = new Guid("bfe3d302-f8cb-413b-9a87-09d2664e23fc"), EmployeeId = new Guid("590033cf-6b52-4422-9a50-e00cd386a74a") }
                    );
                });

            modelBuilder.Entity("Ex_14_EfCore_CodeFirst.Models.DbModels.EmployeeCoffee", b =>
                {
                    b.HasOne("Ex_14_EfCore_CodeFirst.Models.DbModels.Coffee", "Coffee")
                        .WithMany("EmployeeCoffee")
                        .HasForeignKey("CoffeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ex_14_EfCore_CodeFirst.Models.DbModels.Employee", "Employee")
                        .WithMany("EmployeeCoffee")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
