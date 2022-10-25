using DelegateLibrary;
namespace Printer
{
    public class Printer
    {
        public static void Print(PrintDelegate p)
        {
            p();
        }

    }
}