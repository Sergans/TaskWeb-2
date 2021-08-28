using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Customers;
using TaskWeb_2.Employees;
using TaskWeb_2.DAL;
using TaskWeb_2.Models;

namespace TaskWeb_2.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepository<CustomerModel> _repository;
        public CustomerController(CustomerService repository)
        {
            _repository = repository;
        }
        [HttpGet("get")]
        public IActionResult GetCustomer()
        {
            return Ok(_repository.AllGet());
        }
        [HttpPost("add")]
        public IActionResult AddCustomer([FromBody] CustomerModel customer)
        {
            _repository.Create(customer);
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult DelCustomer([FromQuery]int customer)
        {
            _repository.Delete(customer);
            return Ok();
        }
        [HttpPut("put")]
        public IActionResult PutCustomer([FromQuery] int customer, [FromQuery] string fname, [FromQuery] string lname)
        {
            _repository.UpData(customer,fname,lname);
            return Ok();
        }
    }
}
