using Factory.Factories.Claims;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Factory
{
    class Program
    {
        static void Main()
        {
            var SomeUser = new { UserId = "Mule", ClaimType = "JWT", Roles = new List<string> { "Mule" } };
            // var SomeUser = new { UserId = "12049436", ClaimType = "ADLDS", Roles = new List<string> { "WindowsAuth" } };


            IClaimsFactory factory;
            switch (SomeUser.ClaimType)
            {
                case "JWT":
                    factory = new JWTFactory();
                    break;
                case "ADLDS":
                    factory = new ADLDSFactory();
                    break;
                default:
                    throw new System.NotImplementedException();
            }

            var claimsFactory = factory.CreateClaims();
            var claims= claimsFactory.Create(SomeUser.UserId, SomeUser.Roles);
        }
    }
}

