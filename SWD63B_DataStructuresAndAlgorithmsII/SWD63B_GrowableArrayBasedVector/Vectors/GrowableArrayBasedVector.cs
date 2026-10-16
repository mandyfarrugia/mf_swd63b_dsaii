using SWD63B_NonGrowableArrayBasedVector.Vectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD63B_GrowableArrayBasedVector.Vectors
{
    public class GrowableArrayBasedVector<T> : NonGrowableArrayBasedVector<T>
    {
        public GrowableArrayBasedVector(int initialCapacity) : base(initialCapacity)
        {
        }

        public override void InsertAtRank(int index, T newElement)
        {
            if (this.Size() == this._vectorElements.Length)
            {
                this.Grow();
            }

            base.InsertAtRank(index, newElement);
        }

        private void Grow()
        {
            //Create an array which is larger than the current vectorElements array.
            T[] grownVectorArray = new T[this._vectorElements.Length + 1];
            //Copy all elements in the vector array into the larger array.
            Array.Copy(this._vectorElements, grownVectorArray, this.Size());
            this._vectorElements = grownVectorArray;
        }
    }
}
