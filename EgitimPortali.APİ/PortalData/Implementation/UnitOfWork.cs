using PortalData.DataContext;
using PortalData.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalData.Implementation
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly EgitimPortalDbContext _db;

        public UnitOfWork(EgitimPortalDbContext db)
        {
            _db = db;
            items = new ItemRepository(_db);
            order = new OrderRepository(_db);
            orderItem = new OrderItemRepository(_db);
            customer = new CustomerRepository(_db);

        }
        public IItemRepository items { get ; private set ; }
        public IOrderRepository order { get; private set; }
        public IOrderItemRepository orderItem { get; private set; }

        public ICustomerRepository customer { get; private set; }

        public void Dispose()
        {
           _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
