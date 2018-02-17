using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueClass queue = new QueueClass();
            
            ArrayListFruits arrayList = new ArrayListFruits();
            arrayList.Fruits();

            SortedListStudents sortedList = new SortedListStudents();
            sortedList.Students();

            StackClass stack = new StackClass();
            Console.ReadKey();

            //HashTableStudents hash = new HashTableStudents();
            //hash.Students();
        }
    }
}
