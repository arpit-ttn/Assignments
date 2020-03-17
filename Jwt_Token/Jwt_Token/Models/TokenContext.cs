using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Jwt_Token.Models
{
    public partial class TokenContext : DbContext
    {
        public TokenContext()
        {
        }

        public TokenContext(DbContextOptions<TokenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LoginDetails> LoginDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-FRDTOQH\\SQLEXPRESS;Database=Token;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginDetails>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__Login_De__536C85E5B84F5389");

                entity.ToTable("Login_Details");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Roles)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Userpassword)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
