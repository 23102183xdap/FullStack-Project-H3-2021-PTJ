using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Services.Interfaces
{
    public interface IBasketItemService
    {
        Task<List<BasketItemModel>> GetAll();

        Task<BasketItemModel> Get(int id);

        Task<BasketItemModel> Create(BasketItemModel basketItem);

        Task<BasketItemModel> Update(int id, BasketItemModel basketItem);

        Task<BasketItemModel> Delete(int id);

        Task<List<BasketItemModel>> GetByBasket(int id);
    }
}
