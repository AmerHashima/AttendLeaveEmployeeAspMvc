using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SystemMVC.Models;

namespace SystemMVC.Models
{
    public partial class SystemContext : DbContext
    {
        public SystemContext()
        {
        }

        public SystemContext(DbContextOptions<SystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Register> Register { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-68RLTU2;Database=System;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Register>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName).HasColumnName("First_Name");

                entity.Property(e => e.LastName).HasColumnName("Last_Name");

                entity.Property(e => e.UserName).HasColumnName("User_Name");
            });
        }

        public DbSet<SystemMVC.Models.Tasks> Tasks { get; set; }
    }
}
