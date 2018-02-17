using System;
using System.Collections;

namespace Collections
{
    class HashTableStudents
    {
        /// <summary>
        /// HashTable.
        /// </summary>
        public void Students()
        {
            Console.WriteLine("\nSorted List of students according to Ids.\n");
            Hashtable studentIds = new Hashtable();

            studentIds.Add("104", "nikhil");
            studentIds.Add("108", "chandra");
            studentIds.Add("101", "pradeep");
            studentIds.Add("103", "teju");

            foreach (var key in studentIds)
            {
                Console.WriteLine("{0} {1}",key,studentIds[key]);  
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
