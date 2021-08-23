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
    public class OrderItemRepos : IOrderItemRepos
    {
        private readonly APIDBContext _context;

        public OrderItemRepos(APIDBContext context)
        {
            _context = context;
        }

        public async Task<OrderItemModel> Create(OrderItemModel orderItem)
        {
            orderItem.CreatedAt = DateTime.Now;
            _context.OrderItems.Add(orderItem);
            await _context.SaveChangesAsync();

            return orderItem;
        }

        public async Task<OrderItemModel> Delete(int id)
        {
            var orderItem = await _context.OrderItems
                .FirstOrDefaultAsync(o => o.Id == id);
            if (orderItem != null || orderItem.DeletedAt == null)
            {
                orderItem.DeletedAt = DateTime.Now;
                await _context.SaveChangesAsync();

            }
            return orderItem;
        }

        public async Task<OrderItemModel> Get(int id)
        {
            return await _context.OrderItems
                .Where(o => o.DeletedAt == null)
                .FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<List<OrderItemModel>> GetAll()
        {
            return await _context.OrderItems
                .Where(o => o.DeletedAt == null)
                .ToListAsync();
        }

        public async Task<OrderItemModel> Update(int id, OrderItemModel UpdatedOrderItem)
        {
            var orderItem = await _context.OrderItems
                 .FirstOrDefaultAsync(o => o.Id == id);

            if (orderItem != null)
            {
                orderItem.EditedAt = DateTime.Now;

                if (UpdatedOrderItem.Order != null)
                    //orderItem.Order = UpdatedOrderItem.Order;

                    if (UpdatedOrderItem.Item != null)
                        //orderItem.Item = UpdatedOrderItem.Item;

                        orderItem.Quantity = UpdatedOrderItem.Quantity;

                _context.Update(orderItem);
                await _context.SaveChangesAsync();
            }
            return orderItem;

        }
    }
}
