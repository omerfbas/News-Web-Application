using OFB_NEWS.Data.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFB_NEWS.Business.Controllers
{
    public class BaseController<TEntity> where TEntity : class
    {
        BaseManager<TEntity> manager;

        public BaseController()
        {
            manager = new BaseManager<TEntity>();
        }
        public void Add(TEntity entity)
        {

            manager.AddManager(entity);
        }
        public void Update(TEntity entity)
        {
            manager.UpdateManager(entity);
        }
        public void Delete(TEntity entity)
        {
            manager.DeleteIdManager(entity);
        }

        public void DeleteById(TEntity entity)
        {
            manager.DeleteIdManager(entity);
        }

        public TEntity GetById(int id)
        {
            manager = new BaseManager<TEntity>();
            return manager.GetByIdManager(id);

        }

        public List<TEntity> GetAll()
        {
            return manager.GetAllManager();
        }
    }
}
