using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Services.Interfaces;
using API.CDMRS.Models;

namespace API.CDMRS.Services.Classes
{
    public class BasketItemService : IBasketItemService
    {
        private readonly IBasketItemRepos _basketItemRepos;

        public BasketItemService(IBasketItemRepos basketItemRepos)
        {
            _basketItemRepos = basketItemRepos;
        }

        public async Task<BasketItemModel> Create(BasketItemModel basketItemModel)
        {
            var result = await _basketItemRepos.Create(basketItemModel);
            return result;
        }

        public async Task<BasketItemModel> Delete(int id)
        {
            var result = await _basketItemRepos.Delete(id);
            return result;
        }

        public async Task<BasketItemModel> Get(int id)
        {
            var result = await _basketItemRepos.Get(id);
            return result;
        }

        public async Task<List<BasketItemModel>> GetAll()
        {
            var result = await _basketItemRepos.GetAll();
            return result;
        }

        public async Task<BasketItemModel> Update(int id, BasketItemModel basketItem)
        {
            var result = await _basketItemRepos.Update(id, basketItem);
            return result;
        }

        public async Task<List<BasketItemModel>> GetByBasket(int id)
        {
            var result = await _basketItemRepos.GetByBasket(id);
            return result;
        }
    }
}
