using System;

namespace Encapsulation
{
    class Program
    {
        static void Main()
        {
            bool flag = true;
            do
            {
                Calculator cal = new Calculator();
                if (cal.ValidateData())
                {
                    Console.WriteLine("Enter Choice\n");
                    Console.WriteLine(" 1.Add\n 2.Subtract\n 3.Multiply\n 4.Divide");
                    int choice;
                    int.TryParse(Console.ReadLine(), out choice);
                    cal.ValidateChoice(choice);
                }
                Console.WriteLine("Press 'y' to coninue");
                flag = Console.ReadLine().ToLower().StartsWith('y');
                
            } while (flag);
        }
    }
}
