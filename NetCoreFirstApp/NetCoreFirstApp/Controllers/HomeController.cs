using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreFirstApp.Models;

namespace NetCoreFirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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

        [HttpGet]
        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEmployee(Employee employee)
        {
            employeeRepository.CreateEmployee(employee);
            return View("Details",employee.RecordId);
        }

        [HttpGet]
        public IActionResult Details(long employeeRecordId)
        {
            Employee employee = employeeRepository.GetEmployeeByRecordId(employeeRecordId);
            return View(employee);
        }
    }
}
