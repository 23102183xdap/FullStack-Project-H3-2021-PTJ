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
    public class DeliveryRepos : IDeliveryRepos
    {
        private readonly APIDBContext _context;

        public DeliveryRepos(APIDBContext context)
        {
            _context = context;
        }

        public async Task<DeliveryModel> Create(DeliveryModel delivery)
        {
            delivery.CreatedAt = DateTime.Now;
            _context.Deliveries.Add(delivery);
            await _context.SaveChangesAsync();

            return delivery;
        }

        public async Task<DeliveryModel> Delete(int id)
        {
            var delivery = await _context.Deliveries
                .FirstOrDefaultAsync(d => d.Id == id);

            if (delivery != null || delivery.DeletedAt == null)
            {
                delivery.DeletedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }

            return delivery;
        }

        public async Task<DeliveryModel> Get(int id)
        {
            return await _context.Deliveries
                .Where(d => d.DeletedAt == null)
                .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<List<DeliveryModel>> GetAll()
        {
            return await _context.Deliveries
                .Where(d => d.DeletedAt == null)
                .ToListAsync();
        }

        public async Task<DeliveryModel> Update(int id, DeliveryModel updatedDelivery)
        {
            var delivery = await _context.Deliveries
                .FirstOrDefaultAsync(d => d.Id == id);

            if (updatedDelivery != null)
            {
                updatedDelivery.EditedAt = DateTime.Now;
            }

            delivery.Status = updatedDelivery.Status != null ? updatedDelivery.Status : delivery.Status;

            _context.Update(delivery);
            await _context.SaveChangesAsync();

            return delivery;
        }
    }
}
