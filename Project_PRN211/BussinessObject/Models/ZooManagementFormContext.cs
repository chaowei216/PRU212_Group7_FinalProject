using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace BussinessObject.Models
{
    public partial class ZooManagementFormContext : DbContext
    {
        public ZooManagementFormContext()
        {
        }

        public ZooManagementFormContext(DbContextOptions<ZooManagementFormContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animal> Animals { get; set; } = null!;
        public virtual DbSet<AnimalCage> AnimalCages { get; set; } = null!;
        public virtual DbSet<AnimalFood> AnimalFoods { get; set; } = null!;
        public virtual DbSet<AnimalSchedule> AnimalSchedules { get; set; } = null!;
        public virtual DbSet<AnimalTrainer> AnimalTrainers { get; set; } = null!;
        public virtual DbSet<Area> Areas { get; set; } = null!;
        public virtual DbSet<Cage> Cages { get; set; } = null!;
        public virtual DbSet<Food> Foods { get; set; } = null!;
        public virtual DbSet<Schedule> Schedules { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        private string GetConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true).Build();
            return configuration["ConnectionStrings:DefaultConnectionStringDB"];
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =(local); database = PRJ_PRN211_ZooManagement;uid=sa;pwd=123;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>(entity =>
            {
                entity.Property(e => e.AnimalId).HasMaxLength(6);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Region).HasMaxLength(30);

                entity.Property(e => e.SpeciesName).HasMaxLength(30);
            });

            modelBuilder.Entity<AnimalCage>(entity =>
            {
                entity.HasKey(e => new { e.AnimalId, e.CageId });

                entity.Property(e => e.AnimalId).HasMaxLength(6);

                entity.Property(e => e.CageId).HasMaxLength(5);

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.AnimalCages)
                    .HasForeignKey(d => d.AnimalId);

                entity.HasOne(d => d.Cage)
                    .WithMany(p => p.AnimalCages)
                    .HasForeignKey(d => d.CageId);
            });

            modelBuilder.Entity<AnimalFood>(entity =>
            {
                entity.HasKey(e => new { e.AnimalId, e.FoodId });

                entity.Property(e => e.AnimalId).HasMaxLength(6);

                entity.Property(e => e.FoodId).HasMaxLength(6);

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.AnimalFoods)
                    .HasForeignKey(d => d.AnimalId);

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.AnimalFoods)
                    .HasForeignKey(d => d.FoodId);
            });

            modelBuilder.Entity<AnimalSchedule>(entity =>
            {
                entity.HasKey(e => new { e.ScheduleId, e.AnimalId });

                entity.Property(e => e.ScheduleId).HasMaxLength(6);

                entity.Property(e => e.AnimalId).HasMaxLength(6);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.AnimalSchedules)
                    .HasForeignKey(d => d.AnimalId);

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.AnimalSchedules)
                    .HasForeignKey(d => d.ScheduleId);
            });

            modelBuilder.Entity<AnimalTrainer>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.AnimalId });

                entity.Property(e => e.UserId).HasMaxLength(6);

                entity.Property(e => e.AnimalId).HasMaxLength(6);

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.AnimalTrainers)
                    .HasForeignKey(d => d.AnimalId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AnimalTrainers)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.AreaId).HasMaxLength(6);

                entity.Property(e => e.AreaName).HasMaxLength(1);

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<Cage>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.Property(e => e.Cid)
                    .HasMaxLength(5)
                    .HasColumnName("CId");

                entity.Property(e => e.AreaId).HasMaxLength(6);

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Cages)
                    .HasForeignKey(d => d.AreaId);
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.Property(e => e.FoodId).HasMaxLength(6);

                entity.Property(e => e.CategoryName).HasMaxLength(30);

                entity.Property(e => e.Fname)
                    .HasMaxLength(30)
                    .HasColumnName("FName");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.Property(e => e.ScheduleId).HasMaxLength(6);

                entity.Property(e => e.ScheduleName).HasMaxLength(30);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasMaxLength(6);

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.Firstname).HasMaxLength(10);

                entity.Property(e => e.Lastname).HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(30);

                entity.Property(e => e.Phone).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
