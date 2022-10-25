namespace Assignment
{
    class GenericExercise
    {
        static int x = 2 , y = 3;
        //here implemented Icomparable can be used if needed
    
        static void Swap<T>(ref T a, ref T b) where T : IComparable
        {
            T temp = a;
            a = b;
            b = temp;
            //Console.WriteLine(a.CompareTo(b));
        }
        public static void Main(String[] args)
        { 
            Console.WriteLine($"Before Swapping X: {x} Y:{y}");
            Swap<int>(ref x, ref y);
            Console.WriteLine($"After Swapping X: {x} Y:{y}");
        }
    }
}
