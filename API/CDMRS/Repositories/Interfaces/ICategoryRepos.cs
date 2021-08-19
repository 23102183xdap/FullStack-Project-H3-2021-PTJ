using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Repositories.Interfaces
{
    public interface ICategoryRepos
    {
        Task<List<CategoryModel>> GetAll();

        Task<CategoryModel> Get(int id);

        Task<CategoryModel> Create(CategoryModel tag);

        Task<CategoryModel> Update(int id, CategoryModel tag);

        Task<CategoryModel> Delete(int id);
    }
}
