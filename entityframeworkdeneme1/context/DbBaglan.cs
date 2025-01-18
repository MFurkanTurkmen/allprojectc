using DBConnectProject.entity;
using entityframeworkdeneme1.entity;
using Microsoft.EntityFrameworkCore;

namespace DBConnectProject.context
{
    // context/DbBaglan.cs
    public class DbBaglan : DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Admin> Admins { get; set; }  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                   "server=localhost,1439;" +
                   "database=c240;" +
                   "uId=sa;" +
                   "password=Asd123asd.;" +
                   "TrustServerCertificate=True;"
               );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mevcut ilişkiler
            modelBuilder.Entity<Musteri>()
                .HasOne(m => m.role)
                .WithMany()
                .HasForeignKey("RoleId");

            // Admin-Role ilişkisi
            modelBuilder.Entity<Admin>()
                .HasOne(a => a.role)
                .WithMany()
                .HasForeignKey("RoleId");
        }
    }
}
