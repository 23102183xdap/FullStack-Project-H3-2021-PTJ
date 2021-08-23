using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Services.Interfaces
{
    public interface IBasketServicecs
    {
        Task<List<BasketModel>> GetAll();

        Task<BasketModel> Get(int id);

        Task<BasketModel> Create(BasketItemModel basketItem);

        Task<BasketModel> Update(int id, BasketItemModel basketItem);

        Task<BasketModel> Delete(int id);

    }
}
