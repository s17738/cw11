using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using s17738_cw11.Models;

namespace s17738_cw11.DAL
{
    public interface DbService
    {
        Task<IEnumerable<Doctor>> GetDoctorsAsync();

        Task<Doctor> GetDoctorAsync(int id);

        Task<Doctor> CreateDoctorAsync(Doctor doctor);

        Task<bool> UpdateDoctorAsync(int id, Doctor doctor);

        Task<bool> DeleteDoctorAsync(int id);
    }
}
