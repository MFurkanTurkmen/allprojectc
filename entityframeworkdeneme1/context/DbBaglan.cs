using DBConnectProject.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies; // Add this using directive

namespace DBConnectProject.context
{
    internal class DbBaglan : DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Role> Roles { get; set; }

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
            // Role ile Musteri arasındaki ilişkiyi belirtiyoruz
            modelBuilder.Entity<Musteri>()
                .HasOne(m => m.role)  // Her Musteri'nin bir Role'u var
                .WithMany()            // Bir Role'un birçok Musteri'si olabilir
                .HasForeignKey("RoleId"); // Entity Framework, otomatik olarak 'RoleId' dış anahtarını oluşturur
        }
    
    }
}
