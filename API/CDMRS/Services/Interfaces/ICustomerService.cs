using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<CustomerModel>> GetAll();

        Task<CustomerModel> Get(int id);

        Task<CustomerModel> Create(CustomerModel customer);

        Task<CustomerModel> Update(int id, CustomerModel customer);

        Task<CustomerModel> Delete(int id);
    }
}
