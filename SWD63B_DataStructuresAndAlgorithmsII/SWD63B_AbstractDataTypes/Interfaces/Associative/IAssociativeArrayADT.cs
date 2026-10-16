using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD63B_AbstractDataTypes.Interfaces.Associative
{
    /// <summary>
    /// This is an Abstract Data Type defining the behaviours of Hash Tables.
    /// </summary>
    public interface IAssociativeArrayADT<K, V>
    {
        /// <summary>
        /// Inserts a new key-value pair in the hash table.
        /// </summary>
        /// <param name="key">K represents a unique key associated with a value.</param>
        /// <param name="value">V represents a value associated with the given key.</param>
        void Insert(K key, V value);

        /// <summary>
        /// Updates the value for the element with the given key.
        /// Invalid keys causes an exception to be thrown.
        /// </summary>
        /// <param name="key">K represents a unique key associated with the value to update.</param>
        /// <param name="updatedValue">V represents the updated value that must replace the current one.</param>
        void Update(K key, V updatedValue);

        /// <summary>
        /// Removes the element associated with the given key from the hash table and returns its value.
        /// Invalid keys causes an exception to be thrown.
        /// </summary>
        /// <param name="key">K represents a unique key associated with the element to be removed.</param>
        /// <returns>Returns the value of the removed element.</returns>
        V Remove(K key);

        /// <summary>
        /// Retrieves the element associated with the given key from the hash table and returns its value.
        /// Invalid keys causes an exception to be thrown.
        /// </summary>
        /// <param name="key">K represents a unique key associated with the element to be retrieved.</param>
        /// <returns>Returns the value of the retrieved element.</returns>
        V Get(K key);
    }
}
