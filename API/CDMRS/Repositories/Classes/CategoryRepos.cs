using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Database.Context;
using API.CDMRS.Models;

namespace API.CDMRS.Repositories.Classes
{
    public class CategoryRepos
    {
        private readonly APIDBContext _context;

        public CategoryRepos(APIDBContext context)
        {
            _context = context;
        }

        public async Task<CategoryModel> Create(CategoryModel category)
        {
           category.CreatedAt = DateTime.Now;
           _context.Category.Add(category);
           await _context.SaveChangesAsync();

            return category;
        }

        public async Task<CategoryModel> Delete(int id)
        {
            var category = await _context.Tags
                .FirstOrDefaultAsync(c => c.Id == id);
            if (category != null || category.DeletedAt == null)
	        {
                category.DeletedAt = DateTime.Now;
                await _context.SaveChangesAsync();  
	        }
            return category;
        }

        public async Task<CategoryModel> Get(int id)
        {
            return await _context.Category
                .Where(c => c.DeletedAt == null)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<CategoryModel>> GetAll()
        {
            return await _context.Category
                .Where(c => c.DeletedAt == null)
                .ToListAsync();
        }

        public async Task<CategoryModel> Update(int id, CategoryModel updatedCategory)
        {
           var category = await _context.Category
                .FirstOrDefaultAsync(c => c.Id == id);
            if (category != null)
	        {
                category.EditedAt = DateTime.Now;

                if (updatedTag.Name != null)
                    category.Name = updatedTag.Name;

                _context.Update(category);
                await _context.SaveChangesAsync();
	        }
            return category;
        }
    }
}
