using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Ad_6_1_GenericHost
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext( DbContextOptions options) : base(options)
        {
        }
    }
}
