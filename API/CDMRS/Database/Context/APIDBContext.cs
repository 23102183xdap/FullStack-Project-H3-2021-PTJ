using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Database.Context
{
    public class APIDBContext : DbContext
    {
        public APIDBContext() { }

        public APIDBContext(DbContextOptions<APIDBContext> options) : base(options) { }

        public DbSet<BasketModel> Baskets { get; set; }

        public DbSet<BasketItemModel> BasketItems { get; set; }

        public DbSet<CreditModel> Credits { get; set; }

        public DbSet<CustomerModel> Customers { get; set; }

        public DbSet<DeliveryModel> Deliveries { get; set; }

        public DbSet<ItemModel> Items { get; set; }

        public DbSet<LoginModel> Logins { get; set; }

        public DbSet<OrderModel> Orders { get; set; }

        public DbSet<OrderItemModel> OrderItems { get; set; }

        public DbSet<CategoryModel> Category { get; set; }
    }
}
