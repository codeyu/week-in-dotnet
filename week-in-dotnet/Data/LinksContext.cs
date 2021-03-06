﻿using Microsoft.EntityFrameworkCore;
using WeekInDotnet.Models;

namespace WeekInDotnet.Data
{
    public class LinksContext : DbContext
    {
        public LinksContext(DbContextOptions<LinksContext> options) : base(options)
        { }

        public DbSet<Link> Links { get; set; }
        public DbSet<ApiKey> ApiKeys { get; set; }
        public DbSet<Administrator> Administrators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Link>().ForSqlServerToTable("Link");
            modelBuilder.Entity<ApiKey>().ForSqlServerToTable("ApiKey");
            modelBuilder.Entity<Administrator>().ForSqlServerToTable("Administrator");
        }
    }
}
