using CS_EntityFrameworkApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EntityFrameworkApproach.DataAccessServices
{
    class CustomerDataAccess : IDataAccess<Customer, int>
    {
        public Customer Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> Get()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Update(int id, Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
