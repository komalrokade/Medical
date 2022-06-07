using CoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPI.Services
{
    public class CustomerDBService : IDBService<Customer, int>
    {
        private readonly MedicalContext context;

        public CustomerDBService(MedicalContext ctx)
        {
            context = ctx;
        }
        public Customer Create(Customer entity)
        {
            //throw new NotImplementedException();
            context.Customers.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public Customer Delete(int id)
        {
            // throw new NotImplementedException();
            var custToDelete = context.Customers.Find(id);
            if (custToDelete == null) return null;

            context.Customers.Remove(custToDelete);
            context.SaveChanges();
            return custToDelete;
        }

        public IEnumerable<Customer> Get()
        {
            //throw new NotImplementedException();
            return context.Customers.ToList();
        }

        public Customer Get(int id)
        {
            //throw new NotImplementedException();
            var custToFind = context.Customers.Find(id);
            return custToFind;
        }

        public Customer Update(int id, Customer entity)
        {
            //throw new NotImplementedException();

            var custToUpdate = context.Customers.Find(id);
            if (custToUpdate == null) return null;

            custToUpdate.CustName = entity.CustName;
            custToUpdate.CustEmail = entity.CustEmail;
            custToUpdate.CustAddress = entity.CustAddress;
            custToUpdate.CustCity = entity.CustCity;
            custToUpdate.CustState = entity.CustState;

            context.SaveChanges();
            return custToUpdate;
        }
    }
}
