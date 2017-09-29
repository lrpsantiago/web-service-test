using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        public IActionResult Get()
        {
            var result = new
            {
                names = names.ToList()
            };

            return this.Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var result = new
                {
                    name = names.ToList()[id]
                };

                return this.Ok(result);
            }
            catch (Exception e)
            {
                return this.BadRequest(e);
            }
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
