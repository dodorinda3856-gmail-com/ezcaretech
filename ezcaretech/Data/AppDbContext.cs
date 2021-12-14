using ezcaretech.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ezcaretech.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<CommonCode> CommonCode { get; set; }
        public DbSet<ErrorViewModel> ErrorViewModel { get; set; }

        public DbSet<MediProcedure> MediProcedure { get; set; }
        public DbSet<MediStaff> MediStaff { get; set; }
        public DbSet<MediStaffLogin> MediStaffLogin { get; set; }
        public DbSet<ModelContext> ModelContext { get; set; }
        public DbSet<NameOfDisease> NameOfDisease { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PushAlarm> PushAlarm { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Treatment> Treatment { get; set; }
        public DbSet<Waiting> Waiting { get; set; }
    }
}
