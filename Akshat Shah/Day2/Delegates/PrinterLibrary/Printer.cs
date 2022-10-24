using static DelegateLibrary.PrintDelegateClass;

namespace PrinterLibrary
{
    public class Printer
    {
        public static void Print(PrintDelegate printDelegate)
        {
            printDelegate();
        }
    }
}