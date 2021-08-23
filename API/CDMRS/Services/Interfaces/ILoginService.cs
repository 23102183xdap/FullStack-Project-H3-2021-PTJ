using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Models;

namespace API.CDMRS.Services.Interfaces
{
    public interface ILoginService
    {
        Task<List<LoginModel>> GetAll();

        Task<LoginModel> Get(int id);

        Task<LoginModel> Create(LoginModel login);

        Task<LoginModel> Update(int id, LoginModel login);

        Task<LoginModel> Delete(int id);
    }
}
