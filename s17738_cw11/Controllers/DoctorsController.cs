using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using s17738_cw11.DAL;
using s17738_cw11.Models;

namespace s17738_cw11.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorsController : ControllerBase
    {

        private readonly SqlServerDbService _dbService;

        public DoctorsController(SqlServerDbService sqlServerDbService)
        {
            _dbService = sqlServerDbService;
        }

        [HttpGet]
        public async Task<IEnumerable<Doctor>> GetAsync()
        {
            return await _dbService.GetDoctorsAsync();
        }

        [HttpGet("{id}")]
        public async Task<Doctor> GetAsync([FromRoute] int id)
        {
            return await _dbService.GetDoctor(id);
        }

        [HttpPost]
        public void Post([FromBody] Doctor doctor)
        {
        }

        [HttpPut("{id}")]
        public void Put([FromRoute] int id, [FromBody] Doctor doctor)
        {
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
        }
    }
}
