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
        private readonly IRepository<ContractModel> _contrrepository;
        public EmployeesController(EmployesService repository,ContractService contrrepository)
        {
            _contrrepository = contrrepository;
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
            _repository.Delete(id);
            return Ok();
        }
        [HttpPut("put")]
        public IActionResult PutEmployees([FromQuery] int id, [FromQuery] string fname, [FromQuery] string lname)
        {
            _repository.UpData(id, fname, lname);
            return Ok();
        }
        [HttpPost("order")]
        public IActionResult AddOrderTask([FromBody] EmployessModel idemployer, [FromQuery] int idcontract, [FromQuery] DateTime date, [FromQuery] int hours)
        {
            var request = new TaskModel {IdEmployer=idemployer.Id,IdContract=idcontract,Date=date, Hours = hours };
            
            BaseSQL empl = new BaseSQL();
            foreach(var person in _repository.AllGet())
            {
                if (person.FirstName == idemployer.FirstName&&person.LastName==idemployer.LastName)
                {
                   foreach(var contr in _contrrepository.AllGet())
                    {
                        if (contr.Id == idcontract)
                        {
                            empl.Order.Add(request);
                            empl.SaveChanges();
                            return Ok("Добавлено");
                        }
                    }
                   
                }

            }
           
           
            return Ok("НЕТ СОТРУДНИКА ИЛИ КОНТРАКТА");
        }
        [HttpGet("gettask")]
        public IActionResult GetTask()
        {
            BaseSQL empl = new BaseSQL();
            return Ok(empl.Order.ToList());
           
        }


    }

}
