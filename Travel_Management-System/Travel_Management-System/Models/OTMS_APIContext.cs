using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Travel_Management_System.Models
{
    public partial class OTMS_APIContext : DbContext
    {
        public OTMS_APIContext()
        {
        }

        public OTMS_APIContext(DbContextOptions<OTMS_APIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TripDetails> TripDetails { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=WIN2012BASE\\MSSQLSERVER2017;Database=OTMS_API;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<TripDetails>(entity =>
            {
                entity.HasKey(e => e.TripId)
                    .HasName("PK__Trip_Det__685272BEA029664C");

                entity.ToTable("Trip_Details");

                entity.Property(e => e.TripId)
                    .HasColumnName("Trip_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Duration).IsUnicode(false);

                entity.Property(e => e.PlaceFrom)
                    .HasColumnName("Place_From")
                    .IsUnicode(false);

                entity.Property(e => e.PlaceTo)
                    .HasColumnName("Place_To")
                    .IsUnicode(false);

                entity.Property(e => e.TripName)
                    .HasColumnName("Trip_Name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__206D9170B713B056");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pwd).IsUnicode(false);

                entity.Property(e => e.Role).IsUnicode(false);
            });
        }
    }
}
