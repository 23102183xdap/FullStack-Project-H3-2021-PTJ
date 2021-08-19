using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Repositories.Interfaces
{
    public interface IBasketRepos
    {
        Task<List<BasketModel>> GetAll();

        Task<BasketModel> Get(int id);

        Task<BasketModel> Create(BasketModel basket);

        Task<BasketModel> Update(int id, BasketModel basket);

        Task<BasketModel> Delete(int id);
    }
}
