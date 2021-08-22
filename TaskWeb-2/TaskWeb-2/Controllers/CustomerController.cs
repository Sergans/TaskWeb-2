using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.Customers;

namespace TaskWeb_2.Controllers
{
    //[Route("api/customer")]
    //[ApiController]
    //public class CustomerController : ControllerBase
    //{
    //    private readonly ListCustomers _customer;
    //    public CustomerController(ListCustomers customer)
    //    {
    //        _customer = customer;
    //    }
    //    [HttpGet("get")]
    //    public IActionResult GetCustomers()
    //    {
    //        return Ok(_customer.List);
    //    }
    //    [HttpPost("add")]
    //    public IActionResult AddCustomer([FromBody] CustomerModel customer)
    //    {
    //        _customer.List.Add(customer);
    //        return Ok();
    //    }
    //}
}
