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
    public class Itemrepos : IItemRepos
    {
        private readonly APIDBContext _context;

        public Itemrepos(APIDBContext context)
        {
            _context = context;
        }

        public async Task<ItemModel> Create(ItemModel item)
        {
            item.CreatedAt = DateTime.Now;
            _context.Items.Add(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<ItemModel> Delete(int id)
        {
            var item = await _context.Items
                .FirstOrDefaultAsync(i => i.Id == id);

            if (item != null || item.DeletedAt == null)
            {
                item.DeletedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }

            return item;
        }

        public async Task<ItemModel> Get(int id)
        {
            return await _context.Items
                .Where(i => i.DeletedAt == null)
                .Include(i => i.Tags)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<List<ItemModel>> GetAll()
        {
            return await _context.Items
                .Where(i => i.DeletedAt == null)
                .Include(i => i.Tags)
                .ToListAsync();
        }

        public async Task<ItemModel> Update(int id, ItemModel updatedItem)
        {
            var item = await _context.Items
                .FirstOrDefaultAsync(i => i.Id == id);
            if (item != null)
            {
                item.EditedAt = DateTime.Now;
            }

            item.ItemType = updatedItem.ItemType != null ? updatedItem.ItemType : item.ItemType;

            item.Price = updatedItem.Price;

            item.Discount = updatedItem.Discount;

            item.Discription = updatedItem.Discription != null ? updatedItem.Discription : item.Discription;

            item.Image = updatedItem.Image != null ? updatedItem.Image : item.Image;

            //item.Tags = updatedItem.Tags != null ? updatedItem.Tags : item.Tags;

            _context.Update(item);
            await _context.SaveChangesAsync();

            return item;
        }
    }
}
