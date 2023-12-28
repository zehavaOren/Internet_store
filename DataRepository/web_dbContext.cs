using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entity
{
    public partial class web_dbContext : DbContext
    {
        public web_dbContext()
        {
        }

        public web_dbContext(DbContextOptions<web_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderItem> OrderItems { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Rating> Rating { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-HFEU4N8\\SQLEXPRESS;Database=web_db;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_100_CI_AS_KS_WS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("categoryName");
            });
            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("RATING");

                entity.Property(e => e.RatingId).HasColumnName("RATING_ID");

                entity.Property(e => e.Host)
                    .HasColumnName("HOST")
                    .HasMaxLength(50);

                entity.Property(e => e.Method)
                    .HasColumnName("METHOD")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Path)
                    .HasColumnName("PATH")
                    .HasMaxLength(50);

                entity.Property(e => e.RecordDate)
                 .HasColumnName("Record_Date")
                 .HasColumnType("datetime");

                entity.Property(e => e.Referer)
                    .HasColumnName("REFERER")
                    .HasMaxLength(100);

                entity.Property(e => e.UserAgent).HasColumnName("USER_AGENT");
            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("DATE");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orders_userId_fk");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("orderItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Orderid).HasColumnName("ORDERID");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Quentity).HasColumnName("QUENTITY");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderItem_ordersId_fk");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.Productid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("orderItem_productsId_fk");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(50)
                    .HasColumnName("imgURL");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Category)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("products_categoryID_fk");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMAIL")
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("FIRST_NAME")
                    .IsFixedLength();

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .HasColumnName("LASTNAME")
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("PASSWORD")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
