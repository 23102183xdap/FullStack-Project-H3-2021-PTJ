using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Services.Interfaces;
using API.CDMRS.Models;


namespace API.CDMRS.Services.Classes
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepos _orderRepos;

        public OrderService(IOrderRepos orderRepos)
        {
            _orderRepos = orderRepos;
        }

        public async Task<OrderModel> Create(OrderModel order)
        {
            var result = await _orderRepos.Create(order);
            return result;
        }

        public async Task<OrderModel> Delete(int id)
        {
            var result = await _orderRepos.Delete(id);
            return result;
        }

        public async Task<OrderModel> Get(int id)
        {
            var result = await _orderRepos.Get(id);
            return result;
        }

        public async Task<List<OrderModel>> GetAll()
        {
            var result = await _orderRepos.GetAll();
            return result;
        }

        public async Task<OrderModel> Update(int id, OrderModel order)
        {
            var result = await _orderRepos.Update(id, order);
            return result;
        }
    }
}
