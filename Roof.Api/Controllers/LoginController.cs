using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Roof.Core;
using Roof.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roof.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger _logger;
        
        LoginService _loginService;
        public LoginController(LoginService loginService, ILogger<EmployeeController> logger)
        {
            _loginService = loginService;
            _logger = logger;
        }

        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public IActionResult Login([FromForm] GrantInfo authInfo)
        {
            try
            {                
                return Ok(_loginService.Login(authInfo));
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(500);
            }
        }
    }
}
