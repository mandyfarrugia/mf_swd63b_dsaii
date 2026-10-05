using SWD63B_NonGrowableArrayBasedVector.Vectors;

namespace SWD63B_NonGrowableArrayBasedVector
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NonGrowableArrayBasedVector<int> vector_int = new NonGrowableArrayBasedVector<int>(25);
            vector_int.InsertAtRank(0, 3);
            vector_int.InsertAtRank(1, 4);
            vector_int.InsertAtRank(2, 5);

            vector_int.ReplaceElementAtRank(0, 6);

            Console.ReadKey();
        }
    }
}
