using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Database.Context;
using API.CDMRS.Models;

namespace API.CDMRS.Repositories.Classes
{
    public class OrderRepos : IOrderRepos
    {
        private readonly APIDBContext _context;

        public OrderRepos(APIDBContext context)
        {
            _context = context;
        }

        public async Task<OrderModel> Create(OrderModel order)
        {
            order.CreatedAt = DateTime.Now;
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return order;
        }

        public async Task<OrderModel> Delete(int id)
        {
            var order = await _context.Orders
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order != null || order.DeletedAt == null)
            {
                order.DeletedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }
            return order;
        }

        public async Task<OrderModel> Get(int id)
        {
            return await _context.Orders
                .Where(o => o.DeletedAt == null)
                .FirstOrDefaultAsync(o => o.Id == id);

        }

        public async Task<List<OrderModel>> GetAll()
        {
            return await _context.Orders
                .Where(o => o.DeletedAt == null)
                .ToListAsync();
        }

        public async Task<OrderModel> Update(int id, OrderModel updatedOrder)
        {
            var order = await _context.Orders
                .FirstOrDefaultAsync(o => o.Id == id);
            if (order != null)
            {
                order.EditedAt = DateTime.Now;

                if (updatedOrder.Customer != null)
                    //order.Customer = updatedOrder.Customer;

                    order.Price = updatedOrder.Price;

                _context.Update(order);
                await _context.SaveChangesAsync();
            }
            return order;
        }
    }
}
