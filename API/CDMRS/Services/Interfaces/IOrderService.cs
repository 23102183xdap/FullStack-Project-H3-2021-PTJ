using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Services.Interfaces
{
    public  interface IOrderService
    {
        Task<List<OrderModel>> GetAll();

        Task<OrderModel> Get(int id);

        Task<OrderModel> Create(OrderModel order);

        Task<OrderModel> Update(int id, OrderModel order);

        Task<OrderModel> Delete(int id);
    }
}
