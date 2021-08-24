using System.Collections.Generic;
using System.Threading.Tasks;

using API.CDMRS.Repositories.Interfaces;
using API.CDMRS.Services.Interfaces;
using API.CDMRS.Models;

namespace API.CDMRS.Services.Classes
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepos _loginRepos;

        public LoginService(ILoginRepos loginRepos)
        {
            _loginRepos = loginRepos;
        }

        public async Task<LoginModel> Create(LoginModel login)
        {
            var result = await _loginRepos.Create(login);
            return result;
        }

        public async Task<LoginModel> Delete(int id)
        {
            var result = await _loginRepos.Delete(id);
            return result;
        }

        public async Task<LoginModel> Get(int id)
        {
            var result = await _loginRepos.Get(id);
            return result;
        }

        public async Task<List<LoginModel>> GetAll()
        {
            var result = await _loginRepos.GetAll();
            return result;
        }

        public async Task<LoginModel> Update(int id, LoginModel login)
        {
            var result = await _loginRepos.Update(id, login);
            return result;
        }
    }
}
