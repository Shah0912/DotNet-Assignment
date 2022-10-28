using EmployeeLibrary;
using CustomerLibrary;
using StudentLibrary;
using DelegateLibrary;
using PrinterLibrary;


namespace Program
{
    class Program
    {
        public static void Main()
        {

            PrintDelegate del = new PrintDelegate(Employee.Display);
            del += Customer.Display;
            del += Student.Display;

            Printer.Print(del);
            
        }
    }
}
