
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using BigBangDotNet.Data.Filters;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace BigBangDotNet.Data.Filters.Tests.Database
{
    public class TestDbContext : DbContext
    {
        public TestDbContext() { }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options) { }

        
        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }
    }
}