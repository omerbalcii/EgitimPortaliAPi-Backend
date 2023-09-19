using PortalData.DataContext;
using PortalData.DataContracts;
using PortalData.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalData.Implementation
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly EgitimPortalDbContext _db;
public CustomerRepository(EgitimPortalDbContext db) : base(db)
        {

            _db = db;
        }
    }

}
