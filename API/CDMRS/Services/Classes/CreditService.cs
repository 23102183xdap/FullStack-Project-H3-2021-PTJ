using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Services.Interfaces;
using API.CDMRS.Models;

namespace API.CDMRS.Services.Classes
{
    public class CreditService : ICreditService
    {
        private readonly ICreditRepos _creditRepos;

        public CreditService(ICreditRepos creditRepos)
        {
            _creditRepos = creditRepos;
        }

        public async Task<CreditModel> Create(CreditModel credit)
        {
            var result = await _creditRepos.Create(credit);
            return result;
        }

        public async Task<CreditModel> Delete(int id)
        {
            var result = await _creditRepos.Delete(id);
            return result;
        }
        
        public async Task<CreditModel> Get(int id)
        {
            var result = await _creditRepos.Get(id);
            return result;
        }

        public async Task<List<CreditModel>> GetAll()
        {
            var result = await _creditRepos.GetAll();
            return result;
        }

        public async Task<CreditModel> Update(int id, CreditModel credit)
        {
            var result = await _creditRepos.Update(id, credit);
            return result;
        }
    }
}
