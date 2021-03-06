﻿using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Factory.Factories.ClaimsFactory
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

        List<Claim> IClaims.AddClaims(string UserId, List<string> Roles)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Claim> IClaims.Get(string UserId)
        {
            throw new NotImplementedException();
        }
    }
}
