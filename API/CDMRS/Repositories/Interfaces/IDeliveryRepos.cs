using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Repositories.Interfaces
{
    public interface IDeliveryRepos
    {
        Task<List<DeliveryModel>> GetAll();

        Task<DeliveryModel> Get(int id);

        Task<DeliveryModel> Create(DeliveryModel delivery);

        Task<DeliveryModel> Update(int id, DeliveryModel delivery);

        Task<DeliveryModel> Delete(int id);
    }
}
