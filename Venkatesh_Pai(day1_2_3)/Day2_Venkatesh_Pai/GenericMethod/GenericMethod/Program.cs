using System;

namespace GenericMethod
{
    class Program

    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;

        }

        static void Main(string[] args)
        {
            double a = 1;
            double b = 2;

            Swap<double>(ref a, ref b);
            System.Console.WriteLine(a + " " + b);
        }
    }

}