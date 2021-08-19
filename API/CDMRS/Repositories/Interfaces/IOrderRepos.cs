using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Repositories.Interfaces
{
    public interface IOrderRepos
    {
        Task<List<OrderModel>> GetAll();

        Task<OrderModel> Get(int id);

        Task<OrderModel> Create(OrderModel order);

        Task<OrderModel> Update(int id, OrderModel order);

        Task<OrderModel> Delete(int id);
    }
}
