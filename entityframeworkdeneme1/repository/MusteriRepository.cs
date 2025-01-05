using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBConnectProject.entity;
using DBConnectProject.util;
using Microsoft.EntityFrameworkCore;

namespace DBConnectProject.repository
{
    internal class MusteriRepository : CrudRepository<Musteri, long>, IMusteriRepository
    {
        public Musteri getMusteriByEmail(string email)
        {
           return dbSet.Include(x=>x.role).Where(x => x.email == email).FirstOrDefault();
        }
    }
}
