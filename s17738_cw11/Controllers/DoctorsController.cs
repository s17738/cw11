using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace s17738_cw11.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "doctor1", "doctor2" };
        }

        [HttpGet("{id}")]
        public string Get([FromRoute] int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string doctor)
        {
        }

        [HttpPut("{id}")]
        public void Put([FromRoute] int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
        }
    }
}
