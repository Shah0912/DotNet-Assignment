namespace SwapUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"Before swapping: a={a} b={b}");

            Swap(ref a, ref b);

            Console.WriteLine($"After swapping: a={a} b={b}");

            string s1 = "Fred Weasely";
            string s2 = "George Weasely";
            Console.WriteLine($"Before swapping: s1={s1} s2={s2}");

            Swap(ref s1, ref s2);

            Console.WriteLine($"After swapping: s1={s1} s2={s2}");
        }

        public static void Swap<T>(ref T a, ref T b) where T : IComparable<T>
        {
            T c = a;
            a = b;
            b = c;
        }
    }
}