using DBConnectProject.context;
using Microsoft.EntityFrameworkCore;

namespace DBConnectProject.util
{
    public class CrudRepository<T, ID> : IRepository<T, ID> where T : class
    {
        protected DbSet<T> dbSet; // Explicitly specify the namespace        
        DbBaglan dbBaglan;

        public CrudRepository()
        {
            dbBaglan = new DbBaglan();
            dbSet = dbBaglan.Set<T>(); // Initialize the dbSet
        }

        public virtual void add(T entity)
        {
            dbSet.Add(entity);
            dbBaglan.SaveChanges();
        }

        public virtual List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual T getById(ID id)
        {
            return dbSet.Find(id);
        }

        public virtual void remove(T entity)
        {
            dbSet.Remove(entity);
            dbBaglan.SaveChanges();
        }


    }
}
