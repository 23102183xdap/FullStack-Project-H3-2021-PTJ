using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Services.Interfaces
{
    public interface IOrderItemService
    {
        Task<List<OrderItemModel>> GetAll();

        Task<OrderItemModel> Get(int id);

        Task<OrderItemModel> Create(OrderItemModel orderItem);

        Task<OrderItemModel> Update(int id, OrderItemModel orderItem);

        Task<OrderItemModel> Delete(int id);
    }
}
