using ezcaretech.Data;
using ezcaretech.Models;
using ezcaretech.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ezcaretech.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPatientService _service;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger, IPatientService service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
           var data = await _service.GetAllAsync(); 


            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
