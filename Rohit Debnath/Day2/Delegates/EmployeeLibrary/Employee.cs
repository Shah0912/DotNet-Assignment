namespace EmployeeLibrary
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static void Display()
        {
            List<Employee> employees = new List<Employee> { new Employee(1, "Employee1"),
                                                         new Employee(2, "Employee2")};
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"Id: {emp.Id}  Name: {emp.Name}");
            }

        }
    }
}