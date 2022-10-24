using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Calculator
    {
        public enum Operations
        {
            ADDITION = 1,
            SUBTRACTION = 2,
            MULTIPLICATION = 3,
            DIVISION = 4
        };
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        private int operation;
        public string Operation
        {
            get
            {
                return (Operations) operation switch
                {
                    Operations.ADDITION => "Addition",
                    Operations.SUBTRACTION => "Subtraction",
                    Operations.MULTIPLICATION => "Multiplication",
                    Operations.DIVISION => "Division",
                    _ => "Unsupported operation"
                };
            }
        }
        public int Result { get; set; }

        public void GetData()
        {
            // TODO: Get choice of operation

            Console.WriteLine("Enter number to select operation: ");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            var input = Console.ReadLine();
            int choice;
            while(!int.TryParse(input, out choice) || !(choice <= 4 && choice >= 1))
            {
                Console.WriteLine("Invalid input. Enter a number from 1-4");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                input = Console.ReadLine();
            }
            operation = choice;
            Console.WriteLine();
            

            Console.WriteLine("Enter first operand: ");
            input = Console.ReadLine();
            int number;
            while (!int.TryParse(input, out number))
            {
                Console.WriteLine("Invalid input, try again");
                Console.WriteLine("Enter first operand: ");
                input = Console.ReadLine();
            }
            Operand1 = number;
            Console.WriteLine();

            Console.WriteLine("Enter second operand: ");
            input = Console.ReadLine();
            while(!int.TryParse(input, out number))
            {
                Console.WriteLine("Invalid input, try again"); ;
                Console.WriteLine("Enter second operand: ");
                input = Console.ReadLine();
            }
            Operand2 = number;
            Console.WriteLine();
        }

        public bool ValidateData()
        {
            // TODO: What to validate?
            // Are integers? Doing that in GetData
            // divisor == 0?
            throw new NotImplementedException();
        }

        public bool ValidateChoice()
        {
            // TODO Doing this in GetData
            throw new NotImplementedException();
        }

        public void PrintData()
        {
            Console.WriteLine($"Operand 1: {Operand1}");
            Console.WriteLine($"Operand 2: {Operand2}");
            Console.WriteLine($"Operation: {Operation}");
            Console.WriteLine($"Result: {Result}");
            Console.WriteLine();
        }

        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException();
            }
            return a / b;
        }

        public int Calculate()
        {
            try
            {
                Result = (Operations) operation switch
                {
                    Operations.ADDITION => Add(Operand1, Operand2),
                    Operations.SUBTRACTION => Subtract(Operand1, Operand2),
                    Operations.MULTIPLICATION => Multiply(Operand1, Operand2),
                    Operations.DIVISION => Divide(Operand1, Operand2),
                    _ => throw new NotImplementedException()
                };
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid operands for given operation");
                throw;
            }
            return Result;
        }

        
    }
}
