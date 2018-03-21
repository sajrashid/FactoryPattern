using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Factory.Factories.ClaimsFactory
{
    interface IClaims
    {
        List<Claim> Create(String UserId, List<string> Roles);
        IEnumerable<Claim> Get(String UserId);

    }
    
}
