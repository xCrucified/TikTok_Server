﻿using System.Security.Claims;
using Bussiness_Logic.Entities;
using Bussiness_Logic.Interfaces;

namespace Bussiness_Logic.Services;

public class JwtService: IJwtService
{
    public IEnumerable<Claim> GetClaims(User user)
    {
        throw new NotImplementedException();
    }

    public string CreateToken(IEnumerable<Claim> claims)
    {
        throw new NotImplementedException();
    }

    public string CreateRefreshToken()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Claim> GetClaimsFromExpiredToken(string token)
    {
        throw new NotImplementedException();
    }
}

// готовий код підставити просто вище

// private readonly IConfiguration configuration;
// private readonly UserManager<User> userManager;
// private readonly JwtOptions jwtOptions;
//
// public JwtService(IConfiguration configuration, UserManager<User> userManager)
// {
//     this.configuration = configuration;
//     this.userManager = userManager;
//     this.jwtOptions = configuration.GetSection(nameof(JwtOptions)).Get<JwtOptions>()!;
// }
//
// public string CreateToken(IEnumerable<Claim> claims)
// {
//     // TODO: make separate method
//     var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.Key));
//     var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
//
//     var token = new JwtSecurityToken(
//         issuer: jwtOptions.Issuer,
//         claims: claims,
//         expires: DateTime.UtcNow.AddDays(jwtOptions.AccessTokenLifetimeInMinutes),
//         signingCredentials: credentials);
//
//     return new JwtSecurityTokenHandler().WriteToken(token);
// }
//
// public IEnumerable<Claim> GetClaims(User user)
// {
//     var claims = new List<Claim>
//     {
//         new Claim(ClaimTypes.NameIdentifier, user.Id),
//         new Claim(ClaimTypes.Email, user.Email),
//     };
//
//     var roles = userManager.GetRolesAsync(user).Result;
//     claims.AddRange(roles.Select(role => new Claim(ClaimsIdentity.DefaultRoleClaimType, role)));
//
//     return claims;
// }
//
// public string CreateRefreshToken()
// {
//     var randomNumber = new byte[64];
//     using var rng = RandomNumberGenerator.Create();
//     rng.GetBytes(randomNumber);
//     return Convert.ToBase64String(randomNumber);
// }
//
// public IEnumerable<Claim> GetClaimsFromExpiredToken(string token)
// {
//     var tokenValidationParameters = new TokenValidationParameters
//     {
//         ValidateIssuer = true,
//         ValidateAudience = false,
//         ValidateLifetime = false,
//         ValidateIssuerSigningKey = true,
//         ValidIssuer = jwtOptions.Issuer,
//         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.Key)),
//     };
//
//     var tokenHandler = new JwtSecurityTokenHandler();
//     JwtSecurityToken jwtSecurityToken;
//
//     tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
//     jwtSecurityToken = securityToken as JwtSecurityToken;
//
//     if (jwtSecurityToken == null ||
//         !jwtSecurityToken.Header.Alg
//             .Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
//     {
//         throw new HttpException(Errors.InvalidToken, HttpStatusCode.BadRequest);
//     }
//
//     return jwtSecurityToken.Claims;
// }
//
// public DateTime GetLastValidRefreshTokenDate()
// {
//     return DateTime.UtcNow.AddDays(-jwtOptions.RefreshTokenLifetimeInDays);
// }