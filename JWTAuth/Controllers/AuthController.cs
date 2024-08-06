using JWTAuth.Model;
using JWTAuth.TokenManager;

using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;


namespace JWTAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthManager _authManager;

        public AuthController(IAuthManager authManager)
        {
            _authManager = authManager;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] Login model)
        {
            return await _authManager.Login(model);
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] Register model)
        {
            return await _authManager.Register(model);
        }

        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] Register model)
        {
            return await _authManager.RegisterAdmin(model);
        }
    }
}
