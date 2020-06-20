using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using s17738_cw11.Models;

namespace s17738_cw11.DAL
{
    public class SqlServerDbService : DbService
    {
        private readonly S17738DbContext _context;

        public SqlServerDbService(S17738DbContext s17738DbContext)
        {
            _context = s17738DbContext;
        }

        public async Task<IEnumerable<Doctor>> GetDoctorsAsync()
        {
            return await _context.Doctors.ToListAsync();
        }

        public async Task<Doctor> GetDoctorAsync(int id)
        {
            return await _context.Doctors.FindAsync(id);
        }

        public async Task<Doctor> CreateDoctorAsync(Doctor doctor)
        {
            var d = new Doctor()
            {
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Email = doctor.Email
            };
            _context.Doctors.Add(d);
            await _context.SaveChangesAsync();
            return d;
        }

        public async Task<bool> UpdateDoctorAsync(int id, Doctor doctor)
        {
            var d = new Doctor()
            {
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Email = doctor.Email
            };
            _context.Entry(d).Property("FirstName").IsModified = true;
            _context.Entry(d).Property("LastName").IsModified = true;
            _context.Entry(d).Property("Email").IsModified = true;

            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<bool> DeleteDoctorAsync(int id)
        {
            var d = new Doctor()
            {
                IdDoctor = id
            };

            _context.Attach(d);
            _context.Remove(d);
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
