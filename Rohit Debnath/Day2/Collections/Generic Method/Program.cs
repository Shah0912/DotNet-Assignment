using Generic_Method;
using Collections;

namespace GenericMethod
{
    class Program
    {
        public static void Main()
        {
            int num1 = 10, num2 = 20;
            Swap.swap(ref num1, ref num2);
            Console.WriteLine("Swap intergers");
            Console.WriteLine(num1 + " " + num2);

            Employee emp1 = new Employee(1, "Emp1"), emp2 = new Employee(2, "Emp2");
            Swap.swap(ref emp1, ref emp2);
            Console.WriteLine(emp1 + " " + emp2);
        }
    }
}
