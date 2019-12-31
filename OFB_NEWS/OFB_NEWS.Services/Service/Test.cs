using OFB_NEWS.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFB_NEWS.Services.Service
{
    public class Test
    {
        Service service = new Service();
        private List<Category> asd = service.GetRepository<Category>().GetAll();
    }
}
