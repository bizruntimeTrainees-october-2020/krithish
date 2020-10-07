using System;
using System.Collections;
using System.Collections.Generic;

namespace Collectionss
{
    class Arrays
    {
        public static void DictonaryMethod()
        {
            Dictionary<int, String> d_obj = new Dictionary<int, String>(4);
            d_obj.Add(1, "KaKa");
            d_obj.Add(2, "Cristiano");
            d_obj.Add(3, "Messi");
            d_obj.Add(4, "Neymar J R");

            for (int i = 1; i <= d_obj.Count; i++)
            {
                Console.WriteLine(d_obj[i]);

            }
            Console.WriteLine("Total Number of Names : " + d_obj.Count);

        }
        public static void ListMethod()
        {
            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");

            foreach (var l in cities)
            {
                Console.WriteLine(l);
            }


            Console.WriteLine("No of Cities: " + cities.Count);


        }

        public static void ArrayMethod()
        {
            var number = new List<int>() { 10, 20, 30, 40, 50 };
            number.Insert(2, 21);
            foreach (var n in number)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Inserted element is shown in above numbers");
            number.Remove(40);
            foreach (var r in number)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("The Number 40 is not displayed ");
            Console.WriteLine(" List contains the number 20 :  " + number.Contains(20));
            Console.WriteLine(" List contains the number 25 :  " + number.Contains(25));
        }

        public static void SortingMethod()
        {
            SortedList<int, string> RankNames = new SortedList<int, string>();
            RankNames.Add(3, "Barcelona");
            RankNames.Add(1, "Manchester");
            RankNames.Add(2, "Juventus");
            RankNames.Add(4, null);
            RankNames.Add(10, "Arsnel");
            RankNames.Add(5, "LiverPool");
            Console.WriteLine("---NumberNames---");
            foreach (var kvp in RankNames)
            {


                Console.WriteLine("Rank:{0}, Club-Name:{1}", kvp.Key, kvp.Value);
            }
        }

        public static void StackMethod()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            Stack<int> myStack = new Stack<int>(arr);
            Console.WriteLine("Stack Elements are ");
            foreach (var item in myStack)
                Console.Write(item + ",");

            Stack<string> stack1 = new Stack<string>();
            stack1.Push("Computers");
            stack1.Push("Information-Technology");
            stack1.Push("Mechanics");
            stack1.Push("Electrical");
            stack1.Push("Aerospace");
            Console.WriteLine("The elements in the stack1 are as:");
            foreach (string s in stack1)
            {
                Console.WriteLine(s);
            }
            stack1.Pop();
            Console.WriteLine("After removal/or pop the element the stack is as:");
            //the element that inserted in last is remove firstly.  
            foreach (string s in stack1)
            {
                Console.WriteLine(s);


            }
            }
            static void Main(string[] args)
            {
                DictonaryMethod();
                ListMethod();
                ArrayMethod();
                SortingMethod();
                StackMethod();



            }

        
    }
}
