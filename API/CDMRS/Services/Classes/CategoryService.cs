using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Services.Interfaces;
using API.CDMRS.Models;

namespace API.CDMRS.Services.Classes
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepos _categoryRepos;

        public CategoryService(ICategoryRepos categoryRepos)
        {
            _categoryRepos = categoryRepos;
        }

        public async Task<CategoryModel> Create(CategoryModel tag)
        {
            var result = await _categoryRepos.Create(tag);
            return result;
        }

        public async Task<CategoryModel> Delete(int id)
        {
            var result = await _categoryRepos.Delete(id);
            return result;
        }

        public async Task<CategoryModel> Get(int id)
        {
            var result = await _categoryRepos.Get(id);
            return result;
        }

        public async Task<List<CategoryModel>> GetAll()
        {
            var result = await _categoryRepos.GetAll();
            return result;
        }

        public async Task<CategoryModel> Update(int id, CategoryModel tag)
        {
            var result = await _categoryRepos.Update(id, tag);
            return result;
        }
    }
}
