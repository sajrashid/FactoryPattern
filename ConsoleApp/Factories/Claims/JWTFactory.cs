using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Factory.Factories.Claims
{
     class JWTFactory : IClaimsFactory
        {
            public IClaims CreateClaims()
            {
                return new JWTClaims();
            }

            public IClaims GetClaims()
            {
                return new JWTClaims();
            }
     }

     class JWTClaims : IClaims
     {
        private IHttpContextAccessor _httpContext;

        List<Claim> IClaims.Create(string UserId, List<string> Roles)
        {

            // create a list of claims and add userId 
            var claims = new List<Claim>
            {
              new Claim(ClaimsIdentity.DefaultNameClaimType, UserId),
              new Claim(JwtRegisteredClaimNames.Sub, UserId),

            };
            // add roles to the claims list
            // for every role add a new claim type role
            foreach (var role in Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            // var identity = new ClaimsIdentity(claims);
            return claims;
        }

       

        IEnumerable<Claim> IClaims.Get(string UserId)
        {
            var identity = _httpContext.HttpContext.User;
            IEnumerable<Claim> claims = identity.Claims;
            return claims;
        }
    }

}
