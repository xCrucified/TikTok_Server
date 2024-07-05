using Bussiness_Logic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic.Interfaces
{
    public interface IAccountsService
    {
        Task Register(RegisterModel model);
        Task<LoginResponseDto> Login(LoginModel model);
        Task Logout(string refreshToken);
        Task<UserTokens> RefreshTokens(UserTokens tokens);
    }

    public class ResetToken
    {
        public string Token { get; set; }
    }
    public class ResetPasswordModel
    {
        public string? NewPassword { get; set; }
        public string Token { get; set; }
    }
}
