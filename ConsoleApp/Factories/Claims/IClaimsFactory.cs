using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factories.Claims
{
    interface IClaimsFactory
    {
        IClaims CreateClaims();
        IClaims GetClaims();

    }
}
