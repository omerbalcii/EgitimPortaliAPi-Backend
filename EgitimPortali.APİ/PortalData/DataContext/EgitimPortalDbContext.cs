using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortalData.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalData.DataContext
{
    public class EgitimPortalDbContext:IdentityDbContext
    {
        public EgitimPortalDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Order> Orders { get; set; } 
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
