using System.Collections;

namespace Collection
{
    public class Employee
    {
        public readonly int Id=0;
        public readonly string Name;
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            Console.WriteLine("Emplopyee Name: " + Name + " , \nEmployee ID: " + Id);
            return null;
        }
        static void Main()
        {
            ArrayList EmpList1 = new ArrayList();
            EmpList1.Add(new Employee(1, "Abc"));
            EmpList1.Add(new Employee(2, "Bcd"));
            EmpList1.Add(new Employee(3, "Cde"));
            EmpList1.Add(new Employee(4, "Def"));

            SortedList EmpList2 = new SortedList();
            EmpList2.Add(1,new Employee(1, "Abc"));
            EmpList2.Add(3,new Employee(2, "Bcd"));
            EmpList2.Add(4,new Employee(3, "Cde"));
            EmpList2.Add(2,new Employee(4, "Def"));

            List<Employee> EmpList3 = new List<Employee>();
            EmpList3.Add(new Employee(1, "Abc"));
            EmpList3.Add(new Employee(2, "Bcd"));
            EmpList3.Add(new Employee(3, "Cde"));
            EmpList3.Add(new Employee(4, "Def"));

            Dictionary<int,Employee> EmpList4 = new Dictionary<int,Employee>();
            EmpList4.Add(1,new Employee(1, "Abc"));
            EmpList4.Add(2,new Employee(1, "Bcd"));
            EmpList4.Add(3,new Employee(1, "Cde"));
            EmpList4.Add(4,new Employee(1, "Def"));

            IEnumerable l1 = EmpList1;
            //IEnumerable l2 = EmpList2;
            IEnumerable l3 = EmpList3;
            //IEnumerable l4 = EmpList4;
            foreach (Employee emp in l1)
            {
                Console.WriteLine(emp.Id + " , " + emp.Name);
            }
            /*foreach (Employee emp in l2)
            {
                Console.WriteLine(emp.Id + " , " + emp.Name);
            }*/
            foreach (Employee emp in l3)
            {
                Console.WriteLine(emp.Id + " , " + emp.Name);
            }
           /* foreach (Employee emp in l4)
            {
                Console.WriteLine(emp.Id + " , " + emp.Name);
            }*/
        }
    }
}