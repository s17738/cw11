using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using s17738_cw11.Models;

namespace s17738_cw11.DAL
{
    public class SqlServerDbService
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

        public async Task<Doctor> GetDoctor(int id)
        {
            return await _context.Doctors.FindAsync(id);
        }

        public void CreateDoctor(string doctor)
        {
        }

        public void UpdateDoctor(int id, string doctor)
        {
        }

        public void DeleteDoctor(int id)
        {
        }
    }
}
