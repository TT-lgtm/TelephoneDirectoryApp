using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TelephoneDirectoryApp.Models
{
    public partial class PhoneDirectoryModel : DbContext
    {
        public PhoneDirectoryModel()
            : base("name=PhoneDirectoryDBModel")
        {
        }

        public virtual DbSet<Buildings> Buildings { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Offices> Offices { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Subscribers> Subscribers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Offices)
                .WithRequired(e => e.Buildings)
                .HasForeignKey(e => e.BuildingId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buildings>()
                .HasMany(e => e.Subscribers)
                .WithRequired(e => e.Buildings)
                .HasForeignKey(e => e.BuildingId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Departments>()
                .HasMany(e => e.Subscribers)
                .WithRequired(e => e.Departments)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Offices>()
                .HasMany(e => e.Subscribers)
                .WithRequired(e => e.Offices)
                .HasForeignKey(e => e.OfficeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Positions>()
                .HasMany(e => e.Subscribers)
                .WithRequired(e => e.Positions)
                .HasForeignKey(e => e.PositionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Roles)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Subscribers)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);
        }
    }
}
