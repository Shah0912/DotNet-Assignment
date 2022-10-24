// See https://aka.ms/new-console-template for more information
using System;

namespace Basics
{
    class operations
    {
        static void Main(string[] args)
        {
            char perform = 'y';

            while (perform == 'y')
            {
                Console.Write("Enter First Number:  ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter Second Number: ");
                int y = int.Parse(Console.ReadLine());

                Console.WriteLine("What operation you want to perform ");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.comparision");
                Console.WriteLine("3.Swapping");
                Console.WriteLine("4.Print Table");

                Console.Write("Enter your option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                        break;

                    case 2:
                        if (x > y)
                        {
                            Console.WriteLine($"{x} is greater than {y}");


                        }

                        else if (x < y)
                        {

                            Console.WriteLine($"{x} is lesser than {y}");


                        }

                        else
                        {
                            Console.WriteLine("Both Numbers are same ");
                        }
                        break;


                    case 3:
                        Console.WriteLine("Before swap inside swap method ");
                        Console.WriteLine($"X:{x}   Y:{y}");
                        Console.WriteLine("After swapping inside method");
                        x = x + y;
                        y = x - y;
                        x = x - y;
                        Console.WriteLine($"X:{x}  Y:{y}");

                        break;

                    case 4:
                        for (int i = x; i <= y; i++)
                        {
                            for (int j = 1; j < 11; j++)
                            {
                                Console.WriteLine($"{i} * {j} = {i * j}");
                            }

                            Console.WriteLine("---------------------------");
                        }
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Any more operation you want to perform (y|n): ");
                perform = char.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}