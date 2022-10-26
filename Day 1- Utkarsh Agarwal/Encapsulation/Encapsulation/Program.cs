using System;

namespace Encapsulation
{
    class Program
    {
        static void Main()
        {
            int a, b;
            bool isChoiceValid = false, flag;
            do
            {
                Console.WriteLine("Enter first number\n");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number\n");
                b = int.Parse(Console.ReadLine());

                Calculator cal = new Calculator();
                flag = cal.ValidateData(a, b);

                while (!isChoiceValid && flag)
                {
                    Console.WriteLine("Enter Choice\n");
                    Console.WriteLine(" 1.Add\n 2.Subtract\n 3.Multiply\n 4.Divide\n");
                    cal.choice = int.Parse(Console.ReadLine());
                    isChoiceValid = cal.ValidateChoice();
                }

                if (isChoiceValid)
                {
                    cal.print();
                }
            } while (!flag);
        }
    }
}
