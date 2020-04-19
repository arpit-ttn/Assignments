using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Blazor_Advance.Data.Models
{
    public partial class StudentContext : DbContext
    {
        public StudentContext()
        {
        }

        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sidebar> Sidebar { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<UserDetails> UserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-FRDTOQH\\SQLEXPRESS;Database=Student;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sidebar>(entity =>
            {
                entity.ToTable("sidebar");

                entity.Property(e => e.LinkAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LinkName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.StudentAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudentCourse)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDetails>(entity =>
            {
                entity.ToTable("User_Details");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
