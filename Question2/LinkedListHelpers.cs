using System;
using System.Collections.Generic;

namespace Question2
{
    public static class LinkedListHelpers
    {
        /// <summary>
        /// Deletes nodes of a linked list that have been repeated more than twice.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="linkedList"></param>
        /// <returns></returns>
        public static LinkedList<T> RemoveValuesRepeatedMoreThanTwice<T>(this LinkedList<T> linkedList)
        {
            // Throw NullReferenceException if the linkedlist is null
            if (linkedList == null)
                throw new NullReferenceException("The LinkedList is null.");

            // Throw ArgumentException if the linkedlist has 0 items
            if (linkedList.Count == 0)
                throw new ArgumentException("The LinkedList does not have any items.");

            // Create a new linkedlist that will contain the current number of items for the final list
            // which is a maximun of 2 per unique item.
            LinkedList<T> updatedLinkedList = new LinkedList<T>();

            // Use a dictionary to keep track of the number of items added to the new list.
            Dictionary<T, int> itemCount = new Dictionary<T, int>();

            foreach(var item in linkedList)
            {
                if (itemCount.ContainsKey(item))
                    itemCount[item]++;
                else
                    itemCount.Add(item, 1);

                if (itemCount[item] <= 2)
                    updatedLinkedList.AddLast(item);
            }

            return updatedLinkedList;
        }
    }
}
