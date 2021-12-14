using ezcaretech.Data;
using ezcaretech.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ezcaretech.Services
{
    public class PatientService:IPatientService
    {
        private readonly ModelContext _context;
        public PatientService(ModelContext context)
        {
            _context = context;
        }

       
        public async Task<IEnumerable<Patient>> GetAllAsync()
        {
            var result = await _context.Patients.ToListAsync();
            return result;
        }
    }
}
