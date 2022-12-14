using EmployeeMVC.Models;
using EmployeeMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMVC.Controllers
{
    // [Route("{controller}")]
    public class EmployeeController : Controller
    {
        private IEmployeeBusinessLayer _businessLayer;

        public EmployeeController(IEmployeeBusinessLayer employeeBusinessLayer)
        {
            _businessLayer = employeeBusinessLayer;
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();

            List<Employee> employees = _businessLayer.GetEmployees();
            foreach (Employee employee in employees)
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel
                {
                    Id = employee.Id,
                    Name = $"{employee.FirstName} {employee.LastName}",
                    Salary = employee.Salary,
                    SalaryColor = employee.Salary switch
                    {
                        > 13000 => "yellow",
                        _ => "green",
                    }
                };
                employeeViewModels.Add(employeeViewModel);
            }
            return View("ListEmployees", new EmployeeRecordsViewModel { EmployeeRecords = employeeViewModels });
        }

        // GET: EmployeeController/Create
        public ActionResult Add()
        {
            return View("AddEmployee");
        }

        public ActionResult Details(int id)
        {
            try
            {
                Employee employee = _businessLayer.GetEmployee(id);
                if (employee == null)
                {
                    return NotFound();
                }
                return View("ViewEmployee", new EmployeeViewModel
                {
                    Id = employee.Id,
                    Name = $"{employee.FirstName} {employee.LastName}",
                    Salary = employee.Salary,
                    SalaryColor = employee.Salary switch
                    {
                        > 13000 => "yellow",
                        _ => "green",
                    }
                });
            }
            catch
            {
                throw;
            }
        }

        // POST: EmployeeController/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Employee e)
        {
            try
            {
                _businessLayer.SaveEmployee(e);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
