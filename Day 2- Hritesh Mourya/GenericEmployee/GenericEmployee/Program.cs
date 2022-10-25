using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
namespace GenericEmployee
{

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            arr1.Add(new Employee("EmployeeName1"));
            arr1.Add(new Employee("EmployeeName2"));
            arr1.Add(new Employee("EmployeeName3"));
            arr1.Add(new Employee("EmployeeName4"));
            arr1.Add(new Employee("EmployeeName5"));


            Console.WriteLine("\nEmployees List :  ");
            foreach(Employee e in arr)
            {
                Console.WriteLine(e.ToString());
            }

            SortedList<int, string> arr2 = new SortedList<int, string>();

            arr2.Add(1, "EmployeeName1");
            arr2.Add(2, "EmployeeName2");
            arr2.Add(3, "EmployeeName3");
            arr2.Add(4, "EmployeeName4");
            arr2.Add(5, "EmployeeName5");

            foreach(var iter in arr2)
                Console.WriteLine("Key: {0}, value:{1}", iter.Key, iter.Value);

            List<Employee> List3 = new List<Employee>();
            arr3.Add(new Employee("EmployeeName1"));
            arr3.Add(new Employee("EmployeeName2"));
            arr3.Add(new Employee("EmployeeName3"));
            arr3.Add(new Employee("EmployeeName4"));
            arr3.Add(new Employee("EmployeeName5"));

            foreach(var iter in List3)
            {
                Console.WriteLine(iter);
            }

            Hashtable List4 = new Hashtable();
            ar4.Add(1, "EmployeeName1");
            ar4.Add(2, "EmployeeName2");
            ar4.Add(3, "EmployeeName3");
            ar4.Add(4, "EmployeeName4");
            ar4.Add(5, "EmployeeName5");

            foreach(DictionaryEntry iter in List4)
                Console.WriteLine($"Key:{0}, value: {1}", iter.Key,iter.Value);

        }
    }

    class Employee
    {
        public readonly string EmpName;
        public static int global_id;
        public readonly int EmpID;

        public Employee(string name)

        {
            this.EmpName = name;
            this.EmpID = Interlocked.Increment(ref global_id);
        }

        public override string ToString()
        {
            
                return this.EmpName + ":" + this.EmpID;            }
        }
    }


