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
    public class BasketRepos : IBasketRepos
    {
        private readonly APIDBContext _context;

        public BasketRepos(APIDBContext context)
        {
            _context = context;
        }

        public async Task<BasketModel> Create(Basket basket)
        {
            basket.CreatedAt = DateTime.Now;
            _context.Baskets.Add(basket);
            await _context.SaveChangesAsync();

            return basket;
        }

        public async Task<BasketModel> Delete(int id)
        {
            var basket = await _context.Baskets
                .FirstOrDefaultAsync(b => b.Id == id);

            if (basket != null || basket.DeletedAt == null)
            {
                basket.DeletedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }

            return basket;
        }

        public async Task<BasketModel> Get(int id)
        {
            return await _context.Baskets
                .Where(b => b.DeletedAt == null)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<BasketModel>> GetAll()
        {
            return await _context.Baskets
                .Where(b => b.DeletedAt == null)
                .ToListAsync();
        }

        public async Task<BasketModel> Update(int id, Basket updatedBasket)
        {
            var basket = await _context.Baskets
                .FirstOrDefaultAsync(b => b.Id == id);

            if (basket != null)
            {
                basket.EditedAt = DateTime.Now;

                if (updatedBasket.Customer != null)
                    basket.Customer = updatedBasket.Customer;

                basket.Quantity = updatedBasket.Quantity;

                basket.Price = updatedBasket.Price;

                _context.Update(basket);
                await _context.SaveChangesAsync();
            }

            return basket;
        }
    }
}
