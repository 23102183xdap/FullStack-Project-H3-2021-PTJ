using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Services.Interfaces;
using API.CDMRS.Models;

namespace API.CDMRS.Services.Classes
{
    public class CustomerService : ICustomerRepos
    {
        private readonly ICustomerRepos _customerRepos;

        public CustomerService(ICustomerRepos customerRepos)
        {
            _customerRepos = customerRepos;
        }

        public async Task<CustomerModel> Create(CustomerModel customer)
        {
            var result = await _customerRepos.Create(customer);
            return result;
        }

        public async Task<CustomerModel> Delete(int id)
        {
            var result = await _customerRepos.Delete(id);
            return result;
        }

        public async Task<CustomerModel> Get(int id)
        {
            var result = await _customerRepos.Get(id);
            return result;
        }

        public async Task<CustomerModel> GetAll()
        {
            var result = await _customerRepos.GetAll();
            return result;
        }

        public async Task<CustomerModel> Update(int id, CustomerModel customer)
        {
            var result = await _customerRepos.Update(id, customer);
            return result;
        }
    }
}
