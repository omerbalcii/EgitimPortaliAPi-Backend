using PortalData.DataContext;
using PortalData.DataContracts;
using PortalData.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalData.Implementation
{
        public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
        {
            private readonly EgitimPortalDbContext _db;

            public OrderItemRepository(EgitimPortalDbContext db) : base(db)
            {
                _db = db;
            }
        }
    }

