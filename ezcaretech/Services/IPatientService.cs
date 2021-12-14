using ezcaretech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ezcaretech.Services
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetAllAsync();
    }
}
