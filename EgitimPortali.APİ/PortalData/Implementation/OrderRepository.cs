using PortalData.DataContext;
using PortalData.DataContracts;
using PortalData.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalData.Implementation
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly EgitimPortalDbContext _db;
        public OrderRepository(EgitimPortalDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
