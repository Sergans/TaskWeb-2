using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskWeb_2.Controllers
{
    [Route("api/service")]
    [ApiController]
    public class Contract : ControllerBase
    {
        [HttpGet("get")]
        public IActionResult Get()
        {
            return Ok();
        }
        [HttpPost("create")]
        public IActionResult Create()
        {
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult Delete()
        {
            return Ok();
        }
        [HttpPut("edit")]
        public IActionResult Rename()
        {
            return Ok();
        }
    }
}
