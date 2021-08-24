using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskWeb_2.DAL;
using TaskWeb_2.DAL.Contracts;
using Microsoft.EntityFrameworkCore;



namespace TaskWeb_2.Controllers
{
    [Route("api/service")]
    [ApiController]
    public class Contract : ControllerBase
    {
        private readonly Service _service;
        private readonly ContractsList _contract;
        public Contract(Service servise, ContractsList contract)
        {
            _contract = contract;
            _service = servise;
        }
        [HttpGet("get")]
        public IActionResult Get()
        {
            ContractSQL contact = new ContractSQL();
            //contact.Contract.ToList();
            return Ok(contact.Contract.ToList());
        }
        [HttpPost("create")]
        public IActionResult Create([FromBody] ContractModel contract)
        {
            ContractSQL contact = new ContractSQL();
            contact.Contract.Add(contract);
            contact.SaveChanges();
           // _contract.DateBase.Add(contract);
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult Delete()
        {
            ContractSQL contact = new ContractSQL();
            
            return Ok();
        }
        [HttpPut("edit")]
        public IActionResult Rename()
        {
            return Ok();
        }
        [HttpGet("invoice")]
        public IActionResult GetInvoice([FromQuery]int idcontract,[FromQuery]decimal bet)
        {
            decimal sum = 0;
            foreach (var contract in _contract.DateBase)
            {
                if (contract.Id == idcontract)
                {

                    //foreach (var order in contract.Order)
                    //{
                    //    sum +=order.Hours;
                    //}
                }
            }
            return Ok(sum*bet);
        }
    }
}
