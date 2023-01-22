using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TodoApp.Configuration;
using TodoApp.Models.DTOs.Requests;

namespace TodoApp.AuthenticationUtils
{
    public class JwtAuthenticationService : IJwtAuthenticationService
    {
        private readonly JwtConfig _jwtConfig;

        public JwtAuthenticationService(IOptionsMonitor<JwtConfig> optionsMonitor)
        {
            _jwtConfig = optionsMonitor.CurrentValue;
        }

        public string GenerateToken(IdentityUser user)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] secret = Encoding.UTF8.GetBytes(_jwtConfig.Secret);
            var key = new SymmetricSecurityKey(secret);
            var claims = GetClaims(user);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        //public IdentityUser Authenticate(UserRegistrationDto login)
        //{
        //    var users = GetUsersFromDB();
        //    return users.Where(u => u.Email.ToUpper().Equals(login.Email.ToUpper()) && u.Password.Equals(login.Password)).FirstOrDefault();
        //}

        private static List<Claim> GetClaims(IdentityUser user)
        {
            return new List<Claim>
            {
                new Claim("Id", user.Id),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
        }

        //public User GetCurrentUserFromHttpContext(HttpContext httpContext)
        //{
        //    ClaimsIdentity identity = httpContext.User.Identity as ClaimsIdentity;

        //    if (identity == null) return null;

        //    User user = GetUserModelFromClaim(identity);
        //    return user;
        //}

        //private User GetUserModelFromClaim(ClaimsIdentity identity)
        //{
        //    IEnumerable<Claim> userClaims = identity.Claims;

        //    return new User
        //    {
        //        Name = userClaims.ExtractUserClaim(ClaimTypes.Name),
        //        Email = userClaims.ExtractUserClaim(ClaimTypes.Email),
        //        Role = userClaims.ExtractUserClaim(ClaimTypes.Role)
        //    };
        //}
    }
}
