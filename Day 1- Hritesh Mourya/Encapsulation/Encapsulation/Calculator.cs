using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Calculator
    {
        enum Choice: byte
        {
            Addition=1,
            Subtraction,
            Multiplication,
            Division
        }

        public int choice;
        private int num1, num2, result;

        private void getData(int x,int y)
        {
            num1 = x;
            num2 = y;
        }

        public void print()
        {
            Console.WriteLine($"Result = {result}\n");
        }
        private void Add(int num1, int num2)
        {
            result = num1 + num2;
        }
        private void Subtract(int num1, int num2)
        {
            result = num2 - num1;
        }
        private void Multiply(int num1, int num2)
        {
            result = num1 * num2;
        }
        private void Divide(int num1, int num2)
        {
            int result;
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
            switch((Choice)ch)
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
                default:
                    Console.WriteLine("Invalid Choice!\n");
                    break;
            }
        }

        public bool ValidateData(int x,int y)
        {
            if(x>0 && y>0)
            {
                getData(x, y);
                return true;
            }
            else
            {
                Console.WriteLine("Enter positive numbers!\n");
                return false;
            }
        }

        public bool ValidateChoice()
        {
            if(choice>0 && choice<5)
            {
                Calculate(choice);
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
