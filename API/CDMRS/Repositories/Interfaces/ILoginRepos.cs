using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Repositories.Interfaces
{
    public interface ILoginRepos
    {
        Task<List<LoginModel>> GetAll();

        Task<LoginModel> Get(int id);

        Task<LoginModel> Create(LoginModel login);

        Task<LoginModel> Update(int id, LoginModel login);

        Task<LoginModel> Delete(int id);
    }
}
