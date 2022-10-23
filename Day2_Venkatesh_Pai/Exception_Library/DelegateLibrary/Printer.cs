using System;
using System.Collections;
using System.Collections.Generic;
using StudentLibrary;
using EmplyoeeLibrary;
using CustomerLibrary;

namespace DelegateLibrary
{
    public delegate void PrintDelegate();

    class Printer
    {
        static void Main(string[] args)
        {
            PrintDelegate del = Employee.Display2;
            del += customer.Display1;
            del += student.Display3;

            Printer.Print(del);

        }

        public static void Print(PrintDelegate p)
        {
            p();
        }
    }
}