using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Employees;
using TaskWeb_2.DAL;
using TaskWeb_2.Models;
//using TaskWeb_2.DAL.Contracts;
using Microsoft.EntityFrameworkCore;


namespace TaskWeb_2.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        //private readonly EmployessList _employees;
        //private readonly ContractsList _contract;
        public EmployeesController()
        {
            // _employees = employees;
            // _contract = contract;
        }
        [HttpGet("get")]
        public IActionResult GetEmployees()
        {
            EmployessSQL empl = new EmployessSQL();
            return Ok(empl.Employes.ToList());
           // return Ok();
        }
        [HttpPost("add")]
        public IActionResult AddEmployeess([FromBody] EmployessModel employer)
        {
            EmployessSQL empl = new EmployessSQL();
            empl.Employes.Add(employer);
            empl.SaveChanges();
            // _employees.DataBaseEmployess.Add(employer);
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult DelEmployees([FromQuery] int id)
        {

            //foreach (var empl in _employees.DataBaseEmployess)
            //{
            //    if (empl.Id == id)
            //    {
            //        _employees.DataBaseEmployess.Remove(empl);
            //        return Ok(_employees.DataBaseEmployess);
            //    }
            //}

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
            EmployessSQL empl = new EmployessSQL();
            empl.Order.Add(request);
            empl.SaveChanges();
            //   foreach(var contract in _contract.DateBase)
            //    {
            //        if (contract.Id == idcontract)
            //        {
            //          //  contract.Order.Add(order);
            //        }
            //    }
            return Ok();
    }

    }

}
