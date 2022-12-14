namespace EmployeeMVC.Models
{
    public interface IEmployeeBusinessLayer
    {
        List<Employee> GetEmployees();
        Employee SaveEmployee(Employee employee);
        Employee? GetEmployee(int id);
    }
}