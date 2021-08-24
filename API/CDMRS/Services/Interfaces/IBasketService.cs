using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Services.Interfaces
{
    public interface IBasketService
    {
        Task<List<BasketModel>> GetAll();

        Task<BasketModel> Get(int id);

        Task<BasketModel> Create(BasketModel basketItem);

        Task<BasketModel> Update(int id, BasketModel basketItem);

        Task<BasketModel> Delete(int id);

    }
}
