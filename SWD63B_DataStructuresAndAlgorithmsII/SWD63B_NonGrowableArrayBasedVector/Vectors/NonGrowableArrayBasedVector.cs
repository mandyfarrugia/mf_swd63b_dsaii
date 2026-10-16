using SWD63B_AbstractDataTypes.Interfaces;

namespace SWD63B_NonGrowableArrayBasedVector.Vectors
{
    /// <summary>
    /// A data structure representing a non-growable array based vector with a fixed size.
    /// </summary>
    public class NonGrowableArrayBasedVector<T> : IVectorADT<T>
    {
        protected T[] _vectorElements;
        protected int _countOfElements = 0;

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

        public virtual void InsertAtRank(int index, T newElement)
        {
            if (this.Size() == this._vectorElements.Length)
            {
                throw new InvalidOperationException("Cannot insert element into vector as it is full!");
            }

            if (index < 0 || index > this.Size())
            {
                throw new IndexOutOfRangeException("Invalid rank!");
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

        public virtual T RemoveElementAtRank(int index)
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
