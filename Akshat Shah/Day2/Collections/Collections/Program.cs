using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            useNonGenericCollections();
            useGenericCollections();
        }

        private static void useNonGenericCollections()
        {
            IEnumerable employeeEnumerable = useArrayList();
            useQueue();
            useStack();
            useHashtable();
            useSortedList();

            Console.WriteLine("Printing from Enumerable");
            printEnumerable(employeeEnumerable);
            Console.WriteLine();
        }

        private static void useGenericCollections()
        {
            IEnumerable<Employee> employeeEnumerable = useList();
            useGenericQueue();
            useGenericStack();
            useDictionary();
            useGenericSortedList();

            Console.WriteLine("Printing from generic IEnumerable");
            printEnumerable(employeeEnumerable);
            Console.WriteLine();
        }

        private static void printEnumerable(IEnumerable enumerable)
        {
            foreach (var e in enumerable)
            {
                Console.WriteLine(e);
            }
        }

        private static void printEnumerable<T>(IEnumerable<T> enumerable)
        {
            foreach (T elem in enumerable)
            {
                Console.WriteLine(elem);
            }
        }

        private static IEnumerable useArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Employee("Dean Thomas"));
            arrayList.Add(new Employee("Seamus Finnigan"));
            arrayList.Add(new Employee("Parvati Patel"));
            arrayList.Add(new Employee("Lavender Brown"));
            arrayList.Add(new Employee("Colin Creevey"));

            Console.WriteLine("Printing from ArrayList");
            foreach (Employee e in arrayList)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            return arrayList;
        }

        private static void useQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(new Employee("Dean Thomas"));
            queue.Enqueue(new Employee("Seamus Finnigan"));
            queue.Enqueue(new Employee("Parvati Patel"));
            queue.Enqueue(new Employee("Lavender Brown"));
            queue.Enqueue(new Employee("Colin Creevey"));

            Console.WriteLine("Printing from Queue");
            while(queue.Count > 0)
            {
                Employee e = (Employee) queue.Dequeue()!;
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        private static void useStack()
        {
            Stack stack = new Stack();
            stack.Push(new Employee("Dean Thomas"));
            stack.Push(new Employee("Seamus Finnigan"));
            stack.Push(new Employee("Parvati Patel"));
            stack.Push(new Employee("Lavender Brown"));
            stack.Push(new Employee("Colin Creevey"));

            Console.WriteLine("Printing from Stack");
            while(stack.Count > 0)
            {
                Employee e = (Employee) stack.Pop()!;
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        private static void useHashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Dean Thomas", new Employee("Dean Thomas"));
            hashtable.Add("Seamus Finnigan", new Employee("Seamus Finnigan"));
            hashtable.Add("Parvati Patel", new Employee("Parvati Patel"));
            hashtable.Add("Lavender Brown", new Employee("Lavender Brown"));
            hashtable.Add("Colin Creevey", new Employee("Colin Creevey"));

            Console.WriteLine("Printing from Hashtable");
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine($"Key:{de.Key} Value:{de.Value}");
            }
            Console.WriteLine();
        }

        private static void useSortedList()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("Dean Thomas", new Employee("Dean Thomas"));
            sortedList.Add("Seamus Finnigan", new Employee("Seamus Finnigan"));
            sortedList.Add("Parvati Patel", new Employee("Parvati Patel"));
            sortedList.Add("Lavender Brown", new Employee("Lavender Brown"));
            sortedList.Add("Colin Creevey", new Employee("Colin Creevey"));

            Console.WriteLine("Printing from SortedList");
            foreach (DictionaryEntry de in sortedList)
            {
                Console.WriteLine($"Key: {de.Key} Value: {de.Value}");
            }
            Console.WriteLine();
        }

        private static IEnumerable<Employee> useList()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee("Dean Thomas"));
            list.Add(new Employee("Seamus Finnigan"));
            list.Add(new Employee("Parvati Patel"));
            list.Add(new Employee("Lavender Brown"));
            list.Add(new Employee("Colin Creevey"));

            Console.WriteLine("Printing from List");
            foreach (Employee e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            return list;
        }

        private static void useGenericQueue()
        {
            Queue<Employee> queue = new Queue<Employee>();
            queue.Enqueue(new Employee("Dean Thomas"));
            queue.Enqueue(new Employee("Seamus Finnigan"));
            queue.Enqueue(new Employee("Parvati Patel"));
            queue.Enqueue(new Employee("Lavender Brown"));
            queue.Enqueue(new Employee("Colin Creevey"));

            Console.WriteLine("Printing from generic Queue");
            while(queue.Count > 0)
            {
                Employee e = (Employee) queue.Dequeue()!;
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        private static void useGenericStack()
        {
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(new Employee("Dean Thomas"));
            stack.Push(new Employee("Seamus Finnigan"));
            stack.Push(new Employee("Parvati Patel"));
            stack.Push(new Employee("Lavender Brown"));
            stack.Push(new Employee("Colin Creevey"));

            Console.WriteLine("Printing from generic Stack");
            while(stack.Count > 0)
            {
                Employee e = (Employee) stack.Pop()!;
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        private static void useDictionary()
        {
            Dictionary<string, Employee> dictionary = new Dictionary<string, Employee>();
            dictionary.Add("Dean Thomas", new Employee("Dean Thomas"));
            dictionary.Add("Seamus Finnigan", new Employee("Seamus Finnigan"));
            dictionary.Add("Parvati Patel", new Employee("Parvati Patel"));
            dictionary.Add("Lavender Brown", new Employee("Lavender Brown"));
            dictionary.Add("Colin Creevey", new Employee("Colin Creevey"));

            Console.WriteLine("Printing from Dictionary");
            foreach (KeyValuePair<string, Employee> keyValuePair in dictionary)
            {
                Console.WriteLine($"Key:{keyValuePair.Key} Value:{keyValuePair.Value}");
            }
            Console.WriteLine();
        }

        private static void useGenericSortedList()
        {
            SortedList<string, Employee> sortedList = new SortedList<string, Employee>();
            sortedList.Add("Dean Thomas", new Employee("Dean Thomas"));
            sortedList.Add("Seamus Finnigan", new Employee("Seamus Finnigan"));
            sortedList.Add("Parvati Patel", new Employee("Parvati Patel"));
            sortedList.Add("Lavender Brown", new Employee("Lavender Brown"));
            sortedList.Add("Colin Creevey", new Employee("Colin Creevey"));

            Console.WriteLine("Printing from generic SortedList");
            foreach (KeyValuePair<string, Employee> keyValuePair in sortedList)
            {
                Console.WriteLine($"Key: {keyValuePair.Key} Value: {keyValuePair.Value}");
            }
            Console.WriteLine();
        }

    }
}