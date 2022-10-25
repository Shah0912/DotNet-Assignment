namespace EmployeeLibrary
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public Employee(string name, string designation)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Designation = designation;
        }

        public void Display()
        {
            Console.WriteLine($"Employee {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine();
        }
    }
}