using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class MainClass
    {

        static void Main(string[] args)
        {
            bool chk1 = false;
            bool chk2 = false;
            int choice;
            float x, y;


            bool ValidateData(float a, float b)
            {
                if (a < 0 || b < 0)
                {
                    Console.WriteLine("Enter positive numbers only");
                    return false;

                }
                else
                {
                    return true;
                }
            }

            bool ValidateChoice(int ch)
            {
                if (ch > 0 && ch <= 4)
                {
                    return true;
                }

                return false;
            }

            void display(calculator obj2)
            {
                Console.WriteLine("Result is {0}", obj2.Res);
                obj2.Res = 0;
            }

            do {
                Console.WriteLine("Enter two positive numbers");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                chk1 = ValidateData(x, y);
            } while (chk1 == false);

            do
            {
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");

                choice = int.Parse(Console.ReadLine());
                chk2 = ValidateChoice(choice);

            } while (chk2 == false);

            calculator obj1 = new calculator(x, y);
            switch(choice)
            {
                case 1:
                    obj1.add();
                    display(obj1);
                    break;

                case 2:
                    obj1.sub();
                    display(obj1);
                    break;

                case 3:

                    obj1.mul();
                    display(obj1);

                    break;

                case 4:
                    obj1.div();
                    display(obj1);
                    break;

            }

    }
    }
}