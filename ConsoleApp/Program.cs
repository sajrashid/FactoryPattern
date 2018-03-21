using Factory.Factories.ClaimsFactory;
using System.Collections.Generic;

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
            AuthType authType = AuthType.JWT;
            var User = new { UserId = "Mule",  Roles = new List<string> { "Mule" } };

            // AuthType claimType = AuthType.Windows;
            // var SomeUser = new { UserId = "12049436", Roles = new List<string> { "WindowsAuth" } };


            // Switch on the claimType enum.
            IClaimsFactory factory = null;
            switch (authType)
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

