using System.Collections;
namespace Assignment
{
    public class Employee
    {
        public readonly Guid EmpID;
        public readonly string EmpName;

        public Employee(string name)
        {
            EmpID = Guid.NewGuid();
            EmpName = name;
        }

        public override string? ToString()
        {
            Console.WriteLine("Employee Id: " + EmpID+ "\nEmployee name: " + EmpName);
            return "";
        }
    }
    public class MainClass
    {
        public static void Main(String[] args)
        {
            //ArrayList create and print
            Console.WriteLine("**************************");
            Console.WriteLine("Using Array List\n");
            ArrayList EmpArrayList = new ArrayList();
            EmpArrayList.Add(new Employee("A"));
            EmpArrayList.Add(new Employee( "B"));
            EmpArrayList.Add(new Employee( "C"));
            EmpArrayList.Add(new Employee( "D"));
            EmpArrayList.Add(new Employee("E"));
            foreach(Employee emp in EmpArrayList)
            {
                Console.WriteLine(emp);
            }

            //SortedList create and print
            Console.WriteLine("**************************");
            Console.WriteLine("Using Sorted List\n");
            SortedList EmpSortedList = new SortedList();
            Employee emp1 = new Employee("A");
            EmpSortedList.Add(emp1.EmpID,emp1);
            Employee emp2 = new Employee("B");
            EmpSortedList.Add(emp2.EmpID, emp2);
            Employee emp3 = new Employee("C");
            EmpSortedList.Add(emp3.EmpID, emp3);
            Employee emp4 = new Employee("D");
            EmpSortedList.Add(emp4.EmpID, emp4);
            Employee emp5 = new Employee("E");
            EmpSortedList.Add(emp5.EmpID, emp5);
            foreach (var emp in EmpSortedList.Values)
            {
                Console.WriteLine(emp);
            }

            //Generic List create and print
            Console.WriteLine("**************************");
            Console.WriteLine("Using Generic List\n");
            List<Employee> EmpGenericList = new List<Employee>();
            EmpGenericList.Add(new Employee("A"));
            EmpGenericList.Add(new Employee("B"));
            EmpGenericList.Add(new Employee("C"));
            EmpGenericList.Add(new Employee("D"));
            EmpGenericList.Add(new Employee("E"));
            foreach (Employee emp in EmpGenericList)
            {
                Console.WriteLine(emp);
            }

            //Generic Hash table create and print
            Console.WriteLine("**************************");
            Console.WriteLine("Using Generic Hash Table\n");
            Dictionary<Guid, Employee> EmpHashTable = new Dictionary<Guid, Employee>();
            Employee Emp1 = new Employee("A");
            EmpHashTable.Add(Emp1.EmpID, Emp1);
            Employee Emp2 = new Employee("B");
            EmpHashTable.Add(Emp2.EmpID, Emp2);
            Employee Emp3 = new Employee("C");
            EmpHashTable.Add(Emp3.EmpID, Emp3);
            Employee Emp4 = new Employee("D");
            EmpHashTable.Add(Emp4.EmpID, Emp4);
            Employee Emp5 = new Employee("E");
            EmpHashTable.Add(Emp5.EmpID, Emp5);
            foreach (var emp in EmpHashTable.Values)
            {
                Console.WriteLine(emp);
            }









        }
    }
}