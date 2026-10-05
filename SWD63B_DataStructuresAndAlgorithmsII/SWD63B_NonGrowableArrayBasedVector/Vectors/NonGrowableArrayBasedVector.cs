using SWD63B_AbstractDataTypes.Interfaces;

namespace SWD63B_NonGrowableArrayBasedVector.Vectors
{
    /// <summary>
    /// A data structure representing a non-growable array based vector with a fixed size.
    /// </summary>
    public class NonGrowableArrayBasedVector<T> : IVectorADT<T>
    {
        private T[] _vectorElements;
        private int _countOfElements = 0;

        public NonGrowableArrayBasedVector(int maximumCapacity)
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
            if (index < 0 || index > this.Size())
            {
                throw new IndexOutOfRangeException("Invalid rank!");
            }

            if (this.Size() == this._vectorElements.Length)
            {
                T[] newVectorElements = new T[this._vectorElements.Length * 2];
                this._vectorElements.CopyTo(newVectorElements, 0); //Copy all elements of source array to destination array, starting from index zero.
                this._vectorElements = newVectorElements;
            }

            for (int location = this.Size() - 1; location >= index; location--)
            {
                this._vectorElements[location + 1] = this._vectorElements[location];
            }

            this._vectorElements[index] = newElement;
            this._countOfElements++;
        }

        public bool IsEmpty()
        {
            return this._countOfElements == 0;
        }

        public T RemoveElementAtRank(int index)
        {
            if (index < 0 || index > this.Size())
            {
                throw new IndexOutOfRangeException("Invalid rank!");
            }

            T oldElement = this._vectorElements[index];

            for (int location = index; location < this.Size() - 1; location++)
            {
                this._vectorElements[location] = this._vectorElements[location + 1];
            }

            this._vectorElements[this.Size() - 1] = default!;
            this._countOfElements--;
            return oldElement;
        }

        public void ReplaceElementAtRank(int index, T updatedElement)
        {
            if (index < 0 || index > this.Size())
            {
                throw new IndexOutOfRangeException("Invalid rank!");
            }

            this._vectorElements[index] = updatedElement;
        }

        public int Size()
        {
            return this._countOfElements;
        }
    }
}
