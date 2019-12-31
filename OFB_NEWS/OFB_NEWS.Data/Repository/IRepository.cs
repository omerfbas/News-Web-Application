using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OFB_NEWS.Data.Repository
{
    public interface IRepository<T>
    {
        T Add(T t);

        List<T> GetAll();

        List<T> GetFilter(Expression<Func<T, bool>> filter);

        T Find(object id);

        T First(Expression<Func<T, bool>> filter);

        void Update(T t);

        void Delete(T t);
    }
}
