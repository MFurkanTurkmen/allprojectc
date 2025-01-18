using Microsoft.EntityFrameworkCore;
using webuygulama.entity;

namespace webuygulama.context
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Add certificate to the certificate store

            optionsBuilder.UseSqlServer("Server=localhost,1439;" +
                "Database=northwind;" +
                "Trusted_Connection=false;" +
                "UId=sa;" +
                "password=Asd123asd.;" +
        "TrustServerCertificate=true;");
        }
    }
}
