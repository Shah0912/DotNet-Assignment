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

        }

        public static void Display2()
        {

            ArrayList arr1 = new ArrayList();

            arr1.Add(new Employee(1, "Virat"));

            arr1.Add(new Employee(2, "Surya"));
            arr1.Add(new Employee(3, "Karthik"));
            arr1.Add(new Employee(4, "Patel"));
            arr1.Add(new Employee(5, "Ashwin"));

            Console.WriteLine("Employee");

            foreach (Employee e in arr1)
            {
                Console.WriteLine(e.id + ": " + e.Name);
                Console.WriteLine();
            }

        }
    }
}