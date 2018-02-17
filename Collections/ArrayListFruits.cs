using System;
using System.Collections;

namespace Collections
{
    class ArrayListFruits
    {
        /// <summary>
        /// Array List of fruits.
        /// </summary>
        public void Fruits()
        {
            Console.WriteLine("\n\nArrayList of fruits :\\n");
            ArrayList fruits = new ArrayList();
            
            fruits.Add("apple");
            fruits.Add("Mango");
            fruits.Add("Banana");
            fruits.Add("grapes");
            
            foreach (string fruit in fruits)
            {
                Console.WriteLine("fruit name: {0}",fruit);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
