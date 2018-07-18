using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CeratusSQLEntity.Models;

namespace CeratusSQLEntity.DataAccessLayer
{
    public class MySQLContext : IdentityDbContext<ApplicationUser>
    {
        // No migrations in macOS with EntityFramework
        // If database changed, drop it and run again to re-create
        // Tell base class you're using options
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public virtual DbSet<Person> Persons { get; set; }
    }
}
