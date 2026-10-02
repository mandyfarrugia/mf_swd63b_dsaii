namespace SWD63B_NonGrowableArrayBasedVector.Vectors
{
    /// <summary>
    /// A data structure representing a non-growable array based vector with a fixed size.
    /// </summary>
    public class NonGrowableVector<T>
    {
        private readonly T[] vectorElements;

        public NonGrowableVector(int maximumCapacity)
        {
            this.vectorElements = new T[maximumCapacity];
        }
    }
}
