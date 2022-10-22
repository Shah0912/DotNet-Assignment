using CustomerLibrary;
using EmployeeLibrary;
using StudentLibrary;

namespace Delegates
{
    public class MainClass
    {
        
        static void Main()
        {
            Student s = new Student(1, "Abc");
            Employee e = new Employee(1, "Bcd");
            Customer c = new Customer(1, "Def");
            DelegateLibrary.PrintDelegate p = e.Display();
        }
    }

}