using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net6_JwtAuthWithCustomMiddleware.Shared;
using System.Security.Claims;
using System.Text;

namespace Net6_JwtAuthWithCustomMiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        private readonly IJwtUtils _iJwtUtils;

        public LoginController(IConfiguration configuration,
            IJwtUtils iJwtUtils)
        {
            _configuration = configuration;
            _iJwtUtils = iJwtUtils;
        }



        [HttpPost]
        public IActionResult Login(string UserName, string Password)
        {
            User user = new User()
            {
                Id = 1,
                UserName = UserName,
                Password = Password,
                Name = "Admin",
                Email = "",
                Roles = new List<string> { "SuperAdmin" }
            };

            var token = _iJwtUtils.GenerateToken(user);
            return Ok(token);
        }
    }
}
