using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Employees;
using TaskWeb_2.DAL;
using TaskWeb_2.Models;

using Microsoft.EntityFrameworkCore;


namespace TaskWeb_2.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IRepository<EmployessModel> _repository;
        public EmployeesController(EmployesService repository)
        {
            _repository = repository;
        }
        [HttpGet("get")]
        public IActionResult GetEmployees()
        {
           return Ok(_repository.AllGet());
        }
        [HttpPost("add")]
        public IActionResult AddEmployeess([FromBody] EmployessModel employer)
        {
            _repository.Create(employer); 
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult DelEmployees([FromQuery] int id)
        {
           
            return Ok();
        }
        [HttpPut("put")]
        public IActionResult PutEmployees([FromQuery] int id, [FromQuery] string name, [FromQuery] int hours)
        {
            //foreach (var empl in _employees.DataBaseEmployess)
            //{
            //    if (empl.Id == id)
            //    {
            //        empl.Name = name;

            //        return Ok();
            //    }
            //}
            return Ok();
        }
        [HttpPost("order")]
        public IActionResult AddOrderTask([FromQuery] int idemployer, [FromQuery] int idcontract, [FromQuery] DateTime date, [FromQuery] int hours)
          
        { var request = new TaskModel {IdEmployer=idemployer,IdContract=idcontract,Date=date, Hours = hours };
            BaseSQL empl = new BaseSQL();
            empl.Order.Add(request);
            empl.SaveChanges();
            
            return Ok();
        }
        [HttpGet("gettask")]
        public IActionResult GetTask()
        {
            BaseSQL empl = new BaseSQL();
            return Ok(empl.Order.ToList());
            // return Ok();
        }


    }

}
