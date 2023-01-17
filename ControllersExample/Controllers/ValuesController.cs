using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ControllersExample.Models; 

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControllersExample.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id:int}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET: api/values/getHype
        [HttpGet("{action}")]
        public string GetHype()
        {
            return "Let's gooooooo";
            //return "{ \"key\": \"value\"}"; 
        }

        // GET: api/values/getPerson/4
        [HttpGet("getPerson/{id}")]
        public JsonResult GetPerson(int id)
        {
            Person person = new Person()
            {
                ID = Guid.NewGuid(),
                FirstName = "Mary",
                LastName = "Smith",
                Age = 25
            };

            return new JsonResult(person); 
            //return "{ \"key\": \"value\"}";
        }
    }
}

