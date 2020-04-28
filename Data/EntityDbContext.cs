using System;
using LeandroCurioso.EntityFrameworkCore.Poc.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace LeandroCurioso.EntityFrameworkCore.Poc.Data
{
    public class EntityDbContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public EntityDbContext(DbContextOptions<EntityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => new { u.Email })
                .IsUnique(true);
        }

    }
}
