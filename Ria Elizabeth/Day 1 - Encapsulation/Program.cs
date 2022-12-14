using System;

namespace Encapsulation
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.ValidateData();
            c.ValidateChoice();
            c.PrintData();
        }
    }
}
