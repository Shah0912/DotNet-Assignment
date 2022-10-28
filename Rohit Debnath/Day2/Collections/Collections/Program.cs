using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        public static void Main()
        {
            AllCollections collections = new AllCollections();
            collections.ListCollection();
            collections.SortListCollection();
            collections.ArrayListCollection();
            collections.HashTableCollection();
        }
    }

    internal class AllCollections
    {
        public void ListCollection()
        {
            List<Employee> Employees = new List<Employee> { 
                            new Employee(1, "Emp1"),
                            new Employee(2, "Emp2"),
                            new Employee(3, "Emp3"),
                            new Employee(4, "Emp4"),
                            new Employee(5, "Emp5"),};

            PrintCollection(Employees, "Generic List");
        }

        public void ArrayListCollection()
        {
            ArrayList Employees = new ArrayList {
                            new Employee(1, "Emp1"),
                            new Employee(2, "Emp2"),
                            new Employee(3, "Emp3"),
                            new Employee(4, "Emp4"),
                            new Employee(5, "Emp5"),};

            PrintCollection(Employees, "ArrayList");

        }

        public void SortListCollection()
        {
            SortedList<int, Employee> Employees = new SortedList<int, Employee>();
            Employees.Add(5, new Employee(5, "Emp5"));
            Employees.Add(4, new Employee(4, "Emp4"));
            Employees.Add(3, new Employee(3, "Emp3"));
            Employees.Add(2, new Employee(2, "Emp2"));
            Employees.Add(1, new Employee(1, "Emp1"));

            PrintCollection(Employees, "SortedList");
        }

        public void HashTableCollection()
        {
            HashSet<Employee> Employees = new HashSet<Employee>();
            Employees.Add(new Employee(5, "Emp5"));
            Employees.Add(new Employee(4, "Emp4"));
            Employees.Add(new Employee(3, "Emp3"));
            Employees.Add(new Employee(2, "Emp2"));
            Employees.Add(new Employee(1, "Emp1"));

            PrintCollection(Employees, "HastTable");
        }



        public void PrintCollection(IEnumerable list, string Messege)
        {
            Console.WriteLine(Messege);
            foreach(Object item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
