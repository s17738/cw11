using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace s17738_cw11.Controllers
{
    [ApiController]
    [Route("api")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var res = new string[] { "value1", "value2" };
            return Ok(res);
        }
    }
}
