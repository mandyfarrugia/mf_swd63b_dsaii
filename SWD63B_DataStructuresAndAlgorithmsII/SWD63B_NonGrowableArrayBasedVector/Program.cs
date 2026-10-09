using SWD63B_NonGrowableArrayBasedVector.Vectors;

namespace SWD63B_NonGrowableArrayBasedVector
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NonGrowableArrayBasedVector<int> vector_int = new NonGrowableArrayBasedVector<int>(4);
            vector_int.InsertAtRank(0, 10);
            vector_int.InsertAtRank(1, 20);
            vector_int.InsertAtRank(2, 30);
            vector_int.InsertAtRank(3, 40);
            vector_int.InsertAtRank(0, -1);

            Console.ReadKey();
        }
    }
}
