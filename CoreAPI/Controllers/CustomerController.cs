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
    public class CustomerController : ControllerBase
    {
        private IDBService<Customer, int> custServ;


        public CustomerController(IDBService<Customer, int> serv)
        {
            custServ = serv;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var response = custServ.Get();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = custServ.Get(id);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post(Customer data)
        {
            var response = custServ.Create(data);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(int id, Customer data)
        {
            var response = custServ.Update(id, data);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response = custServ.Delete(id);
            return Ok(response);
        }
    }
}
