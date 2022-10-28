using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Calculator
    {
        enum Choice : byte
        {
            Addition = 1,
            Subtraction,
            Multiplication,
            Division
        }

        private int num1, num2, result;

        private void GetData()
        {
            Console.WriteLine("Enter first number");
            int.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("Enter second number");
            int.TryParse(Console.ReadLine(), out num2);
        }

        public void Print(int choice)
        {
            Console.Write($"{num1} ");
            switch ((Choice)choice)
            {
                case Choice.Addition:
                    Console.Write("+");
                    break;
                case Choice.Subtraction:
                    Console.Write("-");
                    break;
                case Choice.Multiplication:
                    Console.Write("*");
                    break;
                case Choice.Division:
                    Console.Write("/");
                    break;
            }
            Console.Write($"{num2} = {result}\n");
        }
        private void Add(int num1, int num2)
        {
            result = num1 + num2;
        }
        private void Subtract(int num1, int num2)
        {
            result = num1 - num2;
        }
        private void Multiply(int num1, int num2)
        {
            result = num1 * num2;
        }
        private void Divide(int num1, int num2)
        {
            result = 0;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }
        private void Calculate(int ch)
        {
            switch ((Choice)ch)
            {
                case Choice.Addition:
                    Add(num1, num2);
                    break;
                case Choice.Subtraction:
                    Subtract(num1, num2);
                    break;
                case Choice.Multiplication:
                    Multiply(num1, num2);
                    break;
                case Choice.Division:
                    Divide(num1, num2);
                    break;
            }
        }

        public bool ValidateData()
        {
            GetData();
            if (num1 > 0 && num2 > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Enter positive numbers!\n");
                return false;
            }
        }

        public bool ValidateChoice(int choice)
        {
            
            if (choice > 0 && choice < 5)
            {
                Calculate(choice);
                Print(choice);
                return true;
            }
            else
            {
                Console.WriteLine("Enter Valid Choice(1-4)\n");
                return false;
            }
        }
    }
}