using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaProjesi.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebProgramlamaProjesi.Controllers
{
    [Route("api/kullanicilar")]
    [ApiController]
    public class IdentityUserController : ControllerBase
    {
        private ApplicationDbContext db;
        public IdentityUserController(ApplicationDbContext tmp)
        {
            db = tmp;
        }

        [HttpGet]
        public IEnumerable<IdentityUser> Get()
        {
            var user = db.Users.ToList();
            return user;
        }

        // GET api/<IdentityUserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IdentityUserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IdentityUserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IdentityUserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
