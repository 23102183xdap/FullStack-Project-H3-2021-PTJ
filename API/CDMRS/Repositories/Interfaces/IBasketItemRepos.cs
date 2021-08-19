using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Repositories.Interfaces
{
    public interface IBasketItemRepos
    {
        Task<List<BasketItem>> GetAll();

        Task<BasketItem> Get(int id);

        Task<BasketItem> Create(BasketItem basketItem);

        Task<BasketItem> Update(int id, BasketItem basketItem);

        Task<BasketItem> Delete(int id);

        Task<List<BasketItem>> GetByBasket(int id);
    }
}
