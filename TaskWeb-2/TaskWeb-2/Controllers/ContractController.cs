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
    [Route("api/service")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IRepository<ContractModel> _repository;
        public ContractController(ContractService repository)
        {
            _repository = repository;
        }
        [HttpGet("get")]
        public IActionResult GetController()
        {
            return Ok(_repository.AllGet());
        }
        [HttpPost("add")]
        public IActionResult AddCustomer([FromBody] ContractModel contract)
        {
            _repository.Create(contract);
            return Ok();
        }
        [HttpGet("invoice")]
        public IActionResult GetInvoice()
        {
            return Ok();
        }

    }
}
