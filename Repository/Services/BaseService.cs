using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public abstract class BaseService
    {
        protected ZooDbContext _db;

        public BaseService()
        {
            _db = new ZooDbContext();
        }
        
    }
}
