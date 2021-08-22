using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Employees;

namespace TaskWeb_2.Controllers
{
//    [Route("api/employees")]
//    [ApiController]
//    public class EmployeesController : ControllerBase
//    {
//        private readonly ListEmployees _employees;
//        public EmployeesController(ListEmployees employees)
//        {
//            _employees = employees;
//        }
//        [HttpGet("get")]
//        public IActionResult GetEmployees()
//        {
//            return Ok(_employees.List);
//        }
//        [HttpPost("add")]
//        public IActionResult AddEmployeess([FromBody] EmployessModel employer)
//        {
//            _employees.List.Add(employer);
//            return Ok();
//        }
//        [HttpDelete("delete")]
//        public IActionResult DelEmployees([FromQuery] int id)
//        {

//            foreach (var empl  in _employees.List)
//            {
//                if (empl.Id == id)
//                {
//                    _employees.List.Remove(empl);
//                    return Ok(_employees.List);
//                }
//            }

//            return Ok(_employees.List);
//        }
//        [HttpPut("put")]
//        public IActionResult PutEmployees([FromQuery] int id, [FromQuery] string name, [FromQuery] int hours)
//        {
//            foreach (var empl in _employees.List)
//            {
//                if (empl.Id == id)
//                {
//                    empl.Name=name;
//                    empl.Hours = hours;
//                    return Ok(_employees.List);
//                }
//            }
//            return Ok(_employees.List);
//        }
//    }

}
