using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Factory.Factories.Claims
{
    class ADLDSFactory : IClaimsFactory
    {
        public IClaims CreateClaims()
        {
            return new ADLDSClaims();
        }

        public IClaims GetClaims()
        {
            return new ADLDSClaims();
        }
    }

    class ADLDSClaims : IClaims
    {

        List<Claim> IClaims.Create(string UserId, List<string> Roles)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Claim> IClaims.Get(string UserId)
        {
            throw new NotImplementedException();
        }
    }
}
