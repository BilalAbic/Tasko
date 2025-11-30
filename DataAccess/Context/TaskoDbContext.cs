using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Core.Entities;

namespace DataAccess.Context
{
    public class TaskoDbContext : DbContext
    {
        public TaskoDbContext(DbContextOptions<TaskoDbContext> options)
            : base(options)
        {
        }

        // DbSets (Tablolar)
        public DbSet<Users> Users { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationUser> OrganizationUsers { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<OrganizationInvite> OrganizationInvites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Many-to-Many (OrganizationUser)
            modelBuilder.Entity<OrganizationUser>()
                .HasOne(ou => ou.Organization)
                .WithMany(o => o.Users)
                .HasForeignKey(ou => ou.OrganizationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrganizationUser>()
                .HasOne(ou => ou.User)
                .WithMany(u => u.Organizations)
                .HasForeignKey(ou => ou.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Project → Owner
            modelBuilder.Entity<Projects>()
                .HasOne(p => p.Owner)
                .WithMany()
                .HasForeignKey(p => p.OwnerUserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Project → Tasks
            modelBuilder.Entity<TaskItem>()
                .HasOne(t => t.Project)
                .WithMany(p => p.Tasks)
                .HasForeignKey(t => t.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
