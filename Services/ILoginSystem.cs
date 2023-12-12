using TestApiJWT.Models;

namespace ProjectEweis.Services
{
    public interface ILoginSystem
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
