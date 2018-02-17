using System;
using System.Collections;

namespace Collections
{
    class StackClass
    {
        /// <summary>
        /// Performs the Stack operation.
        /// </summary>
        public StackClass()
        {
            Console.WriteLine("Stack Demo:\n");
            Stack stack = new Stack();
            Console.WriteLine("Enter number of elements to push into stack:");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int index = 0; index < input; index++)
            {
                int element = Convert.ToInt32(Console.ReadLine());
                stack.Push(element); 
            }
            
            Console.WriteLine("\nValues inserted\n");
            foreach (var value in stack)
            {
                Console.WriteLine(" " + value);
            }

            Console.WriteLine("Enter number of elements to pop out of stack:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int index = 0; index < number; index++)
            {
                stack.Pop();
            }
         
            Console.WriteLine("\nElements popped.\nRemaining elements in stack are:\n");
            foreach (var stackValue in stack)
            {
                Console.WriteLine(" " + stackValue);
            }
            Console.ReadKey();
        }
    }
}
