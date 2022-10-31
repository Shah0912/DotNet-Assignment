using EmployeeMVC.DataAccessLayer;

namespace EmployeeMVC.Models
{
    public class EmployeeBusinessLayer : IEmployeeBusinessLayer
    {
        CompanyDbContext _context;
        public EmployeeBusinessLayer(CompanyDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetEmployees() => _context.Employees.ToList();

        public Employee SaveEmployee(Employee employee)
        {
            employee = _context.Employees.Add(employee).Entity;
            _context.SaveChanges();
            return employee;
        }

        public Employee? GetEmployee(int id) => _context.Employees.Find(id);
    }
}
