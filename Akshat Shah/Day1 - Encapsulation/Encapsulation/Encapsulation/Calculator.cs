using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Calculator
    {
        /// <summary>
        /// Enumeration to encapsulate the different operations supported by this class.
        /// </summary>
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

        /// <summary>
        /// Method for getting user input. Sets the <c>operation</c>, <c>Operand1</c> and <c>Operand2</c> fields.
        /// </summary>
        public void GetData()
        {
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

        /// <summary>
        /// Prints the operands, type of operation and the result of the operation
        /// </summary>
        public void PrintData()
        {
            Console.WriteLine($"Operand 1: {Operand1}");
            Console.WriteLine($"Operand 2: {Operand2}");
            Console.WriteLine($"Operation: {Operation}");
            Console.WriteLine($"Result: {Result}");
            Console.WriteLine();
        }

        /// <summary>
        /// Adds two integers.
        /// </summary>
        /// <param name="a">First operand, the augend</param>
        /// <param name="b">Second operand, the addend</param>
        /// <returns>Sum of the two operands, <c>a + b</c></returns>
        public int Add(int a, int b) => a + b;

        /// <summary>
        /// Subtracts second integer from the second.
        /// </summary>
        /// <param name="a">First operand, the minuend</param>
        /// <param name="b">Second operand, the subtrahend</param>
        /// <returns>Difference between the two operands, <c>a - b</c></returns>
        public int Subtract(int a, int b) => a - b;

        /// <summary>
        /// Multiplies two integers.
        /// </summary>
        /// <param name="a">First operand, the multiplicand</param>
        /// <param name="b">Second operand, the multiplier</param>
        /// <returns>Product of the two operands, <c>a * b</c></returns>
        public int Multiply(int a, int b) => a * b;

        /// <summary>
        /// Divides the two integers.
        /// </summary>
        /// <param name="a">First operand, the dividend</param>
        /// <param name="b">Second operand, the divisor</param>
        /// <returns>Quotient of the division</returns>
        /// <exception cref="ArgumentException">If the divisor is zero</exception>
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException();
            }
            return a / b;
        }

        /// <summary>
        /// Carries out the operation.
        /// </summary>
        /// <returns>Results of the operation.</returns>
        /// <exception cref="NotImplementedException">If the operation field is set to an invalid integer (not from 1-4)</exception>
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
