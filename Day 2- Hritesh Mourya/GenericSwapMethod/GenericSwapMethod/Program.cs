using System;

namespace GenericMethod
{
    class Program

    {
        static void Swap<T>(ref T left, ref T right)
        {
            T temp;
            temp = left;
            left = right;
            right = temp;

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