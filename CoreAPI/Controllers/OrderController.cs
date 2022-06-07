using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPI.Models;
using CoreAPI.Services;

namespace CoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IDBService<Orders, int> ordServ;
        

        public OrderController(IDBService<Orders, int> serv)
        {
            ordServ = serv;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var response = ordServ.Get();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = ordServ.Get(id);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post(Orders data)
        {
            var response = ordServ.Create(data);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(int id, Orders data)
        {
            var response = ordServ.Update(id, data);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response = ordServ.Delete(id);
            return Ok(response);
        }
    }
}
