using CoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPI.Services
{
    public class OrderDBService : IDBService<Orders, int>
    {
        private readonly MedicalContext context;

        public OrderDBService(MedicalContext ctx)
        {
            context = ctx;
        }
        public Orders Create(Orders entity)
        {
            context.Orders.Add(entity);
            context.SaveChanges();
            return entity;
            //throw new NotImplementedException();
        }

        public Orders Delete(int id)
        {
            var ordToDelete = context.Orders.Find(id);
            if (ordToDelete == null) return null;

            context.Orders.Remove(ordToDelete);
            context.SaveChanges();
            return ordToDelete;
            //throw new NotImplementedException();
        }

        public IEnumerable<Orders> Get()
        {
            return context.Orders.ToList();
            //throw new NotImplementedException();
        }

        public Orders Get(int id)
        {
            var ordToFind = context.Orders.Find(id);
            return ordToFind;
            //throw new NotImplementedException();
        }

        public Orders Update(int id, Orders entity)
        {
            var ordToUpdate = context.Orders.Find(id);
            if (ordToUpdate == null) return null;

            ordToUpdate.CustNo = entity.CustNo;
            ordToUpdate.OrderNo = entity.OrderNo;
            ordToUpdate.OrderItem = entity.OrderItem;
            ordToUpdate.OrderQuantity = entity.OrderQuantity;

            context.SaveChanges();
            return ordToUpdate;
            //throw new NotImplementedException();
        }
    }
}
