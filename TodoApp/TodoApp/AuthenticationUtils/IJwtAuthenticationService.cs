using Microsoft.AspNetCore.Identity;
using TodoApp.Models.DTOs.Requests;

namespace TodoApp.AuthenticationUtils
{
    public interface IJwtAuthenticationService
    {
        //IdentityUser Authenticate(UserRegistrationDto model);
        string GenerateToken(IdentityUser user);
        //IdentityUser GetCurrentUserFromHttpContext(HttpContext httpContext);
    }
}
