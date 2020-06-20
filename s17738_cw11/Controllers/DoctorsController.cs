using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using s17738_cw11.DAL;
using s17738_cw11.DTO;
using s17738_cw11.Models;

namespace s17738_cw11.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorsController : ControllerBase
    {

        private readonly DbService _dbService;

        public DoctorsController(DbService dbService)
        {
            _dbService = dbService;
        }

        private DoctorResponseDto MapDoctor(Doctor doctor)
        {
            return new DoctorResponseDto()
            {
                IdDoctor = doctor.IdDoctor,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Email = doctor.Email
            };
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var d = await _dbService.GetDoctorsAsync();

            var response = new List<DoctorResponseDto>();
            foreach (Doctor doctor in d)
            {
                response.Add(MapDoctor(doctor));
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] int id)
        {
            var d = await _dbService.GetDoctorAsync(id);
            if (d == null)
            {
                return NotFound();
            }

            return Ok(MapDoctor(d));
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Doctor doctor)
        {
            var d = await _dbService.CreateDoctorAsync(doctor);
            return Created("/doctors/" + d.IdDoctor, null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync([FromRoute] int id, [FromBody] Doctor doctor)
        {
            await _dbService.UpdateDoctorAsync(id, doctor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            await _dbService.DeleteDoctorAsync(id);
            return NoContent();
        }
    }
}
