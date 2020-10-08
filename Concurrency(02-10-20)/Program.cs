using System;
using System.Collections.Concurrent;
using System.Collections;
using System.Collections.Generic;

namespace Concurrency
{
    class Program
    {
        public static void Con()
        {
            ConcurrentStack<int> s = new ConcurrentStack<int>();
            s.Push(50);
            s.Push(100);
            s.Push(150);
            s.Push(200);
            s.Push(250);
            s.Push(300);

            if (s.IsEmpty)
            {
                Console.WriteLine("The stack is empty!");
            }

            else
            {
                Console.WriteLine("The stack isn't empty");
            }
        }


        public static void ConcurrentMethod()
        {
            ConcurrentDictionary<int, string> dict = new
   ConcurrentDictionary<int, string>();
            bool firstItem = dict.TryAdd(1, "First");
            bool secondItem = dict.TryAdd(2, "Second");

            string itemValue1;
            string itemValue2;
            bool doesItemOneExist = dict.TryGetValue(1, out itemValue1);  //returns true
            Console.WriteLine(itemValue1); //Print "First"

            bool doesItemTwoExist = dict.TryGetValue(2, out itemValue2);  //returns false
            Console.WriteLine(itemValue2); //Print null
        }

        public static void SortedListMethod()
        {



            SortedList list = new SortedList();
            list.Add("1", "One");
            list.Add("2", "Two");
            list.Add("3", "Three");
            list.Add("4", "Four");
            list.Add("5", "Five");
            list.Add("6", "Six");
            list.Add("7", "Seven");
            list.Add("8", "Eight");
            Console.WriteLine("Key and Value of SortedList....");
            foreach (DictionaryEntry k in list)
            Console.WriteLine("Key: {0}, Value: {1}", k.Key, k.Value);
            Console.WriteLine("SortedList having the value? " + list.ContainsValue("Three"));
            Console.WriteLine("SortedList object has a fixed size? = " + list.IsFixedSize);
            Console.WriteLine("Does the SortedList object contains key 10? = " + list.ContainsKey("10"));
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Con();
            ConcurrentMethod();
            SortedListMethod();
        }
    } 
}


