namespace EmployeeLibrary
{
    public class Employee
    {
        int Id;
        string Name;

        public Employee(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public void Display()
        {
            Console.WriteLine($"Employee Id: {Id}  Employee Name: {Name}");
        }

    }
}