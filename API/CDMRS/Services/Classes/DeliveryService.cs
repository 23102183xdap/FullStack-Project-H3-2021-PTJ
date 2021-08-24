using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Services.Interfaces;
using API.CDMRS.Models;

namespace API.CDMRS.Services.Classes
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IDeliveryRepos _deliveryRepos;

        public DeliveryService(IDeliveryRepos deliveryRepos)
        {
            _deliveryRepos = deliveryRepos;
        }

        public async Task<DeliveryModel> Create(DeliveryModel delivery)
        {
            var result = await _deliveryRepos.Create(delivery);
            return result;
        }

        public async Task<DeliveryModel> Delete(int id)
        {
            var result = await _deliveryRepos.Delete(id);
            return result;
        }

        public async Task<DeliveryModel> Get(int id)
        {
            var result = await _deliveryRepos.Get(id);
            return result;
        }

        public async Task<List<DeliveryModel>> GetAll()
        {
            var result = await _deliveryRepos.GetAll();
            return result;
        }

        public async Task<DeliveryModel> Update(int id, DeliveryModel delivery)
        {
            var result = await _deliveryRepos.Update(id, delivery);
            return result;
        }
    }
}
