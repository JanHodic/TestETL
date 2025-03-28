using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TestETL.Models;

namespace TestETL.Data.Contexts
{
    public class TestETLDbContext : DbContext
    {          public DbSet<Item> Actors { get; set; }
        public TestETLDbContext(DbContextOptions<TestETLDbContext> options) : base(options)
        {
        }
    }
}

