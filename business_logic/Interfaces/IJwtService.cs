﻿using business_logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Interfaces
{
    public interface IJwtService
    {
        IEnumerable<Claim> GetClaims(User user);
        string CreateToken(IEnumerable<Claim> claims);
        string CreateRefreshToken();
        IEnumerable<Claim> GetClaimsFromExpiredToken(string token);
        DateTime GetLastValidRefreshTokenDate();

    }
}
