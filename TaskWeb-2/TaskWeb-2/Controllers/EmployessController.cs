using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Employees;

namespace TaskWeb_2.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ListEmployees _employees;
        public EmployeesController(ListEmployees employees)
        {
            _employees = employees;
        }
        [HttpGet("get")]
        public IActionResult GetEmployees()
        {
            return Ok(_employees.List);
        }
        [HttpPost("add")]
        public IActionResult AddEmployeess([FromBody] EmployeesModel employer)
        {
            _employees.List.Add(employer);
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult DelEmployees(int id)
        {
            return Ok();
        }
        [HttpPut("put")]
        public IActionResult PutEmployees(int id)
        {
            return Ok();
        }
    }

}
