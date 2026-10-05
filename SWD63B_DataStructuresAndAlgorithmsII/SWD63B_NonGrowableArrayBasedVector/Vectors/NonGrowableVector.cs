using SWD63B_NonGrowableArrayBasedVector.Interfaces;

namespace SWD63B_NonGrowableArrayBasedVector.Vectors
{
    /// <summary>
    /// A data structure representing a non-growable array based vector with a fixed size.
    /// </summary>
    public class NonGrowableVector<T> : IVector<T>
    {
        private readonly T[] _vectorElements;
        private int _countOfElements = 0;

        public NonGrowableVector(int maximumCapacity)
        {
            this._vectorElements = new T[maximumCapacity];
        }

        public T GetElementAtRank(int index)
        {
            //Fetch the element at a specific rank if the latter is not negative and within the bounds of the vector.
            if(index >= 0 && index < this.Size())
            {
                return this._vectorElements[index];
            }

            throw new IndexOutOfRangeException("Invalid rank!");
        }

        public void InsertAtRank(int index, T newElement)
        {
            this._countOfElements++;
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return this._countOfElements == 0;
        }

        public T RemoveElementAtRank(int index)
        {
            this._countOfElements--;
            throw new NotImplementedException();
        }

        public void ReplaceElementAtRank(int index, T updatedElement)
        {
            if (index >= 0 && index < this.Size())
            {
                this._vectorElements[index] = updatedElement;
            }

            throw new IndexOutOfRangeException("Invalid rank!");
        }

        public int Size()
        {
            return this._countOfElements;
        }
    }
}
