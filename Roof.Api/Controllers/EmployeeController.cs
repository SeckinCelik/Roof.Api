using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Roof.Core.Models.Application;
using Roof.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Roof.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        Configuration _appConfiguration;
        EmployeeService _employeeService;
        ILogger<EmployeeController> _logger;

        public EmployeeController(Configuration configuration, EmployeeService employeeService, ILogger<EmployeeController> logger)
        {
            _appConfiguration = configuration;
            _employeeService = employeeService;
            _logger = logger;
        }


        [HttpPost("get-employee")]
        [Authorize("read")]
        public IActionResult GetEmployee([FromQuery, Required] Guid guid)
        {
            try
            {
                var employee = _employeeService.GetEmployee(guid);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(500);
            }
        }
    }
}
