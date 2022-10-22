namespace EmployeeLibrary
{
    public class Employee
    {
        public int Id;
        public string Name;

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine("Employee id: " + Id + " Employee name: " + Name);
        }
    }
}