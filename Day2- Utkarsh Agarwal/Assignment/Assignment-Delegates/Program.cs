using StudentLibrary;
using EmployeeLibrary;
using CustomerLibrary;
using DelegateLibrary;
using Printer;

namespace Assignment
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            //creating objects from 3 class libraries 
            Customer customer = new Customer(1, "A");
            Employee employee = new Employee(2, "B");
            Student student = new Student(3, "C");

            //creating a object reference for delegate and assigning methods
            PrintDelegate p = new PrintDelegate(customer.Display);
            p+=employee.Display;
            p+=student.Display;

            //sending the obj to call above 3 methods
            Printer.Printer.Print(p);


        }
    }

}