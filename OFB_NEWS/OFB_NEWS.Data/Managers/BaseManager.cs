using OFB_NEWS.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFB_NEWS.Data.Managers
{
    public class BaseManager<TEntity> where TEntity : class
    {
        NewsContext database;
        public BaseManager()
        {
            database = new NewsContext();
        }

        public void AddManager(TEntity entity)
        {
            database.Set<TEntity>().Add(entity);
            database.SaveChanges();
        }

        public void UpdateManager(TEntity entity)
        {
            database.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            database.SaveChanges();
        }

        public void DeleteManager(TEntity entity)
        {

            database.Set<TEntity>().Remove(entity);
            database.SaveChanges();
        }

        public void DeleteIdManager(TEntity entity)
        {

            database.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            database.SaveChanges();
        }
        public TEntity GetByIdManager(int id)
        {

            return database.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAllManager()
        {

            return database.Set<TEntity>().ToList();
        }
    }
}
