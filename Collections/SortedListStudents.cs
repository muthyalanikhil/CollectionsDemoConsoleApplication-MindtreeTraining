using System;
using System.Collections;

namespace Collections
{
    class SortedListStudents
    {
        /// <summary>
        /// Sorts the students by their Ids.
        /// </summary>
        public void Students()
        {
            Console.WriteLine("\nSorted List of students according to Ids.\n");
            SortedList studentIds = new SortedList();

            studentIds.Add("104", "nikhil");
            studentIds.Add("108", "chandra");
            studentIds.Add("101", "pradeep");
            studentIds.Add("103", "teju");

            for (int index = 0; index < studentIds.Count; index++)
            {
                Console.WriteLine("{0}\t{1}", studentIds.GetKey(index), studentIds.GetByIndex(index));
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
