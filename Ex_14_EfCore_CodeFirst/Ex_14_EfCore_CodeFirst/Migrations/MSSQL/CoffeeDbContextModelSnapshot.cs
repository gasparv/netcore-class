﻿// <auto-generated />
using System;
using Ex_14_EfCore_CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ex_14_EfCore_CodeFirst.Migrations.MSSQL
{
    [DbContext(typeof(CoffeeDbContext))]
    partial class CoffeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        new { CoffeeId = new Guid("68035d83-1eee-4cce-8527-093c0d68b5a6"), Brand = "Robusta", Name = "AntukaCoffee" },
                        new { CoffeeId = new Guid("1cb2eca2-debb-4502-b7b9-dc4cef01c8c9"), Brand = "Robusta", Name = "Sandbox" }
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
                        new { EmployeeId = new Guid("fe24c765-8f90-4fac-af4f-98923b422bb2"), Name = "Mauni Wakanatihiko", Workplace = "Honolulu" },
                        new { EmployeeId = new Guid("b3aaee28-ade8-4858-bfdc-d50a594b84aa"), Name = "István Bača", Workplace = "Pohronská polhora" }
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
                        new { EmployeeCoffeeId = new Guid("e79cf848-227d-446f-b6b3-f1ba65ba0d8f"), CoffeeId = new Guid("68035d83-1eee-4cce-8527-093c0d68b5a6"), EmployeeId = new Guid("b3aaee28-ade8-4858-bfdc-d50a594b84aa") },
                        new { EmployeeCoffeeId = new Guid("891b5cbb-0557-47f3-93e5-d800fccd221f"), CoffeeId = new Guid("1cb2eca2-debb-4502-b7b9-dc4cef01c8c9"), EmployeeId = new Guid("fe24c765-8f90-4fac-af4f-98923b422bb2") }
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