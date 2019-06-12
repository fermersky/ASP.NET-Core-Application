using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BooksWebApp.Models
{
    public partial class PublishingHouseContext : DbContext
    {
        public PublishingHouseContext()
        {
        }

        public PublishingHouseContext(DbContextOptions<PublishingHouseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Shops> Shops { get; set; }
        public virtual DbSet<Themes> Themes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=PublishingHouse;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Authors>(entity =>
            {
                entity.HasKey(e => e.IdAuthor)
                    .HasName("PK__Authors__83F33C8B1B327B2F");

                entity.Property(e => e.IdAuthor).HasColumnName("ID_Author");

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.IdCountry).HasColumnName("ID_Country");

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.Authors)
                    .HasForeignKey(d => d.IdCountry)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Authors__ID_Coun__145C0A3F");
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.IdBook)
                    .HasName("PK__Books__DE8DF038A501CEDB");

                entity.Property(e => e.IdBook).HasColumnName("ID_Book");

                entity.Property(e => e.DateOfPublish).HasColumnType("date");

                entity.Property(e => e.IdAuthor).HasColumnName("ID_Author");

                entity.Property(e => e.IdTheme).HasColumnName("ID_Theme");

                entity.Property(e => e.NameBook).HasMaxLength(40);

                entity.HasOne(d => d.IdAuthorNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.IdAuthor)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Books__ID_Author__182C9B23");

                entity.HasOne(d => d.IdThemeNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.IdTheme)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Books__ID_Theme__173876EA");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.IdCountry)
                    .HasName("PK__Country__A204CB3A2F18D985");

                entity.Property(e => e.IdCountry).HasColumnName("ID_Country");

                entity.Property(e => e.NameCountry).HasMaxLength(20);
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.HasKey(e => e.IdSale)
                    .HasName("PK__Sales__2071DEA3CE4AC915");

                entity.Property(e => e.IdSale).HasColumnName("ID_Sale");

                entity.Property(e => e.DateOfSale).HasColumnType("date");

                entity.Property(e => e.IdBook).HasColumnName("ID_Book");

                entity.Property(e => e.IdShop).HasColumnName("ID_Shop");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.IdBookNavigation)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.IdBook)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Sales__ID_Book__1ED998B2");

                entity.HasOne(d => d.IdShopNavigation)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.IdShop)
                    .HasConstraintName("FK__Sales__ID_Shop__1FCDBCEB");
            });

            modelBuilder.Entity<Shops>(entity =>
            {
                entity.HasKey(e => e.IdShop)
                    .HasName("PK__Shops__EB360B91E368C454");

                entity.Property(e => e.IdShop).HasColumnName("ID_Shop");

                entity.Property(e => e.IdCountry).HasColumnName("ID_Country");

                entity.Property(e => e.NameShop).HasMaxLength(20);

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.Shops)
                    .HasForeignKey(d => d.IdCountry)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Shops__ID_Countr__1BFD2C07");
            });

            modelBuilder.Entity<Themes>(entity =>
            {
                entity.HasKey(e => e.IdTheme)
                    .HasName("PK__Themes__2EF76F32BCE335B9");

                entity.Property(e => e.IdTheme).HasColumnName("ID_Theme");

                entity.Property(e => e.NameTheme).HasMaxLength(20);
            });
        }
    }
}
