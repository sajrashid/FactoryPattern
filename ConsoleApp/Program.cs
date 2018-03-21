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
        enum AuthType
        {
            JWT,
            Windows

        }
        static void Main()
        {
            AuthType claimType = AuthType.JWT;
            var User = new { UserId = "Mule",  Roles = new List<string> { "Mule" } };

            // ClaimType claimType = ClaimType.Windows;
            // var SomeUser = new { UserId = "12049436", Roles = new List<string> { "WindowsAuth" } };


            // Switch on the claimType enum.
            IClaimsFactory factory = null;
            switch (claimType)
            {
                case AuthType.JWT:
                    factory = new JWTFactory();
                    break;
                case AuthType.Windows:
                    factory = new ADLDSFactory();
                    break;
                default:
                    throw new System.NotImplementedException();

            }
            
            var claimsFactory = factory.CreateClaims();
            var claims = claimsFactory.Create(User.UserId, User.Roles);
        }
    }
}

