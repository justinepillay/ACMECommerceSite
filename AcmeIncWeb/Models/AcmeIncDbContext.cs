using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AcmeIncWeb.Models
{
    public partial class AcmeIncDbContext : DbContext
    {
        public AcmeIncDbContext()
        {
        }

        public AcmeIncDbContext(DbContextOptions<AcmeIncDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=LAPTOP-43SMJKGH;Initial Catalog=AcmeIncDb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cart__ProdId__34C8D9D1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cart__UserId__33D4B598");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__Category__6A1C8AFA4E3884A1");

                entity.ToTable("Category");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__ProdId__38996AB5");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__UserId__37A5467C");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("PK__Products__042785E5A8220B29");

                entity.Property(e => e.Cost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sell).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK__Products__CatId__2D27B809");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.HasKey(e => e.ImageId)
                    .HasName("PK__ProductI__7516F70C821B9EFE");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductIm__ProdI__49C3F6B7");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Users__RoleId__2A4B4B5E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
