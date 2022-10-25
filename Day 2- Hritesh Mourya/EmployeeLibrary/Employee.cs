using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace EmplyoeeLibrary
{
    public class Employee
    {
        public int id;
        public String Name;

        public Employee(int i, string n)
        {
            this.id = i;
            this.Name = n;
        }
        public static void Main()
        {
            //do nothing
        }

        public static void Display2()
        {

            ArrayList arr = new ArrayList();

            arr1.Add(new Employee(1, "EmployeeName1"));
            arr1.Add(new Employee(2, "EmployeeName2"));
            arr1.Add(new Employee(3, "EmployeeName3"));
            arr1.Add(new Employee(4, "EmployeeName4"));
            arr1.Add(new Employee(5, "EmployeeName5"));

            Console.WriteLine("\nEmployee List: ");

            foreach (Employee e in arr)
            {
                Console.WriteLine($"\nEmployee ID: {e.id} \nEmployee Name: {e.Name}");
            }

        }
    }
}