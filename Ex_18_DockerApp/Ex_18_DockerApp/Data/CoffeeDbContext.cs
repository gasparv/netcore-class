using Ex_18_DockerApp.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_18_DockerApp.Data
{
    public class CoffeeDbContext:DbContext
    {
        public CoffeeDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Coffee> Coffee { get; set; }
    }
}
