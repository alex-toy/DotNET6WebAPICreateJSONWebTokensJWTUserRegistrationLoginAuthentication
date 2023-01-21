using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Configuration;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthManagementController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtConfig _jwtConfig;

        public AuthManagementController(UserManager<IdentityUser> userManager, JwtConfig jwtConfig)
        {
            _userManager = userManager;
            _jwtConfig = jwtConfig;
        }


    }
}
