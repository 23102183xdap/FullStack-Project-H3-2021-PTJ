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
    public class BasketItemRepos : IBasketItemRepos
    {
        private readonly APIDBContext _context;

        public BasketItemRepos(APIDBContext context)
        {
            _context = context;
        }

        public async Task<BasketItemModel> Create(BasketItemModel basketItem)
        {
            basketItem.CreatedAt = DateTime.Now;
            _context.BasketItems.Add(basketItem);
            await _context.SaveChangesAsync();

            return basketItem;
        }

        public async Task<BasketItemModel> Delete(int id)
        {
            var basketItem = await _context.BasketItems
                .FirstOrDefaultAsync(b => b.Id == id);

            if (basketItem != null || basketItem.DeletedAt == null)
            {
                basketItem.DeletedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }

            return basketItem;
        }

        public async Task<BasketItemModel> Get(int id)
        {
            return await _context.BasketItems
                .Where(b => b.DeletedAt == null)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<BasketItemModel>> Get()
        {
            return await _context.BasketItems
                .Where(b => b.DeletedAt == null)
                .ToListAsync();
        }

        public async Task<BasketItemModel> Update(int id, BasketItem updatedBasketItem)
        {
            var basketItem = await _context.BasketItems
                .FirstOrDefaultAsync(b => b.Id == id);

            if (basketItem != null)
            {
                basketItem.EditedAt = DateTime.Now;

                if (updatedBasketItem.Basket != null)
                    basketItem.Basket = updatedBasketItem.Basket;

                if (updatedBasketItem.Item != null)
                    basketItem.Item = updatedBasketItem.Item;

                basketItem.Quantity = updatedBasketItem.Quantity;

                _context.Update(basketItem);
                await _context.SaveChangesAsync();
            }

            return basketItem;
        }

        public async Task<List<BasketItemModel>> GetByBasket(int id)
        {
            return await _context.BasketItems
                .Where(b => b.DeletedAt == null)
                .Where(b => b.Basket.Id == id)
                .Include(b => b.Item)
                .ToListAsync();
        }
    }
}
