using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net6_JwtAuthWithCustomMiddleware.Shared;
using System.Data;

namespace Net6_JwtAuthWithCustomMiddleware.Controllers
{
    [CustomAuthorizeAttribute(Roles = "SuperAdmin, Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { EmployeeId = 1 });
        }
    }
}
