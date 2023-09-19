using PortalData.DataContext;
using PortalData.DataContracts;
using PortalData.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalData.Implementation
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        private readonly EgitimPortalDbContext _db;
public ItemRepository(EgitimPortalDbContext db) : base(db)
        {

            _db = db;
        }
    }

}
