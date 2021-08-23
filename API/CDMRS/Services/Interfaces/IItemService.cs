using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Services.Interfaces
{
    public interface IItemService
    {
        Task<List<ItemModel>> GetAll();

        Task<ItemModel> Get(int id);

        Task<ItemModel> Create(ItemModel item);

        Task<ItemModel> Update(int id, ItemModel item);

        Task<ItemModel> Delete(int id);
    }
}
