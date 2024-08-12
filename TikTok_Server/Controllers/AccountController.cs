using business_logic.DTOs;
using business_logic.Interfaces;
using business_logic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TikTok_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountsService _accountsService;
        public AccountController(IAccountsService accountsService)
        {
            this._accountsService = accountsService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromForm] RegisterModel model)
        {
            await _accountsService.Register(model);
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            return Ok(await _accountsService.Login(model));
        }

        [HttpPost("refreshTokens")]
        public async Task<IActionResult> RefreshTokens(UserTokens tokens)
        {
            return Ok(await _accountsService.RefreshTokens(tokens));
        }

        [HttpPost("Logout")]
        public async Task<IActionResult> Logout(LogoutModel model)
        {
            await _accountsService.Logout(model.RefreshToken);
            return Ok();
        }
    }
}
