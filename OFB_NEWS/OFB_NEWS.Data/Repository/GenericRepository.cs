using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OFB_NEWS.Data.Database;

namespace OFB_NEWS.Data.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly NewsContext _newsContext;

        public GenericRepository(NewsContext newsContext)
        {
            if (_newsContext == null)
                _newsContext = newsContext;
        }

        public T Add(T t)
        {
            return _newsContext.Set<T>().Add(t);
        }

        public List<T> GetAll()
        {
            return _newsContext.Set<T>().ToList();
        }

        public List<T> GetFilter(Expression<Func<T, bool>> filter)
        {
            return _newsContext.Set<T>().Where(filter).ToList();
        }

        public T Find(object id)
        {
            return _newsContext.Set<T>().Find(id);
        }

        public T First(Expression<Func<T, bool>> filter)
        {
            return _newsContext.Set<T>().FirstOrDefault(filter);
        }

        public void Update(T t)
        {
            _newsContext.Entry(t).State = EntityState.Modified;
        }

        public void Delete(T t)
        {
            _newsContext.Set<T>().Remove(t);
        }
    }
}
