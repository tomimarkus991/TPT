using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RandomString.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringController : ControllerBase
    {
        // GET: api/String
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Console.WriteLine("ahdhhdsashdhasddhasjhfsdjfjsdjfhsdjfjhsdfjhsdjfjdsfhsdjhfsdjfsdhjhfdsjfsdjfjhdsfjsd");
            return new string[] { "value1", "value2" };
        }

        // GET: api/String/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            Console.WriteLine("ahdhhdsashdhasddhasjhfsdjfjsdjfhsdjfjhsdfjhsdjfjdsfhsdjhfsdjfsdhjhfdsjfsdjfjhdsfjsd");
            Random rnd = new Random();
            return "value" + rnd.Next();
        }

        // POST: api/String
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/String/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
