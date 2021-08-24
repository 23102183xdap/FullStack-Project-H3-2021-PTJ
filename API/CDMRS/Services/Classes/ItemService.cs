using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Services.Interfaces;
using API.CDMRS.Models;

namespace API.CDMRS.Services.Classes
{
    public class ItemService : IItemService
    {
        private readonly IItemRepos _itemRepos;

        public ItemService(IItemRepos itemRepos)
        {
            _itemRepos = itemRepos;
        }

        public async Task<ItemModel> Create(ItemModel item)
        {
            var result = await _itemRepos.Create(item);
            return result;
        }

        public async Task<ItemModel> Delete(int id)
        {
            var result = await _itemRepos.Delete(id);
            return result;
        }

        public async Task<ItemModel> Get(int id)
        {
            var result = await _itemRepos.Get(id);
            return result;
        }

        public async Task<List<ItemModel>> GetAll()
        {
            var result = await _itemRepos.GetAll();
            return result;
        }

        public async Task<ItemModel> Update(int id, ItemModel item)
        {
            var result = await _itemRepos.Update(id, item);
            return result;
        }
    }
}
