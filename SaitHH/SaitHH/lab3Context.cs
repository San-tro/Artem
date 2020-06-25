using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SaitHH
{
    public partial class lab3Context : DbContext
    {
        public lab3Context()
        {
        }

        public lab3Context(DbContextOptions<lab3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Carcase> Carcase { get; set; }
        public virtual DbSet<Record> Record { get; set; }
        public virtual DbSet<RecordService> RecordService { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=lab3;Username=postgres;Password=war3menu;Integrated Security=true;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carcase>(entity =>
            {
                entity.ToTable("carcase");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarcaseType).HasColumnName("carcase_type");
            });

            modelBuilder.Entity<Record>(entity =>
            {
                entity.ToTable("record");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarNuber).HasColumnName("car_nuber");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.FinalCost).HasColumnName("final_cost");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Record)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("record_user_id_fkey");
            });

            modelBuilder.Entity<RecordService>(entity =>
            {
                entity.ToTable("record_service");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordId).HasColumnName("record_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.RecordService)
                    .HasForeignKey(d => d.RecordId)
                    .HasConstraintName("record_service_record_id_fkey");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.RecordService)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("record_service_service_id_fkey");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("service");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarcaseId).HasColumnName("carcase_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time with time zone");

                entity.HasOne(d => d.Carcase)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.CarcaseId)
                    .HasConstraintName("service_carcase_id_fkey");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("staff");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DailySalary).HasColumnName("daily salary");

                entity.Property(e => e.Fio).HasColumnName("fio");

                entity.Property(e => e.OrderSalary).HasColumnName("order salary");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fio).HasColumnName("fio");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Password).HasColumnName("password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
