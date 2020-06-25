using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SaitHH
{
    public partial class SiteContext : DbContext
    {
        public SiteContext()
        {
        }

        public SiteContext(DbContextOptions<SiteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyComment> CompanyComment { get; set; }
        public virtual DbSet<Resume> Resume { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Vacancy> Vacancy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Site;Username=postgres;Password=war3menu;Integrated Security=true;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Info).HasColumnName("info");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Telephone).HasColumnName("telephone");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Www).HasColumnName("www");
            });

            modelBuilder.Entity<CompanyComment>(entity =>
            {
                entity.ToTable("Company_comment");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyComment)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("Company_comment_company_id_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CompanyComment)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("Company_comment_user_id_fkey");
            });

            modelBuilder.Entity<Resume>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Birth)
                    .HasColumnName("birth")
                    .HasColumnType("date");

                entity.Property(e => e.CareerObj).HasColumnName("career_obj");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.EndYear)
                    .HasColumnName("end_year")
                    .HasColumnType("date");

                entity.Property(e => e.Experience).HasColumnName("experience");

                entity.Property(e => e.Faculty).HasColumnName("faculty");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Institution).HasColumnName("institution");

                entity.Property(e => e.Knowledge).HasColumnName("knowledge");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Nationality).HasColumnName("nationality");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.Spec).HasColumnName("spec");

                entity.Property(e => e.Specialization).HasColumnName("specialization");

                entity.Property(e => e.Surname).HasColumnName("surname");

                entity.Property(e => e.Telephone).HasColumnName("telephone");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Resume)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("Resume_user_id_fkey");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("role_id");
            });

            modelBuilder.Entity<Vacancy>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Addres).HasColumnName("addres");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Conditions).HasColumnName("conditions");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Demand).HasColumnName("demand");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Employment).HasColumnName("employment");

                entity.Property(e => e.Experience).HasColumnName("experience");

                entity.Property(e => e.Money).HasColumnName("money");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Responsibility).HasColumnName("responsibility");

                entity.Property(e => e.Telephone).HasColumnName("telephone");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Vacancy)
                    .HasForeignKey<Vacancy>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("company_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
