using DBConnectProject.entity;
using Microsoft.EntityFrameworkCore;

namespace DBConnectProject.context
{
    internal class DbBaglan : DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {// LAB203-OGRETMEN
         // docker:
         // server=localhost;database=c240;uId=sa;password=Password1234
         // server= localhost yazımı sorun çıkartabilir o zaman
         // server= diyip db de ki properties-> name alanı yazılmalı
            optionsBuilder.UseSqlServer(
                   "server=localhost,1439;" +
                   "database=c240;" +
                   "uId=sa;" +
                   "password=Asd123asd.;" +
                   "TrustServerCertificate=True;"
               );
        }

      
    }
}
