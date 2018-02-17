using System;
using System.Collections;

namespace Collections
{
    class QueueClass
    {
        /// <summary>
        /// Performs the Queue operations.
        /// </summary>
        Queue queue = new Queue();
        public QueueClass()
        {
            Console.WriteLine("Enter an number of elements in the queue:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} elements to insert into the queue:",length);
            for (int index = 0; index < length; index++)
            {
                string input = Console.ReadLine();
                queue.Enqueue(input);
            }

            Console.WriteLine("The Queue is:");
            foreach (var queueValue in queue)
            {
                Console.WriteLine(queueValue);
            }

            Console.WriteLine("Enters numbers of elements to remove from the Queue.");
            int remove = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < remove; index++)
            {
                queue.Dequeue();
            } 

            Console.WriteLine("\nQueue after removing elements");
            foreach (var queueValue in queue)
            {
                Console.WriteLine(queueValue);
            }
            Console.ReadKey();
        }
    }
}
