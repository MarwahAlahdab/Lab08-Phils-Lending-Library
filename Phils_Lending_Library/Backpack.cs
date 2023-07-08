using System;
using System.Collections;
using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;

namespace Phils_Lending_Library
{
    public class Backpack<T> : IBag<T>
    {

        private List<T> items;

        public Backpack()
        {
            items = new List<T>();
        }


     
        /// <summary>
        /// Add an item to the bag. <c>null</c> items are ignored.
        /// </summary>
        public void Pack(T item)
    {
            items.Add(item);
    }

    /// <summary>
    /// Remove the item from the bag at the given index.
    /// </summary>
    /// <returns>The item that was removed.</returns>
       public T Unpack(int index)
        {

            T item = items[index];
            items.Remove(item);
            return item;

        }





        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}

