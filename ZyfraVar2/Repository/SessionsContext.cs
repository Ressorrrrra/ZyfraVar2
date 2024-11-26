using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyfraVar2.Repository
{
    public class SessionsContext : DbContext
    {
        public DbSet<Session> Sessions { get; set;}
        public DbSet<User> Users { get; set;}

        public SessionsContext(DbContextOptions<SessionsContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder
        modelBuilder)
        {
            modelBuilder.Entity<Session>()
           .HasKey(s => s.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
