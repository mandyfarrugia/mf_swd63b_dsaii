using SWD63B_NonGrowableArrayBasedVector.Vectors;

namespace SWD63B_NonGrowableArrayBasedVector
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NonGrowableVector<int> vector_int = new NonGrowableVector<int>(25);
            NonGrowableVector<string> vector_string = new NonGrowableVector<string>(2);
            Console.ReadKey();
        }
    }
}
