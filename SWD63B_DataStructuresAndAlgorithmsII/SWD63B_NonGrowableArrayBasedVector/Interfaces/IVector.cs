    namespace SWD63B_NonGrowableArrayBasedVector.Interfaces
{
    /// <summary>
    /// This is an Abstract Data Type (ADT) defining the behaviours of a Vector Data Structure.
    /// </summary>
    public interface IVector<T>
    {
        int Size(); //Denotes how many non-empty elements are present, not to be confused with the total length of the data structure which is better known as the maximum capacity of the data structure.
        bool IsEmpty(); //Denotes whether all locations in the data structure are empty.
        T GetElementAtRank(int index);
        void ReplaceElementAtRank(int index, T updatedElement);
        void InsertAtRank(int index, T newElement);
        T RemoveElementAtRank(int index); //Returns the deleted value.
    }
}
