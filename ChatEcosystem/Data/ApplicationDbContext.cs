using ChatEcosystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatEcosystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Message>()
                .HasOne(a => a.Sender)
                .WithMany(d => d.Messages)
                .HasForeignKey(d => d.UserId);

            base.OnModelCreating(builder);
        }
    }
}
