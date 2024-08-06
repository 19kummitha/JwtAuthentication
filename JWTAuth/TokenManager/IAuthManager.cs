using JWTAuth.Model;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuth.TokenManager
{
    public interface IAuthManager
    {
        Task<IActionResult> Login(Login model);
        Task<IActionResult> Register(Register model);
        Task<IActionResult> RegisterAdmin(Register model);
    }
}
