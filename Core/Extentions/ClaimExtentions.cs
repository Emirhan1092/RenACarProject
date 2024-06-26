﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Core.Extentions
{
    public static class ClaimExtentions
    {

        public static void AddEmail (this ICollection<Claim> claims , string email)
        {
            claims.Add(new Claim(JwtRegisteredClaimNames.Email,value : email));
        }

        public static void AddName(this ICollection<Claim> claims, string name)
        {
            claims.Add(new Claim(ClaimTypes.Name, value: name));
        }
        public static void AddNameIdentifier(this ICollection<Claim> claims, string nameIdentifier)
        {
            claims.Add(new Claim(ClaimTypes.NameIdentifier, value: nameIdentifier));
        }
        public static void AddRoles(this ICollection<Claim> claims, string[] roles)
        {
            roles.ToList().ForEach(role => claims.Add(new Claim(ClaimTypes.Role, value: role)));
        }
    }

}
