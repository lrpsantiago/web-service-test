using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebServiceTest.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IEnumerable<string> names;

        public ValuesController()
        {
            this.names = new List<string>
            {
                "Luiz Ricardo Paiva Santiago",
                "Joyciane Ferreira Cavalcante Marques"
            };
        }

        // GET api/values
        [HttpGet]
        public dynamic Get()
        {
            var result = new
            {
                names = names.ToList()
            };

            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public dynamic Get(int id)
        {
            var result = new
            {
                name = names.ToList()[id]
            };

            return result;
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
    }
}
