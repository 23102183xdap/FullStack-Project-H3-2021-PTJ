using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Repositories.Interfaces
{
    public interface ICreditRepos
    {
        Task<List<CreditModel>> GetAll();

        Task<CreditModel> Get(int id);

        Task<CreditModel> Create(CreditModel credit);

        Task<CreditModel> Update(int id, CreditModel credit);

        Task<CreditModel> Delete(int id);
    }
}
