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
        private readonly IContractService _contrservice;
        private readonly ITaskService _taskservice;
        public ContractController(ContractService repository,TaskService repositorytask,ContractService contrserv,TaskService taskserv)
        {
            _contrservice = contrserv;
            _taskservice = taskserv;

        }
        [HttpGet("get")]
        public IActionResult GetController()
        {
            return Ok(_contrservice.AllGet());
        }
        [HttpPost("add")]
        public IActionResult AddCustomer([FromBody] ContractModel contract)
        {
            _contrservice.Create(contract);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete([FromQuery] int idcontract)
        {
            _contrservice.Delete(idcontract);
            return Ok();
        }
        [HttpGet("invoice")]
        public IActionResult GetInvoice([FromQuery]DateTime from,[FromQuery]DateTime to,[FromQuery]int idcontract)
        {
            var hours = _taskservice.GetHours(from, to, idcontract);
            var cost = _contrservice.GetCost(idcontract);
            var sum = hours * cost;
            var customer = _contrservice.GetCustomer(idcontract);
            var invoice = new InvoiceModel() { FirstName=customer.FirstName,LastName=customer.LastName, Sum=sum,DateCreate=from,DateClose=to};
            return Ok(invoice);
        }

    }
}
