using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OFB_NEWS.Data.Repository;

namespace OFB_NEWS.Services.Service
{
    public class Service
    {
        private readonly UnitOfWork _unitOfWork;

        public Service()
        {
            _unitOfWork = new UnitOfWork();
        }


    }
}
