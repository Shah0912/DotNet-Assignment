using System;

namespace CSharpBasics
{
    class Program
    {
        enum operations
        {
            Addition,
            Comparison,
            Swapping,
            Printtable
        };
        static void Main(string[] args)
        {
            Program p = new Program();
            int a, b;
            string choice="y";
            do
            {
                try
                {
                    Console.Write("Enter first integer: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Enter second integer: ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nWhat operation do you want to perform?");
                    Console.Write("\n1. Addition");
                    Console.Write("\n2. Comparison");
                    Console.Write("\n3. Swapping");
                    Console.Write("\n4. Print table");
                    Console.Write("\n\nEnter your option: ");
                    string option = Console.ReadLine();
                    p.PerformOperations(option, a, b);
                    Console.WriteLine("\nDo you wish to continue? (y/n)");
                    choice = Console.ReadLine();
                    Console.WriteLine("\n");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("\n");
                }
            }
            while (choice == "y");
        }

        private void PerformOperations(string option, int a, int b)
        {
            try
            {
                switch (int.Parse(option)-1)
                {
                    case (int)operations.Addition:
                        Addition(a,b);
                        break;
                    case (int)operations.Comparison:
                        Comparison(a,b);
                        break;
                    case (int)operations.Swapping:
                        Swapping(a,b);
                        break;
                    case (int)operations.Printtable:
                        PrintTable(a,b);
                        break;
                    default:
                        Console.WriteLine("Invalid option entered."); break;
                };
        }
            catch
            {
                Console.WriteLine("Sorry! Invalid entry.");
            }
}

        private void PrintTable(int a, int b)
        {
            Console.WriteLine("\n");
            for (int i=Math.Min(a,b);i<=Math.Max(a,b);i++)
            {
                Console.WriteLine($"\nTable for {i}: ");
                for (int j = 1; j <= 10;j++) 
                {
                    Console.WriteLine($"{j} x {i} = {j*i}");
                }
            }
        }

        private void Swapping(int a, int b)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Before swap inside swap method.");
            Console.WriteLine($"X: {a} Y: {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swap inside swap method.");
            Console.WriteLine($"X: {a} Y: {b}");
        }

        private void Comparison(int a, int b)
        {
            Console.WriteLine("\n");
            if(a>b)
            {
                Console.WriteLine($"{a} is greater than {b}.");
            }
            else
            {
                Console.WriteLine($"{b} is greater than {a}.");
            }
        }

        private void Addition(int a, int b)
        {
            Console.WriteLine("\nAddition");
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
    }
}
