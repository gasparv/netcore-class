﻿// <auto-generated />
using Ex_18_DockerApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Ex_18_DockerApp.Migrations
{
    [DbContext(typeof(CoffeeDbContext))]
    [Migration("20180630162753_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ex_18_DockerApp.Models.DbModels.Coffee", b =>
                {
                    b.Property<int>("CoffeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CoffeeId");

                    b.ToTable("Coffee");
                });
#pragma warning restore 612, 618
        }
    }
}
