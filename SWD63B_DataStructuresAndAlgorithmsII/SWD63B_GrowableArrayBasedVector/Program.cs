using SWD63B_AbstractDataTypes.Interfaces.Vectors;
using SWD63B_GrowableArrayBasedVector.Vectors;

namespace SWD63B_GrowableArrayBasedVector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVectorADT<int> vector_int = new GrowableArrayBasedVector<int>(5);
            vector_int.InsertAtRank(0, 10);
            vector_int.InsertAtRank(1, 20);
            vector_int.InsertAtRank(2, 30);
            vector_int.InsertAtRank(3, 40);
            vector_int.InsertAtRank(0, 0);
            vector_int.InsertAtRank(0, -1);
        }
    }
}
