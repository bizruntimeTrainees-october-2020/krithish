using System;
using System.Collections.Generic;
using System.Collections;

namespace CollectionGeneric
{
    class Gene
    {


        public static void Genericc()
        {

            // Creating a List of integers 
            List<int> mylist = new List<int>();

            // adding items in mylist 
            for (int j = 5; j < 10; j++)
            {
                mylist.Add(j * 3);
            }

            // Displaying items of mylist 
            // by using foreach loop 
            foreach (int items in mylist)
            {
                Console.WriteLine(items);
            }
        }

        class NonGene
        {
            public static void Nongenericc()
            {
                // Creating a Queue 
                Queue myQueue = new Queue();

                // Inserting the elements into the Queue 
                myQueue.Enqueue("C#");
                myQueue.Enqueue("PHP");
                myQueue.Enqueue("Perl");
                myQueue.Enqueue("Java");
                myQueue.Enqueue("C");

                // Displaying the count of elements 
                // contained in the Queue 
                Console.Write("Total number of elements present in the Queue are: ");

                Console.WriteLine(myQueue.Count);

                // Displaying the beginning element of Queue 
                Console.WriteLine("Beginning Item is: " + myQueue.Peek());
            }



            static void Main(string[] args)
            {
                Genericc();
                Nongenericc();
            }
        }
    }
}


