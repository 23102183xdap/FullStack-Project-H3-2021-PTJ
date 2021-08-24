using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Services.Interfaces;
using API.CDMRS.Models;

namespace API.CDMRS.Services.Classes
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemRepos _orderItemRepos;

        public OrderItemService(IOrderItemRepos orderItemRepos)
        {
            _orderItemRepos = orderItemRepos;
        }

        public async Task<OrderItemModel> Create(OrderItemModel orderItem)
        {
            var result = await _orderItemRepos.Create(orderItem);
            return result;
        }

        public async Task<OrderItemModel> Delete(int id)
        {
            var result = await _orderItemRepos.Delete(id);
            return result;
        }

        public async Task<OrderItemModel> Get(int id)
        {
            var result = await _orderItemRepos.Get(id);
            return result;
        }

        public async Task<List<OrderItemModel>> GetAll()
        {
            var result = await _orderItemRepos.GetAll();
            return result;
        }

        public async Task<OrderItemModel> Update(int id, OrderItemModel orderItem)
        {
            var result = await _orderItemRepos.Update(id, orderItem);
            return result;
        }
    }
}
