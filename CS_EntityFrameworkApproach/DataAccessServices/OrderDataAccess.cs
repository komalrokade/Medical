using CS_EntityFrameworkApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EntityFrameworkApproach.DataAccessServices
{
    class OrderDataAccess : IDataAccess<Orders, int>
    {
        public Orders Create(Orders entity)
        {
            throw new NotImplementedException();
        }

        public Orders Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Orders> Get()
        {
            throw new NotImplementedException();
        }

        public Orders Get(int id)
        {
            throw new NotImplementedException();
        }

        public Orders Update(int id, Orders entity)
        {
            throw new NotImplementedException();
        }
    }
}
