using OFB_NEWS.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFB_NEWS.Data.Repository
{
    public class UnitOfWork
    {
        private readonly NewsContext _newsContext;
        private Dictionary<Type, object> _repository = new Dictionary<Type, object>();

        public UnitOfWork()
        {
            _newsContext = new NewsContext();
        }

        public GenericRepository<T> GetRepository<T>() where T : class
        {
            if (_repository.ContainsKey(typeof(T)))
                return _repository[typeof(T)] as GenericRepository<T>;

            var repository = new GenericRepository<T>(_newsContext);
            _repository.Add(typeof(T), repository);

            return repository;
        }

        public int SaveChanges()
        {
            return _newsContext.SaveChanges();
        }
    }
}
