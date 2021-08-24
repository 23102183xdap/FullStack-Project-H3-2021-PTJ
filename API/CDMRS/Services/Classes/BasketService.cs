using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Services.Interfaces;
using API.CDMRS.Models;

namespace API.CDMRS.Services.Classes
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepos _basketRepos;

        public BasketService(IBasketRepos basketRepos)
        {
            _basketRepos = basketRepos;
        }

        public async Task<BasketModel> Create(BasketModel basketModel)
        {
            var result = await _basketRepos.Create(basketModel);
            return result;
        }

        public async Task<BasketModel> Delete(int id)
        {
            var result = await _basketRepos.Delete(id);
            return result;
        }

        public async Task<BasketModel> Get(int id)
        {
            var result = await _basketRepos.Get(id);
            return result;
        }

        public async Task<List<BasketModel>> GetAll()
        {
            var result = await _basketRepos.GetAll();
            return result;
        }

        public async Task<BasketModel> Update(int id, BasketModel basket)
        {
            var result = await _basketRepos.Update(id, basket);
            return result;
        }
    }
}
