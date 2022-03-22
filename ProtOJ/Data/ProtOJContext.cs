using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProtOJ.Models;

namespace ProtOJ.Data
{
    public class ProtOJContext : DbContext
    {
        public ProtOJContext (DbContextOptions<ProtOJContext> options)
            : base(options)
        {
        }

        public DbSet<Session> Sessions { get; set; }
        public DbSet<User> Users { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Session>().ToTable("Session");
        }

        public DbSet<ProtOJ.Models.Session> Session { get; set; }
    }
}
