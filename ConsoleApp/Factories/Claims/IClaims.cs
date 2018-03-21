using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Factory.Factories.Claims
{
    interface IClaims
    {
        List<Claim> Create(String UserId, List<string> Roles);
        IEnumerable<Claim> Get(String UserId);

    }
    
}
