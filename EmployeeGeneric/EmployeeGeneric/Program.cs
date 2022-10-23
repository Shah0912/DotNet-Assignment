// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
namespace EmployeeGeneric
{

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr1 = new ArrayList();

            arr1.Add(new Employee("Virat"));
            arr1.Add(new Employee("Surya"));
            arr1.Add(new Employee("Karthik"));
            arr1.Add(new Employee("Patel"));
            arr1.Add(new Employee("Ashwin"));


            Console.WriteLine("Employee List:  ");
            foreach(Employee e in arr1)
                {
                Console.WriteLine(e.ToString());
            }

            SortedList<int, string> arr2 = new SortedList<int, string>();

            arr2.Add(1, "Virat");
            arr2.Add(2, "Surya");
            arr2.Add(3, "Karthik");
           arr2.Add(4, "Patel");
              arr2.Add(5, "Ashwin");

            foreach(var kvp in arr2)
                Console.WriteLine("Key: {0}, value:{1}",kvp.Key, kvp.Value);

            List<Employee> arr3 = new List<Employee>();
            arr3.Add(new Employee("Virat"));
            arr3.Add(new Employee("Virat"));
            arr3.Add(new Employee("Karthik"));
            arr3.Add(new Employee("Patel"));
            arr3.Add(new Employee("Ashwin"));

            foreach(var v in arr3)
            {
                Console.WriteLine(v);
            }

            Hashtable ar4 = new Hashtable();
            ar4.Add(1, "Virat");
            ar4.Add(2, "Karthik");
            ar4.Add(3, "Virat");
            ar4.Add(4, "Patel");
            ar4.Add(5, "Ashwin");

            foreach(DictionaryEntry kv in ar4)
                Console.WriteLine("Key:{0}, value: {1}",kv.Key,kv.Value);

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


