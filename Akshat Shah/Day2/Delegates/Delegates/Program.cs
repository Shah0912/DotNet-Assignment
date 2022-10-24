using EmployeeLibrary;
using CustomerLibrary;
using StudentLibrary;
using PrinterLibrary;
using static DelegateLibrary.PrintDelegateClass;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Argus Fitch", "Caretaker");
            Customer customer = new Customer("Mundungus Fletcher");
            Student student = new Student("Neville Longbottom", "Herbology");

            PrintDelegate printDelegate = employee.Display;
            Printer.Print(printDelegate);

            printDelegate = customer.Display;
            Printer.Print(printDelegate);

            printDelegate = student.Display;
            Printer.Print(printDelegate);
        }
    }
}