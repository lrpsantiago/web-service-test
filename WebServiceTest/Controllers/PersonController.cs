using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebServiceTest.Contexts;
using WebServiceTest.Entities;

namespace WebServiceTest.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult GetAll()
        {
            using (var context = new MyContext())
            {
                try
                {
                    var result = context.Persons.GetAll();

                    return this.Ok(result);
                }
                catch (Exception e)
                {
                    return this.BadRequest(e);
                }
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var context = new MyContext())
            {
                try
                {
                    var result = context.Persons.Get(id);
                    
                    return this.Ok(result);
                }
                catch (Exception e)
                {
                    return this.BadRequest(e);
                }
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Person p)
        {
            using (var context = new MyContext())
            {
                try
                {
                    var person = new Person
                    {
                        Name = p.Name
                    };

                    context.Persons.Add(person);
                    context.SaveChanges();

                    return this.Ok();
                }
                catch (Exception e)
                {
                    return this.BadRequest(e);
                }
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]string name)
        {
            using (var context = new MyContext())
            {
                try
                {
                    var person = context.Persons.Get(id);

                    person.Name = name;

                    context.SaveChanges();

                    return this.Ok();
                }
                catch (Exception e)
                {
                    return this.BadRequest(e);
                }
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (var context = new MyContext())
            {
                try
                {
                    var person = context.Persons.Get(id);

                    context.Persons.Remove(person);
                    context.SaveChanges();

                    return this.Ok();
                }
                catch (Exception e)
                {
                    return this.BadRequest(e);
                }
            }
        }
    }
}
